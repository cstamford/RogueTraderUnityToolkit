namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipCombatTextBlockView (13 fields) 6D556FEA82870F9DBBB418DEC683E6AE/AB88DF903DB65DC068717DA22AAB21E8 */
public record class OvertipCombatTextBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA DefaultColor /* NeedsAlign */,
    PPtr<FadeAnimator> m_CombatTextContainerAnimator /* None */,
    CombatTextCommonCreator m_CombatTextCommonCreator /* None */,
    PPtr<RectTransform> m_ScaledRect /* None */,
    PPtr<RectTransform>[] m_PartRects /* None */,
    float m_BottomPadding /* None */,
    CombatTextHitPointsCreator m_CombatTextHitPointsCreator /* None */,
    BoolReactiveProperty HasActiveCombatText /* None */,
    float m_MoveTime /* NeedsAlign */)
{
    public static OvertipCombatTextBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DefaultColor */
        ColorRGBA _DefaultColor = ColorRGBA.Read(reader);
        PPtr<FadeAnimator> _m_CombatTextContainerAnimator = PPtr<FadeAnimator>.Read(reader);
        CombatTextCommonCreator _m_CombatTextCommonCreator = CombatTextCommonCreator.Read(reader);
        PPtr<RectTransform> _m_ScaledRect = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform>[] _m_PartRects = BuiltInArray<PPtr<RectTransform>>.Read(reader);
        float _m_BottomPadding = reader.ReadF32();
        CombatTextHitPointsCreator _m_CombatTextHitPointsCreator = CombatTextHitPointsCreator.Read(reader);
        BoolReactiveProperty _HasActiveCombatText = BoolReactiveProperty.Read(reader);
        reader.AlignTo(4); /* m_MoveTime */
        float _m_MoveTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DefaultColor,
            _m_CombatTextContainerAnimator,
            _m_CombatTextCommonCreator,
            _m_ScaledRect,
            _m_PartRects,
            _m_BottomPadding,
            _m_CombatTextHitPointsCreator,
            _HasActiveCombatText,
            _m_MoveTime);
    }
}

