namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathsListCommonView (12 fields) F357EBD04D42055C8574EF4DF6781C0C/AA508F84C6318AAAC020B3C5BF893B70 */
public record class CareerPathsListCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_MainSelectable /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LockPavelLabel /* None */,
    PPtr<TextMeshProUGUI> m_UnlockPavelLabel /* None */,
    PPtr<GameObject>[] m_Lines /* None */,
    PPtr<OwlcatMultiSelectable> m_CareerStateSelectable /* None */,
    PPtr<CareerPathListSelectedCareerCommonView> m_SelectedCareerCommonView /* None */,
    PPtr<CareerPathListItemCommonView> m_CareerPathListItemCommonView /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */)
{
    public static CareerPathsListCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainSelectable */
        PPtr<OwlcatMultiSelectable> _m_MainSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LockPavelLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UnlockPavelLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject>[] _m_Lines = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_CareerStateSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<CareerPathListSelectedCareerCommonView> _m_SelectedCareerCommonView = PPtr<CareerPathListSelectedCareerCommonView>.Read(reader);
        PPtr<CareerPathListItemCommonView> _m_CareerPathListItemCommonView = PPtr<CareerPathListItemCommonView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainSelectable,
            _m_LockPavelLabel,
            _m_UnlockPavelLabel,
            _m_Lines,
            _m_CareerStateSelectable,
            _m_SelectedCareerCommonView,
            _m_CareerPathListItemCommonView,
            _m_WidgetList);
    }
}

