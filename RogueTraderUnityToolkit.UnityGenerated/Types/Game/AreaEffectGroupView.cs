namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AreaEffectGroupView (7 fields) B2F0D6D233EA7CBD3DEA7F91DAD35198/512ED690DB84BDB1D6B93795B2CBF279 */
public record class AreaEffectGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<GameObject> ComponentsParent /* NeedsAlign */)
{
    public static AreaEffectGroupView Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* ComponentsParent */
        PPtr<GameObject> _ComponentsParent = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _ComponentsParent);
    }
}

