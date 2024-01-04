namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipAnomalyConsoleView (16 fields) 2E35686130F7B96E63ED536D812E595F/506E9EEFD78C0ED2FAA7CA1142F5BCB2 */
public record class OvertipAnomalyConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_ExploreAnomalyButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AnomalyName /* None */,
    PPtr<RectTransform> m_CanvasRectTransform /* None */,
    PPtr<Image> m_NoiseAroundImage /* None */,
    PPtr<Sprite>[] m_RandomNoises /* None */,
    PPtr<TextMeshProUGUI> m_TopInformation /* None */,
    PPtr<GameObject> m_LootTypeIcon /* None */,
    PPtr<GameObject> m_QuestionMarkIcon /* None */,
    PPtr<GameObject> m_WrenchIcon /* None */,
    PPtr<GameObject> m_EnemyIcon /* None */,
    PPtr<GameObject> m_EnemyCircle /* None */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */)
{
    public static OvertipAnomalyConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExploreAnomalyButton */
        PPtr<OwlcatButton> _m_ExploreAnomalyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AnomalyName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_CanvasRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_NoiseAroundImage = PPtr<Image>.Read(reader);
        PPtr<Sprite>[] _m_RandomNoises = BuiltInArray<PPtr<Sprite>>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TopInformation = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LootTypeIcon = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_QuestionMarkIcon = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_WrenchIcon = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_EnemyIcon = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_EnemyCircle = PPtr<GameObject>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExploreAnomalyButton,
            _m_AnomalyName,
            _m_CanvasRectTransform,
            _m_NoiseAroundImage,
            _m_RandomNoises,
            _m_TopInformation,
            _m_LootTypeIcon,
            _m_QuestionMarkIcon,
            _m_WrenchIcon,
            _m_EnemyIcon,
            _m_EnemyCircle,
            _m_TargetPingEntity);
    }
}

