using RogueTraderUnityToolkit.Unity;

namespace Codegen;

public interface IAnalyseTreeReader : IObjectTypeTreeReader
{
    public void StartFile(SerializedFile file);
    public void StartObject(UnityObjectType type);
}
