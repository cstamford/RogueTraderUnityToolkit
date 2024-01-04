namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootUnitCardConsoleView (9 fields) 9DA892487BF8553728C04E511D30E5AF/18F19D214A3695FA0D301FDEC32897D4 */
public record class StatCheckLootUnitCardConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_UnitNameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_StatNameLabel /* None */,
    PPtr<TextMeshProUGUI> m_StatValueLabel /* None */,
    PPtr<Image> m_UnitPortraitImage /* None */,
    PPtr<OwlcatSelectable> m_Selectable /* None */)
{
    public static StatCheckLootUnitCardConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UnitNameLabel */
        PPtr<TextMeshProUGUI> _m_UnitNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatValueLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_UnitPortraitImage = PPtr<Image>.Read(reader);
        PPtr<OwlcatSelectable> _m_Selectable = PPtr<OwlcatSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitNameLabel,
            _m_StatNameLabel,
            _m_StatValueLabel,
            _m_UnitPortraitImage,
            _m_Selectable);
    }
}

