namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Character (25 fields) A326BBD81B2EF7A3BC3685A81C95C3F0/34DB3C00190688ABD2DF70A160D1F243 */
public record class Character(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Skeleton> m_Skeleton /* NeedsAlign */,
    PPtr<CharacterAtlasData> AtlasData /* None */,
    byte m_Mirror /* None */,
    PPtr<AnimationSet> m_AnimationSet /* NeedsAlign */,
    PPtr<Animator> AnimatorPrefab /* None */,
    byte IsDirty /* None */,
    byte IsAtlasesDirty /* NeedsAlign */,
    byte IsInDollRoom /* NeedsAlign */,
    byte IsCreatureAsCharacter /* NeedsAlign */,
    byte ForbidBeltItemVisualization /* NeedsAlign */,
    byte SaveRagdoll /* NeedsAlign */,
    int MaxAtlasSize /* NeedsAlign */,
    PPtr<BakedCharacter> BakedCharacter /* None */,
    PPtr<CharacterBonesList> m_BonesList /* None */,
    EquipmentEntityLink[] m_SavedEquipmentEntities /* None */,
    SavedSelectedRampIndices[] m_SavedRampIndices /* NeedsAlign */,
    EquipmentEntityLink EquipmentEntitiesForPreload /* NeedsAlign */,
    int m_DefaultRenderingLayer /* NeedsAlign */,
    uint CurrentLayer /* None */,
    byte canNotBeRebaked /* None */,
    PPtr<ClothCollider>[] ClothColliders /* NeedsAlign */)
{
    public static Character Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Skeleton */
        PPtr<Skeleton> _m_Skeleton = PPtr<Skeleton>.Read(reader);
        PPtr<CharacterAtlasData> _AtlasData = PPtr<CharacterAtlasData>.Read(reader);
        byte _m_Mirror = reader.ReadU8();
        reader.AlignTo(4); /* m_AnimationSet */
        PPtr<AnimationSet> _m_AnimationSet = PPtr<AnimationSet>.Read(reader);
        PPtr<Animator> _AnimatorPrefab = PPtr<Animator>.Read(reader);
        byte _IsDirty = reader.ReadU8();
        reader.AlignTo(4); /* IsAtlasesDirty */
        byte _IsAtlasesDirty = reader.ReadU8();
        reader.AlignTo(4); /* IsInDollRoom */
        byte _IsInDollRoom = reader.ReadU8();
        reader.AlignTo(4); /* IsCreatureAsCharacter */
        byte _IsCreatureAsCharacter = reader.ReadU8();
        reader.AlignTo(4); /* ForbidBeltItemVisualization */
        byte _ForbidBeltItemVisualization = reader.ReadU8();
        reader.AlignTo(4); /* SaveRagdoll */
        byte _SaveRagdoll = reader.ReadU8();
        reader.AlignTo(4); /* MaxAtlasSize */
        int _MaxAtlasSize = reader.ReadS32();
        PPtr<BakedCharacter> _BakedCharacter = PPtr<BakedCharacter>.Read(reader);
        PPtr<CharacterBonesList> _m_BonesList = PPtr<CharacterBonesList>.Read(reader);
        EquipmentEntityLink[] _m_SavedEquipmentEntities = BuiltInArray<EquipmentEntityLink>.Read(reader);
        reader.AlignTo(4); /* m_SavedRampIndices */
        SavedSelectedRampIndices[] _m_SavedRampIndices = BuiltInArray<SavedSelectedRampIndices>.Read(reader);
        reader.AlignTo(4); /* EquipmentEntitiesForPreload */
        EquipmentEntityLink _EquipmentEntitiesForPreload = EquipmentEntityLink.Read(reader);
        reader.AlignTo(4); /* m_DefaultRenderingLayer */
        int _m_DefaultRenderingLayer = reader.ReadS32();
        uint _CurrentLayer = reader.ReadU32();
        byte _canNotBeRebaked = reader.ReadU8();
        reader.AlignTo(4); /* ClothColliders */
        PPtr<ClothCollider>[] _ClothColliders = BuiltInArray<PPtr<ClothCollider>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Skeleton,
            _AtlasData,
            _m_Mirror,
            _m_AnimationSet,
            _AnimatorPrefab,
            _IsDirty,
            _IsAtlasesDirty,
            _IsInDollRoom,
            _IsCreatureAsCharacter,
            _ForbidBeltItemVisualization,
            _SaveRagdoll,
            _MaxAtlasSize,
            _BakedCharacter,
            _m_BonesList,
            _m_SavedEquipmentEntities,
            _m_SavedRampIndices,
            _EquipmentEntitiesForPreload,
            _m_DefaultRenderingLayer,
            _CurrentLayer,
            _canNotBeRebaked,
            _ClothColliders);
    }
}

