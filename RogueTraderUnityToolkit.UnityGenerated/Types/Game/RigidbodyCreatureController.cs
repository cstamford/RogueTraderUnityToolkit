namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RigidbodyCreatureController (29 fields) 12F3B06C18A2C497BD414448893D4C5E/BFC3F6875B70F967D9E6FB400C66C50E */
public record class RigidbodyCreatureController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte RagdollOnlyOnDeath /* NeedsAlign */,
    PPtr<GameObject> RootBone /* NeedsAlign */,
    BoneImpulseMultiplier[] BoneImpulseMultipliers /* None */,
    byte RandomNegativeValueOnMultiplier /* None */,
    float BaseImpulseValue /* NeedsAlign */,
    float AdditionalImpulseMin /* None */,
    float AdditionalImpulseMax /* None */,
    float MultiplyVectorYAxis /* None */,
    float InProneMultiplier /* None */,
    float ImpulseValueMultiplierToParents /* None */,
    float ImpulseValueMultiplierToChildren /* None */,
    byte ApplyImpulseToAllBones /* None */,
    PPtr<Rigidbody>[] RigidBones /* NeedsAlign */,
    float RagdollTime /* None */,
    byte CheckForEarlyStopRagdoll /* None */,
    float MinRootPosition /* NeedsAlign */,
    float MinAllPosition /* None */,
    float MinTimeToStop /* None */,
    PPtr<Transform>[] BonesToReturn /* None */,
    PPtr<AbstractUnitEntityView> EntityView /* None */,
    byte PostEventWithSurface /* None */,
    PPtr<RagdollPostEventWithSurface>[] EventTargets /* NeedsAlign */,
    float minRagdollValue /* None */,
    float maxRagdollValue /* None */,
    PPtr<GameObject>[] skeletonBones /* None */)
{
    public static RigidbodyCreatureController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* RagdollOnlyOnDeath */
        byte _RagdollOnlyOnDeath = reader.ReadU8();
        reader.AlignTo(4); /* RootBone */
        PPtr<GameObject> _RootBone = PPtr<GameObject>.Read(reader);
        BoneImpulseMultiplier[] _BoneImpulseMultipliers = BuiltInArray<BoneImpulseMultiplier>.Read(reader);
        byte _RandomNegativeValueOnMultiplier = reader.ReadU8();
        reader.AlignTo(4); /* BaseImpulseValue */
        float _BaseImpulseValue = reader.ReadF32();
        float _AdditionalImpulseMin = reader.ReadF32();
        float _AdditionalImpulseMax = reader.ReadF32();
        float _MultiplyVectorYAxis = reader.ReadF32();
        float _InProneMultiplier = reader.ReadF32();
        float _ImpulseValueMultiplierToParents = reader.ReadF32();
        float _ImpulseValueMultiplierToChildren = reader.ReadF32();
        byte _ApplyImpulseToAllBones = reader.ReadU8();
        reader.AlignTo(4); /* RigidBones */
        PPtr<Rigidbody>[] _RigidBones = BuiltInArray<PPtr<Rigidbody>>.Read(reader);
        float _RagdollTime = reader.ReadF32();
        byte _CheckForEarlyStopRagdoll = reader.ReadU8();
        reader.AlignTo(4); /* MinRootPosition */
        float _MinRootPosition = reader.ReadF32();
        float _MinAllPosition = reader.ReadF32();
        float _MinTimeToStop = reader.ReadF32();
        PPtr<Transform>[] _BonesToReturn = BuiltInArray<PPtr<Transform>>.Read(reader);
        PPtr<AbstractUnitEntityView> _EntityView = PPtr<AbstractUnitEntityView>.Read(reader);
        byte _PostEventWithSurface = reader.ReadU8();
        reader.AlignTo(4); /* EventTargets */
        PPtr<RagdollPostEventWithSurface>[] _EventTargets = BuiltInArray<PPtr<RagdollPostEventWithSurface>>.Read(reader);
        float _minRagdollValue = reader.ReadF32();
        float _maxRagdollValue = reader.ReadF32();
        PPtr<GameObject>[] _skeletonBones = BuiltInArray<PPtr<GameObject>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _RagdollOnlyOnDeath,
            _RootBone,
            _BoneImpulseMultipliers,
            _RandomNegativeValueOnMultiplier,
            _BaseImpulseValue,
            _AdditionalImpulseMin,
            _AdditionalImpulseMax,
            _MultiplyVectorYAxis,
            _InProneMultiplier,
            _ImpulseValueMultiplierToParents,
            _ImpulseValueMultiplierToChildren,
            _ApplyImpulseToAllBones,
            _RigidBones,
            _RagdollTime,
            _CheckForEarlyStopRagdoll,
            _MinRootPosition,
            _MinAllPosition,
            _MinTimeToStop,
            _BonesToReturn,
            _EntityView,
            _PostEventWithSurface,
            _EventTargets,
            _minRagdollValue,
            _maxRagdollValue,
            _skeletonBones);
    }
}

