using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Runtime.CompilerServices;

namespace Codegen;

public sealed class RawTreeDumper(Stream stream) 
    : ObjectTypeTreeStackReader<ushort>, IAnalyseTreeReader
{
    public void StartFile(
        SerializedFile file)
    {
        _writer.WriteLine($"#### {file.Info.Identifier} ####");
    }

    public void StartObject(
        UnityObjectType type)
    {
        _writer.WriteLine();
        _writer.WriteLine($"** {type} **");
    }
    
    public override void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.BeginNode(node, tree);

        if (IsFirstArrayIndex)
        {
            _writer.WriteLine($"{' '.Repeat(_nodeLevel * 4)}{node.ToString()}");
        }

        ++_nodeLevel;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.EndNode(node, tree);
        --_nodeLevel;
    }

    private readonly TextWriter _writer = new StreamWriter(stream) { AutoFlush = true };
    private int _nodeLevel;
}