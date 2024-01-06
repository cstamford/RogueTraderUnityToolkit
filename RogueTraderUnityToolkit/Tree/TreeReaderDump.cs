using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace RogueTraderUnityToolkit.Tree;

public sealed class TreeReaderDump(Stream stream) : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartObject(
        UnityObjectType type,
        Hash128 scriptHash,
        Hash128 hash) => _writer.WriteLine($"** {type} {scriptHash} {hash} **");

    public void FinishObject(
        UnityObjectType type,
        Hash128 scriptHash,
        Hash128 hash) => _writer.WriteLine();

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
