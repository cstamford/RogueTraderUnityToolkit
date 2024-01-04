namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickDamageNullifierView (11 fields) 690CCA99823CA10F691F940455ED6B5D/210777C3BF9190CD28438B8A817AF39C */
public record class TooltipBrickDamageNullifierView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderText /* NeedsAlign */,
    PPtr<RollSlider> m_RollSlider /* None */,
    PPtr<TextMeshProUGUI> m_ResultValueText /* None */,
    PPtr<TextMeshProUGUI> m_ReasonsText /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<ReasonBuffItemView> m_ReasonBuffItemView /* None */,
    PPtr<TextMeshProUGUI> m_ResultText /* None */)
{
    public static TooltipBrickDamageNullifierView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderText */
        PPtr<TextMeshProUGUI> _m_HeaderText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RollSlider> _m_RollSlider = PPtr<RollSlider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResultValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReasonsText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ReasonBuffItemView> _m_ReasonBuffItemView = PPtr<ReasonBuffItemView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResultText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderText,
            _m_RollSlider,
            _m_ResultValueText,
            _m_ReasonsText,
            _m_WidgetList,
            _m_ReasonBuffItemView,
            _m_ResultText);
    }
}

