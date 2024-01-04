namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UISettingsGroup (7 fields) D84AF69CE90116150E24B9BECF15CD35/9C8A015B55434B846B19ADD8D890AD1F */
public record class UISettingsGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString Title /* NeedsAlign */,
    int SettingPlatform /* NeedsAlign */,
    PPtr<UISettingsEntityBase>[] SettingsList /* None */)
{
    public static UISettingsGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Title */
        LocalizedString _Title = LocalizedString.Read(reader);
        reader.AlignTo(4); /* SettingPlatform */
        int _SettingPlatform = reader.ReadS32();
        PPtr<UISettingsEntityBase>[] _SettingsList = BuiltInArray<PPtr<UISettingsEntityBase>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Title,
            _SettingPlatform,
            _SettingsList);
    }
}

