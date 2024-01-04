namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LoadingScreenConsoleView (51 fields) 615B6F58ED404BBB6B8E1B7BBC96A066/37BC2F2BEBFBCA9023A206FAB1937FD7 */
public record class LoadingScreenConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<LoadingScreenHints> m_Hints /* None */,
    PPtr<Image>[] m_Points /* None */,
    PPtr<GameObject> m_MapContainer /* None */,
    PPtr<Image> BigArt /* None */,
    PPtr<LoadingScreenGlitchAnimator> m_GlitchAnimator /* None */,
    LoadingScreenImage m_KeyArtTuple /* None */,
    LoadingScreenImage m_WarpThemedScreenTuple /* NeedsAlign */,
    LoadingScreenImage m_BridgeScreenshotTuple /* NeedsAlign */,
    LoadingScreenImage m_StarSystemScreenTuple /* NeedsAlign */,
    LoadingScreenImage m_GlobalMapScreenTuple /* NeedsAlign */,
    LoadingScreenImage m_SpaceShipScreenTuples /* NeedsAlign */,
    SettingTypeScreens m_SettingTypeScreensList /* NeedsAlign */,
    PPtr<Image> m_CharacterPortrait /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CharacterNameText /* None */,
    PPtr<TextMeshProUGUI> m_CharacterDescriptionText /* None */,
    PPtr<Image> m_CharacterWeapon /* None */,
    float m_LoadingDissolveTime /* None */,
    float m_HidingDissolveTime /* None */,
    float m_MinDissolveStep /* None */,
    float m_MaxDissolveStep /* None */,
    float m_HidingMaxDissolveStep /* None */,
    PPtr<CanvasGroup> m_ProgressBarContainer /* None */,
    PPtr<Image> ProgressImage /* None */,
    PPtr<CanvasGroup> m_ProgressPercentContainer /* None */,
    PPtr<TextMeshProUGUI> ProgressPercent /* None */,
    PPtr<CanvasGroup> m_TransferSaveProgressBarContainer /* None */,
    PPtr<Image> m_TransferSaveProgress /* None */,
    PPtr<CanvasGroup> m_TransferSaveCountersContainer /* None */,
    PPtr<TextMeshProUGUI> m_TransferSaveProgressPercent /* None */,
    PPtr<TextMeshProUGUI> m_TransferSaveProgressSize /* None */,
    PPtr<CanvasGroup> m_WaitForUserInputContainer /* None */,
    PPtr<TextMeshProUGUI> m_WaitForUserInputText /* None */,
    PPtr<GameObject> m_CharacterContainer /* None */,
    PPtr<GameObject> m_MainContainer /* None */,
    PPtr<GameObject> m_BottomTitleObject /* None */,
    PPtr<GameObject> m_BottomDescriptionObject /* None */,
    PPtr<TextMeshProUGUI> m_BottomTitleText /* None */,
    PPtr<TextMeshProUGUI> m_BottomDescriptionText /* None */,
    PPtr<TextMeshProUGUI> m_LocationName /* None */,
    int[] m_RandomTwoEqualPercents /* None */,
    int[] RandomTwoWithPriorityPercents /* NeedsAlign */,
    int[] RandomThreeWithPriorityPercents /* NeedsAlign */,
    int[] RandomFourWithPriorityPercents /* NeedsAlign */,
    int[] RandomFiveWithPriorityPercents /* NeedsAlign */,
    float m_DefaultConsoleFontTitleSize /* NeedsAlign */,
    float m_DefaultConsoleFontDescriptionSize /* None */)
{
    public static LoadingScreenConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<LoadingScreenHints> _m_Hints = PPtr<LoadingScreenHints>.Read(reader);
        PPtr<Image>[] _m_Points = BuiltInArray<PPtr<Image>>.Read(reader);
        PPtr<GameObject> _m_MapContainer = PPtr<GameObject>.Read(reader);
        PPtr<Image> _BigArt = PPtr<Image>.Read(reader);
        PPtr<LoadingScreenGlitchAnimator> _m_GlitchAnimator = PPtr<LoadingScreenGlitchAnimator>.Read(reader);
        LoadingScreenImage _m_KeyArtTuple = LoadingScreenImage.Read(reader);
        reader.AlignTo(4); /* m_WarpThemedScreenTuple */
        LoadingScreenImage _m_WarpThemedScreenTuple = LoadingScreenImage.Read(reader);
        reader.AlignTo(4); /* m_BridgeScreenshotTuple */
        LoadingScreenImage _m_BridgeScreenshotTuple = LoadingScreenImage.Read(reader);
        reader.AlignTo(4); /* m_StarSystemScreenTuple */
        LoadingScreenImage _m_StarSystemScreenTuple = LoadingScreenImage.Read(reader);
        reader.AlignTo(4); /* m_GlobalMapScreenTuple */
        LoadingScreenImage _m_GlobalMapScreenTuple = LoadingScreenImage.Read(reader);
        reader.AlignTo(4); /* m_SpaceShipScreenTuples */
        LoadingScreenImage _m_SpaceShipScreenTuples = LoadingScreenImage.Read(reader);
        reader.AlignTo(4); /* m_SettingTypeScreensList */
        SettingTypeScreens _m_SettingTypeScreensList = SettingTypeScreens.Read(reader);
        reader.AlignTo(4); /* m_CharacterPortrait */
        PPtr<Image> _m_CharacterPortrait = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CharacterNameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CharacterDescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CharacterWeapon = PPtr<Image>.Read(reader);
        float _m_LoadingDissolveTime = reader.ReadF32();
        float _m_HidingDissolveTime = reader.ReadF32();
        float _m_MinDissolveStep = reader.ReadF32();
        float _m_MaxDissolveStep = reader.ReadF32();
        float _m_HidingMaxDissolveStep = reader.ReadF32();
        PPtr<CanvasGroup> _m_ProgressBarContainer = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _ProgressImage = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_ProgressPercentContainer = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _ProgressPercent = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_TransferSaveProgressBarContainer = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_TransferSaveProgress = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_TransferSaveCountersContainer = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TransferSaveProgressPercent = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TransferSaveProgressSize = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_WaitForUserInputContainer = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_WaitForUserInputText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_CharacterContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_MainContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_BottomTitleObject = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_BottomDescriptionObject = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BottomTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BottomDescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LocationName = PPtr<TextMeshProUGUI>.Read(reader);
        int[] _m_RandomTwoEqualPercents = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* RandomTwoWithPriorityPercents */
        int[] _RandomTwoWithPriorityPercents = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* RandomThreeWithPriorityPercents */
        int[] _RandomThreeWithPriorityPercents = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* RandomFourWithPriorityPercents */
        int[] _RandomFourWithPriorityPercents = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* RandomFiveWithPriorityPercents */
        int[] _RandomFiveWithPriorityPercents = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_DefaultConsoleFontTitleSize */
        float _m_DefaultConsoleFontTitleSize = reader.ReadF32();
        float _m_DefaultConsoleFontDescriptionSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Hints,
            _m_Points,
            _m_MapContainer,
            _BigArt,
            _m_GlitchAnimator,
            _m_KeyArtTuple,
            _m_WarpThemedScreenTuple,
            _m_BridgeScreenshotTuple,
            _m_StarSystemScreenTuple,
            _m_GlobalMapScreenTuple,
            _m_SpaceShipScreenTuples,
            _m_SettingTypeScreensList,
            _m_CharacterPortrait,
            _m_CharacterNameText,
            _m_CharacterDescriptionText,
            _m_CharacterWeapon,
            _m_LoadingDissolveTime,
            _m_HidingDissolveTime,
            _m_MinDissolveStep,
            _m_MaxDissolveStep,
            _m_HidingMaxDissolveStep,
            _m_ProgressBarContainer,
            _ProgressImage,
            _m_ProgressPercentContainer,
            _ProgressPercent,
            _m_TransferSaveProgressBarContainer,
            _m_TransferSaveProgress,
            _m_TransferSaveCountersContainer,
            _m_TransferSaveProgressPercent,
            _m_TransferSaveProgressSize,
            _m_WaitForUserInputContainer,
            _m_WaitForUserInputText,
            _m_CharacterContainer,
            _m_MainContainer,
            _m_BottomTitleObject,
            _m_BottomDescriptionObject,
            _m_BottomTitleText,
            _m_BottomDescriptionText,
            _m_LocationName,
            _m_RandomTwoEqualPercents,
            _RandomTwoWithPriorityPercents,
            _RandomThreeWithPriorityPercents,
            _RandomFourWithPriorityPercents,
            _RandomFiveWithPriorityPercents,
            _m_DefaultConsoleFontTitleSize,
            _m_DefaultConsoleFontDescriptionSize);
    }
}

