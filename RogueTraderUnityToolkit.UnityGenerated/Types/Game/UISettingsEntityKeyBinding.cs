namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UISettingsEntityKeyBinding (13 fields) 50C1EBEAD04F09692EA4682407DCDEEA/1FC6824A7D449169B71D1B3F2861F1C5 */
public record class UISettingsEntityKeyBinding(
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
    byte SplitPressTrigger /* NeedsAlign */,
    byte IsHoldTrigger /* NeedsAlign */)
{
    public static UISettingsEntityKeyBinding Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* SplitPressTrigger */
        byte _SplitPressTrigger = reader.ReadU8();
        reader.AlignTo(4); /* IsHoldTrigger */
        byte _IsHoldTrigger = reader.ReadU8();
        
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
            _SplitPressTrigger,
            _IsHoldTrigger);
    }
}

