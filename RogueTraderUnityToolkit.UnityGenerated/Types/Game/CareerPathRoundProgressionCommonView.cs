namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathRoundProgressionCommonView (18 fields) 98A7097C2373E0B6AABFF16E5E2D890F/3262707EB9F8E429E7152F3D2E097F6A */
public record class CareerPathRoundProgressionCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_ProgressBarContainer /* NeedsAlign */,
    PPtr<Image> m_AppliedProgressBar /* None */,
    PPtr<Image> m_CurrentProgressBar /* None */,
    PPtr<Image> m_ProgressBackground /* None */,
    PPtr<RectTransform> m_RankEntriesContainer /* None */,
    PPtr<RankEntryItemCommonView> m_CareerPathRankEntryCommonView /* None */,
    PPtr<RectTransform> m_PointerTransform /* None */,
    PPtr<FadeAnimator> m_PointerAnimator /* None */,
    float m_PointerRotationDuration /* None */,
    PPtr<CareerPathListItemCommonView> m_CareerPathListItemCommonView /* None */,
    CareerPathRoundProgressionConfig[] Configs /* None */,
    NavigationParameters m_NavigationParameters /* None */,
    byte IsShip /* NeedsAlign */,
    PPtr<Image> m_ShipIcon /* NeedsAlign */)
{
    public static CareerPathRoundProgressionCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ProgressBarContainer */
        PPtr<RectTransform> _m_ProgressBarContainer = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_AppliedProgressBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_CurrentProgressBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ProgressBackground = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_RankEntriesContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RankEntryItemCommonView> _m_CareerPathRankEntryCommonView = PPtr<RankEntryItemCommonView>.Read(reader);
        PPtr<RectTransform> _m_PointerTransform = PPtr<RectTransform>.Read(reader);
        PPtr<FadeAnimator> _m_PointerAnimator = PPtr<FadeAnimator>.Read(reader);
        float _m_PointerRotationDuration = reader.ReadF32();
        PPtr<CareerPathListItemCommonView> _m_CareerPathListItemCommonView = PPtr<CareerPathListItemCommonView>.Read(reader);
        CareerPathRoundProgressionConfig[] _Configs = BuiltInArray<CareerPathRoundProgressionConfig>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* IsShip */
        byte _IsShip = reader.ReadU8();
        reader.AlignTo(4); /* m_ShipIcon */
        PPtr<Image> _m_ShipIcon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ProgressBarContainer,
            _m_AppliedProgressBar,
            _m_CurrentProgressBar,
            _m_ProgressBackground,
            _m_RankEntriesContainer,
            _m_CareerPathRankEntryCommonView,
            _m_PointerTransform,
            _m_PointerAnimator,
            _m_PointerRotationDuration,
            _m_CareerPathListItemCommonView,
            _Configs,
            _m_NavigationParameters,
            _IsShip,
            _m_ShipIcon);
    }
}

