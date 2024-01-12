namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $StreamingManager (0 fields) StreamingManager 80963267FB7DBA9219B0A0A8DDAA3DDF */
public record class StreamingManager (
    ) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.StreamingManager;
    public static Hash128 Hash => new("80963267FB7DBA9219B0A0A8DDAA3DDF");
    public static StreamingManager Read(EndianBinaryReader reader) => new();
}

