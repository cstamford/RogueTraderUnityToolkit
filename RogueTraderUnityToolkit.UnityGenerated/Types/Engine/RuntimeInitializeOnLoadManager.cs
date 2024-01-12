namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RuntimeInitializeOnLoadManager (0 fields) RuntimeInitializeOnLoadManager 55A238E3B50102465496FEF531BB8543 */
public record class RuntimeInitializeOnLoadManager (
    ) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.RuntimeInitializeOnLoadManager;
    public static Hash128 Hash => new("55A238E3B50102465496FEF531BB8543");
    public static RuntimeInitializeOnLoadManager Read(EndianBinaryReader reader) => new();
}

