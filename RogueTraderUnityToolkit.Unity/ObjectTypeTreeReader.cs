using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public interface IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree);

    public void EndTree(
        in ObjectTypeTree tree);

    public void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree);

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader);

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength);

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength);

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength);

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        StringPool.Entry cls,
        StringPool.Entry ns,
        StringPool.Entry asm);

    public void Align(
        in ObjectParserNode node,
        int alignedBytes);
};

public sealed class ObjectTypeTreeNullReader : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    { } 

    public void EndTree(
        in ObjectTypeTree tree)
    { }

    public void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    { }

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    { }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    { }

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    { }

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    { }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        StringPool.Entry cls,
        StringPool.Entry ns,
        StringPool.Entry asm)
    { }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    { }
}

public sealed class ObjectTypeTreeMultiReader(
    params IObjectTypeTreeReader[] readers) 
    : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.BeginTree(tree); }
    }

    public void EndTree(
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.EndTree(tree); }
    }

    public void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.Visit(node, tree); }
    }

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadPrimitive(node, nodeReader); }
    }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength); }
    }

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadComplexArray(node, dataNode, arrayLength); }
    }

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadString(node, nodeReader, stringLength); }
    }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        StringPool.Entry cls,
        StringPool.Entry ns,
        StringPool.Entry asm)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadRefObjectRegistry(node, refId, cls, ns, asm); }
    }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.Align(node, alignedBytes); }
    }
}
