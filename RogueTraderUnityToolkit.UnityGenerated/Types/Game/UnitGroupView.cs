namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitGroupView (10 fields) D5CB22D7CC3DA741F49A8A68572D21C3/56E9B1F43DBF6020EC69E3202CC646DF */
public record class UnitGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    ColorRGBA GizmosColor /* NeedsAlign */,
    byte DisableOnSimplified /* None */,
    byte IgnoreInEncoutnerStatistic /* NeedsAlign */,
    SquadSettings[] Squads /* NeedsAlign */)
{
    public static UnitGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* GizmosColor */
        ColorRGBA _GizmosColor = ColorRGBA.Read(reader);
        byte _DisableOnSimplified = reader.ReadU8();
        reader.AlignTo(4); /* IgnoreInEncoutnerStatistic */
        byte _IgnoreInEncoutnerStatistic = reader.ReadU8();
        reader.AlignTo(4); /* Squads */
        SquadSettings[] _Squads = BuiltInArray<SquadSettings>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _GizmosColor,
            _DisableOnSimplified,
            _IgnoreInEncoutnerStatistic,
            _Squads);
    }
}

