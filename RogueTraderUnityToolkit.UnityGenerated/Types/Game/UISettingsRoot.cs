namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UISettingsRoot (14 fields) D48CA31D4E523F4A8E159133DD65A1C9/CAC608CD0423CA7A37ADD540521A26E0 */
public record class UISettingsRoot(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UISettingsGroup>[] GameSettings /* NeedsAlign */,
    PPtr<UISettingsGroup>[] DifficultySettings /* None */,
    PPtr<UISettingsGroup>[] GraphicsSettings /* None */,
    PPtr<UISettingsGroup>[] Controls /* None */,
    PPtr<UISettingsGroup>[] SoundSettings /* None */,
    PPtr<UISettingsGroup>[] StartGame /* None */,
    PPtr<UISettingsGroup>[] DisplaySettings /* None */,
    PPtr<UISettingsGroup>[] AccessiabilitySettings /* None */,
    PPtr<UISettingsGroup>[] SafeZone /* None */,
    UISettingsMechanicLinks UISettings /* None */)
{
    public static UISettingsRoot Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* GameSettings */
        PPtr<UISettingsGroup>[] _GameSettings = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _DifficultySettings = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _GraphicsSettings = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _Controls = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _SoundSettings = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _StartGame = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _DisplaySettings = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _AccessiabilitySettings = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        PPtr<UISettingsGroup>[] _SafeZone = BuiltInArray<PPtr<UISettingsGroup>>.Read(reader);
        UISettingsMechanicLinks _UISettings = UISettingsMechanicLinks.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _GameSettings,
            _DifficultySettings,
            _GraphicsSettings,
            _Controls,
            _SoundSettings,
            _StartGame,
            _DisplaySettings,
            _AccessiabilitySettings,
            _SafeZone,
            _UISettings);
    }
}

