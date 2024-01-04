namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UISettingsEntitySliderFontSize (17 fields) 3D58BF48C45BB3582D939B8C336042E9/47B20AC6BA1A92C78890A4CBD74F0B25 */
public record class UISettingsEntitySliderFontSize(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString m_Description /* NeedsAlign */,
    LocalizedString m_TooltipDescription /* NeedsAlign */,
    BlueprintEncyclopediaPageReference m_EncyclopediaDescription /* NeedsAlign */,
    byte m_ShowVisualConnection /* NeedsAlign */,
    byte m_IAmSetHandler /* NeedsAlign */,
    int m_SettingsPlatform /* NeedsAlign */,
    byte m_HasCoopTooltipDescription /* None */,
    byte m_ShowValueText /* NeedsAlign */,
    float m_MinValue /* NeedsAlign */,
    float m_MaxValue /* None */,
    byte m_IsPercentage /* None */,
    float m_Step /* NeedsAlign */,
    int m_DecimalPlaces /* None */)
{
    public static UISettingsEntitySliderFontSize Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Description */
        LocalizedString _m_Description = LocalizedString.Read(reader);
        reader.AlignTo(4); /* m_TooltipDescription */
        LocalizedString _m_TooltipDescription = LocalizedString.Read(reader);
        reader.AlignTo(4); /* m_EncyclopediaDescription */
        BlueprintEncyclopediaPageReference _m_EncyclopediaDescription = BlueprintEncyclopediaPageReference.Read(reader);
        reader.AlignTo(4); /* m_ShowVisualConnection */
        byte _m_ShowVisualConnection = reader.ReadU8();
        reader.AlignTo(4); /* m_IAmSetHandler */
        byte _m_IAmSetHandler = reader.ReadU8();
        reader.AlignTo(4); /* m_SettingsPlatform */
        int _m_SettingsPlatform = reader.ReadS32();
        byte _m_HasCoopTooltipDescription = reader.ReadU8();
        reader.AlignTo(4); /* m_ShowValueText */
        byte _m_ShowValueText = reader.ReadU8();
        reader.AlignTo(4); /* m_MinValue */
        float _m_MinValue = reader.ReadF32();
        float _m_MaxValue = reader.ReadF32();
        byte _m_IsPercentage = reader.ReadU8();
        reader.AlignTo(4); /* m_Step */
        float _m_Step = reader.ReadF32();
        int _m_DecimalPlaces = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Description,
            _m_TooltipDescription,
            _m_EncyclopediaDescription,
            _m_ShowVisualConnection,
            _m_IAmSetHandler,
            _m_SettingsPlatform,
            _m_HasCoopTooltipDescription,
            _m_ShowValueText,
            _m_MinValue,
            _m_MaxValue,
            _m_IsPercentage,
            _m_Step,
            _m_DecimalPlaces);
    }
}

