namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootUnitCardPCView (12 fields) 99B4AAB62F1756A3CA979F2C17B89FBF/D6F58C8BA7D225024B05CD70AE287950 */
public record class StatCheckLootUnitCardPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_UnitNameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_StatNameLabel /* None */,
    PPtr<TextMeshProUGUI> m_StatValueLabel /* None */,
    PPtr<Image> m_UnitPortraitImage /* None */,
    PPtr<OwlcatSelectable> m_Selectable /* None */,
    PPtr<OwlcatButton> m_CheckStatButton /* None */,
    PPtr<TextMeshProUGUI> m_CheckStatButtonLabel /* None */,
    PPtr<OwlcatButton> m_SwitchUnitButton /* None */)
{
    public static StatCheckLootUnitCardPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_CheckStatButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CheckStatButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_SwitchUnitButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitNameLabel,
            _m_StatNameLabel,
            _m_StatValueLabel,
            _m_UnitPortraitImage,
            _m_Selectable,
            _m_CheckStatButton,
            _m_CheckStatButtonLabel,
            _m_SwitchUnitButton);
    }
}

