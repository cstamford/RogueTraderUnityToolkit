namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitEntityView (22 fields) 4814C56C3B42C6261A3295EAAE9A231A/4111081FC70FEA54BF36C62BB832C054 */
public record class UnitEntityView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    float m_SoftColliderHeight /* NeedsAlign */,
    PPtr<CapsuleCollider> m_SoftCollider /* None */,
    PPtr<MeshCollider> m_CoreCollider /* None */,
    PPtr<SoftColliderPlaceholder> SoftColliderPlaceholder /* None */,
    byte ForbidRotation /* None */,
    PPtr<GameObject> OverrideRotatablePart /* NeedsAlign */,
    PPtr<GameObject>[] Footprints /* None */,
    PPtr<RigidbodyCreatureController> RigidbodyController /* None */,
    byte m_KeepCollidersSetupAsIs /* None */,
    byte m_HorizontalCollider /* NeedsAlign */,
    float m_SoftColliderRadius /* NeedsAlign */,
    int m_Corpulence /* None */,
    UnitAnimationSettings m_AnimationSettings /* None */,
    byte m_IgnoreRaceAnimationSettings /* NeedsAlign */,
    PPtr<GameObject> m_BuiltinArmorMediumView /* NeedsAlign */,
    PPtr<GameObject> m_BuiltinArmorHeavyView /* None */)
{
    public static UnitEntityView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SoftColliderHeight */
        float _m_SoftColliderHeight = reader.ReadF32();
        PPtr<CapsuleCollider> _m_SoftCollider = PPtr<CapsuleCollider>.Read(reader);
        PPtr<MeshCollider> _m_CoreCollider = PPtr<MeshCollider>.Read(reader);
        PPtr<SoftColliderPlaceholder> _SoftColliderPlaceholder = PPtr<SoftColliderPlaceholder>.Read(reader);
        byte _ForbidRotation = reader.ReadU8();
        reader.AlignTo(4); /* OverrideRotatablePart */
        PPtr<GameObject> _OverrideRotatablePart = PPtr<GameObject>.Read(reader);
        PPtr<GameObject>[] _Footprints = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<RigidbodyCreatureController> _RigidbodyController = PPtr<RigidbodyCreatureController>.Read(reader);
        byte _m_KeepCollidersSetupAsIs = reader.ReadU8();
        reader.AlignTo(4); /* m_HorizontalCollider */
        byte _m_HorizontalCollider = reader.ReadU8();
        reader.AlignTo(4); /* m_SoftColliderRadius */
        float _m_SoftColliderRadius = reader.ReadF32();
        int _m_Corpulence = reader.ReadS32();
        UnitAnimationSettings _m_AnimationSettings = UnitAnimationSettings.Read(reader);
        reader.AlignTo(4); /* m_IgnoreRaceAnimationSettings */
        byte _m_IgnoreRaceAnimationSettings = reader.ReadU8();
        reader.AlignTo(4); /* m_BuiltinArmorMediumView */
        PPtr<GameObject> _m_BuiltinArmorMediumView = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_BuiltinArmorHeavyView = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_SoftColliderHeight,
            _m_SoftCollider,
            _m_CoreCollider,
            _SoftColliderPlaceholder,
            _ForbidRotation,
            _OverrideRotatablePart,
            _Footprints,
            _RigidbodyController,
            _m_KeepCollidersSetupAsIs,
            _m_HorizontalCollider,
            _m_SoftColliderRadius,
            _m_Corpulence,
            _m_AnimationSettings,
            _m_IgnoreRaceAnimationSettings,
            _m_BuiltinArmorMediumView,
            _m_BuiltinArmorHeavyView);
    }
}

