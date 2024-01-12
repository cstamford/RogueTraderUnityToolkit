namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $DelayedCallManager (0 fields) DelayedCallManager 86113E640E726E7D7E104AE8BD4446B8 */
public record class DelayedCallManager (
    ) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.DelayedCallManager;
    public static Hash128 Hash => new("86113E640E726E7D7E104AE8BD4446B8");
    public static DelayedCallManager Read(EndianBinaryReader reader) => new();
}

