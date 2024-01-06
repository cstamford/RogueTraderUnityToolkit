using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace RogueTraderUnityToolkit.Tree;

public interface ITreeReader : IObjectTypeTreeReader
{
    public void StartObject(
        UnityObjectType type,
        Hash128 scriptHash,
        Hash128 hash);

    public void FinishObject(
        UnityObjectType type,
        Hash128 scriptHash,
        Hash128 hash);
}
