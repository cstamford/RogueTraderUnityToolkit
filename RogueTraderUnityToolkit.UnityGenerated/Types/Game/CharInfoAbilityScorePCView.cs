namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoAbilityScorePCView (12 fields) EDDA914F318D90E53C4AF6B9B9F51D04/B468B0D8CC6C20AED12BB00D698FC518 */
public record class CharInfoAbilityScorePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ShortName /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LongName /* None */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<TextMeshProUGUI> m_DiffValueLabel /* None */,
    PPtr<GameObject> m_DiffState /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* None */,
    int m_SecondaryCharSizePercent /* None */,
    ColorRGBA m_AccentCharColor /* None */)
{
    public static CharInfoAbilityScorePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShortName */
        PPtr<TextMeshProUGUI> _m_ShortName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LongName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DiffValueLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_DiffState = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        int _m_SecondaryCharSizePercent = reader.ReadS32();
        ColorRGBA _m_AccentCharColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShortName,
            _m_LongName,
            _m_Value,
            _m_DiffValueLabel,
            _m_DiffState,
            _m_Selectable,
            _m_SecondaryCharSizePercent,
            _m_AccentCharColor);
    }
}

