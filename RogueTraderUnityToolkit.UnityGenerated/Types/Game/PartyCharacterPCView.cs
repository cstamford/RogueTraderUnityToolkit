namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PartyCharacterPCView (19 fields) 30353A48F9F80FA4152175DBBD6C7136/C7F7D250A7E1910238388C7911E9B9A4 */
public record class PartyCharacterPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UnitHealthPartProgressPCView> m_HealthProgressView /* NeedsAlign */,
    PPtr<UnitHealthPartTextPCView> m_HealthTextView /* None */,
    PPtr<UnitPortraitPartPCView> m_PortraitView /* None */,
    PPtr<UnitBuffPartPCView> m_BuffView /* None */,
    PPtr<UnitBarkPartView> m_BarkBlockView /* None */,
    PPtr<MoveAnimator> m_SelectorMoveAnimator /* None */,
    PPtr<OwlcatMultiButton> m_LevelUpButton /* None */,
    PPtr<OwlcatMultiButton> m_CharacterButton /* None */,
    PPtr<Image> m_NetLock /* None */,
    PPtr<GameObject> m_EncumbranceIndicator /* None */,
    ColorRGBA m_EncumbranceHeavyLoad /* None */,
    ColorRGBA m_EncumbranceOverload /* None */,
    PPtr<Image> m_PersonalEncumbranceIcon /* None */,
    PPtr<GameObject> m_PersonalEncumbranceObject /* None */,
    float BasePositionX /* None */)
{
    public static PartyCharacterPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HealthProgressView */
        PPtr<UnitHealthPartProgressPCView> _m_HealthProgressView = PPtr<UnitHealthPartProgressPCView>.Read(reader);
        PPtr<UnitHealthPartTextPCView> _m_HealthTextView = PPtr<UnitHealthPartTextPCView>.Read(reader);
        PPtr<UnitPortraitPartPCView> _m_PortraitView = PPtr<UnitPortraitPartPCView>.Read(reader);
        PPtr<UnitBuffPartPCView> _m_BuffView = PPtr<UnitBuffPartPCView>.Read(reader);
        PPtr<UnitBarkPartView> _m_BarkBlockView = PPtr<UnitBarkPartView>.Read(reader);
        PPtr<MoveAnimator> _m_SelectorMoveAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<OwlcatMultiButton> _m_LevelUpButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CharacterButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_NetLock = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_EncumbranceIndicator = PPtr<GameObject>.Read(reader);
        ColorRGBA _m_EncumbranceHeavyLoad = ColorRGBA.Read(reader);
        ColorRGBA _m_EncumbranceOverload = ColorRGBA.Read(reader);
        PPtr<Image> _m_PersonalEncumbranceIcon = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_PersonalEncumbranceObject = PPtr<GameObject>.Read(reader);
        float _BasePositionX = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HealthProgressView,
            _m_HealthTextView,
            _m_PortraitView,
            _m_BuffView,
            _m_BarkBlockView,
            _m_SelectorMoveAnimator,
            _m_LevelUpButton,
            _m_CharacterButton,
            _m_NetLock,
            _m_EncumbranceIndicator,
            _m_EncumbranceHeavyLoad,
            _m_EncumbranceOverload,
            _m_PersonalEncumbranceIcon,
            _m_PersonalEncumbranceObject,
            _BasePositionX);
    }
}

