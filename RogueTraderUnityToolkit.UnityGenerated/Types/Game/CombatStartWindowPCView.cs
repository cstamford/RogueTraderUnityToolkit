namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatStartWindowPCView (11 fields) 089C6900AA6182338B8F5FBB91232E53/12255D1C95F1A08008679C91D439C102 */
public record class CombatStartWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CanDeployLabel /* None */,
    PPtr<TextMeshProUGUI> m_CannotDeployLabel /* None */,
    PPtr<OwlcatButton> m_StartBattleButton /* None */,
    PPtr<TextMeshProUGUI> m_ButtonLabel /* None */,
    PPtr<CombatStartCoopProgressBaseView> m_ProgressBaseView /* None */,
    PPtr<Canvas> m_Canvas /* None */)
{
    public static CombatStartWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CanDeployLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CannotDeployLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_StartBattleButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CombatStartCoopProgressBaseView> _m_ProgressBaseView = PPtr<CombatStartCoopProgressBaseView>.Read(reader);
        PPtr<Canvas> _m_Canvas = PPtr<Canvas>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_CanDeployLabel,
            _m_CannotDeployLabel,
            _m_StartBattleButton,
            _m_ButtonLabel,
            _m_ProgressBaseView,
            _m_Canvas);
    }
}

