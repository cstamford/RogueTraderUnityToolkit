namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceCombatCurrentUnitView (28 fields) 87E253928B8B6D4AF42951747ED23AE0/F3FB0C42D767AAA470452EF7DA0CBFED */
public record class SurfaceCombatCurrentUnitView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> Button /* NeedsAlign */,
    PPtr<SurfaceCombatUnitPortraitZone> m_CharacetrPortraitZone /* None */,
    PPtr<GameObject> m_DifficultyBlock /* None */,
    PPtr<TextMeshProUGUI> m_DifficultyText /* None */,
    PPtr<SurfaceCombatUnitPortraitZone> m_NoPortraitZone /* None */,
    PPtr<UnitHealthPartTextPCView> UnitHealthPartTextPCView /* None */,
    PPtr<UnitHealthPartProgressPCView> UnitHealthPartProgressPCView /* None */,
    PPtr<TextMeshProUGUI> m_NameNormal /* None */,
    PPtr<UnitBuffPartPCView> UnitBuffPartPCView /* None */,
    byte HasMarkers /* None */,
    PPtr<GameObject> m_WillLossTurn /* NeedsAlign */,
    PPtr<GameObject> m_HasLossControlEffectsIcon /* None */,
    PPtr<GameObject> m_UnableToActNormaly /* None */,
    PPtr<LampSliderPrediction> m_BluePrediction /* None */,
    PPtr<TextMeshProUGUI> m_BlueLabel /* None */,
    PPtr<TextMeshProUGUI> m_BlueCostLabel /* None */,
    PPtr<LampSliderPrediction> m_YellowPrediction /* None */,
    PPtr<TextMeshProUGUI> m_YellowLabel /* None */,
    PPtr<TextMeshProUGUI> m_YellowCostLabel /* None */,
    PPtr<MoveAnimator> m_MoveAnimator /* None */,
    PPtr<Image> m_Frame /* None */,
    PPtr<Sprite> m_FriendFrame /* None */,
    PPtr<Sprite> m_EnemyFrame /* None */,
    PPtr<GameObject> m_Aquila /* None */)
{
    public static SurfaceCombatCurrentUnitView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Button */
        PPtr<OwlcatMultiButton> _Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<SurfaceCombatUnitPortraitZone> _m_CharacetrPortraitZone = PPtr<SurfaceCombatUnitPortraitZone>.Read(reader);
        PPtr<GameObject> _m_DifficultyBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DifficultyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<SurfaceCombatUnitPortraitZone> _m_NoPortraitZone = PPtr<SurfaceCombatUnitPortraitZone>.Read(reader);
        PPtr<UnitHealthPartTextPCView> _UnitHealthPartTextPCView = PPtr<UnitHealthPartTextPCView>.Read(reader);
        PPtr<UnitHealthPartProgressPCView> _UnitHealthPartProgressPCView = PPtr<UnitHealthPartProgressPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NameNormal = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<UnitBuffPartPCView> _UnitBuffPartPCView = PPtr<UnitBuffPartPCView>.Read(reader);
        byte _HasMarkers = reader.ReadU8();
        reader.AlignTo(4); /* m_WillLossTurn */
        PPtr<GameObject> _m_WillLossTurn = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_HasLossControlEffectsIcon = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UnableToActNormaly = PPtr<GameObject>.Read(reader);
        PPtr<LampSliderPrediction> _m_BluePrediction = PPtr<LampSliderPrediction>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BlueLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BlueCostLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LampSliderPrediction> _m_YellowPrediction = PPtr<LampSliderPrediction>.Read(reader);
        PPtr<TextMeshProUGUI> _m_YellowLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_YellowCostLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<MoveAnimator> _m_MoveAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<Image> _m_Frame = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_FriendFrame = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_EnemyFrame = PPtr<Sprite>.Read(reader);
        PPtr<GameObject> _m_Aquila = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Button,
            _m_CharacetrPortraitZone,
            _m_DifficultyBlock,
            _m_DifficultyText,
            _m_NoPortraitZone,
            _UnitHealthPartTextPCView,
            _UnitHealthPartProgressPCView,
            _m_NameNormal,
            _UnitBuffPartPCView,
            _HasMarkers,
            _m_WillLossTurn,
            _m_HasLossControlEffectsIcon,
            _m_UnableToActNormaly,
            _m_BluePrediction,
            _m_BlueLabel,
            _m_BlueCostLabel,
            _m_YellowPrediction,
            _m_YellowLabel,
            _m_YellowCostLabel,
            _m_MoveAnimator,
            _m_Frame,
            _m_FriendFrame,
            _m_EnemyFrame,
            _m_Aquila);
    }
}

