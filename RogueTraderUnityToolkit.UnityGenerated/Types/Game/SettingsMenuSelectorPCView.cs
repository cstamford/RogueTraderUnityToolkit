namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsMenuSelectorPCView (5 fields) 8904BB4E1BF036DD9FD0253CC7FC85A7/04875508A6889F969BC26D09E30D164F */
public record class SettingsMenuSelectorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SettingsMenuEntityPCView>[] m_MenuEntities /* NeedsAlign */)
{
    public static SettingsMenuSelectorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MenuEntities */
        PPtr<SettingsMenuEntityPCView>[] _m_MenuEntities = BuiltInArray<PPtr<SettingsMenuEntityPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MenuEntities);
    }
}

