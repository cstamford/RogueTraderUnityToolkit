namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerSummonPoolSettings (5 fields) 65863ECF5FD1A196404E991C41D12CE6/FC1F0C4B57F81EDCF62667C92FC9F5C8 */
public record class SpawnerSummonPoolSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintSummonPoolReference[] Pools /* NeedsAlign */)
{
    public static SpawnerSummonPoolSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Pools */
        BlueprintSummonPoolReference[] _Pools = BuiltInArray<BlueprintSummonPoolReference>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Pools);
    }
}

