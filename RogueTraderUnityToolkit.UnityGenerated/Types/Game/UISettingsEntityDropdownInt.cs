namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UISettingsEntityDropdownInt (12 fields) 391B35B6464C5FA81F0EA6B31629F8A6/C962B9BB6C3C956A1E3C866678168981 */
public record class UISettingsEntityDropdownInt(
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
    AsciiString[] m_LocalizedValues /* NeedsAlign */)
{
    public static UISettingsEntityDropdownInt Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_LocalizedValues */
        AsciiString[] _m_LocalizedValues = BuiltInArray<AsciiString>.Read(reader);
        
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
            _m_LocalizedValues);
    }
}

