namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoChoicesMadeView (8 fields) 9C760296226FBC7CD39749BDAD1D9D0C/445352501E65E391A0DB6E970395DD6F */
public record class CharInfoChoicesMadeView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoSoulMarkShiftRecordPCView> m_SoulMarkShiftRecordView /* None */)
{
    public static CharInfoChoicesMadeView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoSoulMarkShiftRecordPCView> _m_SoulMarkShiftRecordView = PPtr<CharInfoSoulMarkShiftRecordPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Label,
            _m_WidgetList,
            _m_SoulMarkShiftRecordView);
    }
}

