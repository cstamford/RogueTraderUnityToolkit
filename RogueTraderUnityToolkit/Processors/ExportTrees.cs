using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueTraderUnityToolkit.Processors;

public readonly struct ExportTrees : IAssetProcessor
{
    public void Process(
        Args args,
        AssetBundle bundle,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed)
    {
        assetCountProcessed = 0;
        assetCountSkipped = 0;
        assetCountFailed = 0;

        if (asset is not SerializedFile file)
        {
            assetCountSkipped = 1;
            return;
        };

        SerializedFileReader fileReader = new(file);

        bool exportToDir = args.ExportPath != null;
        bool exportToStdOut = !exportToDir && args.ExportStdOut;

        Stream stream = new NullStream();

        if (exportToDir)
        {
            throw new("Not yet implemented.");
        }
        else if (exportToStdOut)
        {
            stream = Console.OpenStandardOutput();
        }

        int processed = 0;
        byte[] buffer = ArrayPool<byte>.Shared.Rent(1024);

        fileReader.ReadObjectRange(
            treeReader: new ExportTreesReader(stream, buffer),
            withDebugReader: args.Debug,
            startIdx: 0,
            endIdx: file.ObjectInstances.Length,
            fnStartedOne: (_, _) => { },
            fnFinishedOne: (_, _) =>
            {
                ++processed;
                stream.WriteByte((byte)'\n');
                stream.WriteByte((byte)'\n');
            });

        ArrayPool<byte>.Shared.Return(buffer);

        assetCountProcessed = processed;
    }

    public void End(Args args, ISerializedAsset[] assets) { }
}

// TODO: Currently broken compilation, needs minor refactor to store builder length.
public sealed class ExportTreesReader(Stream stream, byte[] buffer) : ObjectTypeTreeStackReader<ushort>
{
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.BeginNode(node, tree);

        if (TryPopNodeFrames(node.Level, out ushort length))
        {
            _builder.Length = length;
            _builder.Append(':');
            _builder.Append(node.Name);
        }
        else
        {
            if (TreeDepth == 1) _builder.Length = 0;

            _builder.Append('$');
            _builder.Append('[');
            _builder.Append(node.TypeName);
            _builder.Append(']');
        }

        if (ArrayDepth > 0 && node.Index == ArrayDataNodeIdx)
        {
            _builder.Append('[');
            _builder.Append(ArrayIndex);
            _builder.Append(']');
        }

        TreeNodeStack.Push((ushort)_builder.Length);
        Debug.Assert(TreeNodeStack.Count == node.Level + 1);
    }

    public override void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        _writer.Write(_builder.Span);
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type].Span);
        _writer.Write(" = "u8);

        switch (node.Type)
        {
            case ObjectParserType.U64:
                _writer.Write(nodeReader.ReadU64(node));
                break;

            case ObjectParserType.U32:
                _writer.Write(nodeReader.ReadU32(node));
                break;

            case ObjectParserType.U16:
                _writer.Write(nodeReader.ReadU16(node));
                break;

            case ObjectParserType.U8:
                _writer.Write(nodeReader.ReadU8(node));
                break;

            case ObjectParserType.S64:
                _writer.Write(nodeReader.ReadS64(node));
                break;

            case ObjectParserType.S32:
                _writer.Write(nodeReader.ReadS32(node));
                break;

            case ObjectParserType.S16:
                _writer.Write(nodeReader.ReadS16(node));
                break;

            case ObjectParserType.S8:
                _writer.Write(nodeReader.ReadS8(node));
                break;

            case ObjectParserType.F64:
                _writer.Write(nodeReader.ReadF64(node));
                break;

            case ObjectParserType.F32:
                _writer.Write(nodeReader.ReadF32(node));
                break;

            case ObjectParserType.Bool:
                _writer.Write(nodeReader.ReadBool(node));
                break;

            case ObjectParserType.Char:
                _writer.Write(nodeReader.ReadChar(node));
                break;

            default:
                Debug.Assert(false);
                break;
        }

        _writer.Write('\n');
    }

    public override void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        _writer.Write(_builder.Span);
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type].Span);
        _writer.Write('<');
        _writer.Write(arrayLength);
        _writer.Write("> = (data not included)\n"u8);
    }

    public override void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    {
        _writer.Write(_builder.Span);
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type].Span);
        _writer.Write('<');
        _writer.Write(stringLength);
        _writer.Write("> = \""u8);
        _writer.Write(nodeReader.ReadString(node, stringLength, readLength: 128));
        _writer.Write("\"\n"u8);
    }

    public override void ReadReferencedObject(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        _writer.Write(_builder.Span);
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type].Span);
        _writer.Write(" = ["u8);
        _writer.Write(refId);
        _writer.Write(", "u8);
        _writer.Write(asm);
        _writer.Write(", "u8);
        _writer.Write(ns);
        _writer.Write(", "u8);
        _writer.Write(cls);
        _writer.Write("]\n"u8);
    }

    private readonly FastTextWriter _writer = new(stream);
    private readonly FastStringBuilder _builder = new(buffer);
    private static readonly Dictionary<ObjectParserType, Memory<byte>> _typePoolEntries =
        Enum.GetValues<ObjectParserType>()
            .Zip(
                Enum.GetNames<ObjectParserType>(),
                (value, name) => (value, Encoding.ASCII.GetBytes(name).AsMemory()))
            .ToDictionary();
}
