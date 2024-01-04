namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EquipmentEntity (21 fields) 2674CCCA4607AA2B5F0A6E567EEB6EAA/78F069D3E6B0E8E682A7D1149C7B390E */
public record class EquipmentEntity(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte IsExportEnabled /* NeedsAlign */,
    byte CantBeHiddenByDollRoom /* NeedsAlign */,
    int Layer /* NeedsAlign */,
    long m_HideBodyParts /* None */,
    byte ShowLowerMaterials /* None */,
    Bone[] SkeletonModifiers /* NeedsAlign */,
    PPtr<CharacterColorsProfile> PrimaryColorsProfile /* NeedsAlign */,
    PPtr<CharacterColorsProfile> SecondaryColorsProfile /* None */,
    PPtr<CharacterBakedTextures> BakedTextures /* None */,
    PPtr<Texture2D> PreviewTexture /* None */,
    PPtr<RampColorPreset> ColorPresets /* None */,
    PPtr<Texture2D>[] m_PrimaryRamps /* None */,
    PPtr<Texture2D>[] m_SecondaryRamps /* None */,
    BodyPart[] BodyParts /* None */,
    OutfitPart[] OutfitParts /* NeedsAlign */,
    int ForcedPrimaryIndex /* NeedsAlign */,
    int ForcedSecondaryIndex /* None */)
{
    public static EquipmentEntity Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* IsExportEnabled */
        byte _IsExportEnabled = reader.ReadU8();
        reader.AlignTo(4); /* CantBeHiddenByDollRoom */
        byte _CantBeHiddenByDollRoom = reader.ReadU8();
        reader.AlignTo(4); /* Layer */
        int _Layer = reader.ReadS32();
        long _m_HideBodyParts = reader.ReadS64();
        byte _ShowLowerMaterials = reader.ReadU8();
        reader.AlignTo(4); /* SkeletonModifiers */
        Bone[] _SkeletonModifiers = BuiltInArray<Bone>.Read(reader);
        reader.AlignTo(4); /* PrimaryColorsProfile */
        PPtr<CharacterColorsProfile> _PrimaryColorsProfile = PPtr<CharacterColorsProfile>.Read(reader);
        PPtr<CharacterColorsProfile> _SecondaryColorsProfile = PPtr<CharacterColorsProfile>.Read(reader);
        PPtr<CharacterBakedTextures> _BakedTextures = PPtr<CharacterBakedTextures>.Read(reader);
        PPtr<Texture2D> _PreviewTexture = PPtr<Texture2D>.Read(reader);
        PPtr<RampColorPreset> _ColorPresets = PPtr<RampColorPreset>.Read(reader);
        PPtr<Texture2D>[] _m_PrimaryRamps = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        PPtr<Texture2D>[] _m_SecondaryRamps = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        BodyPart[] _BodyParts = BuiltInArray<BodyPart>.Read(reader);
        reader.AlignTo(4); /* OutfitParts */
        OutfitPart[] _OutfitParts = BuiltInArray<OutfitPart>.Read(reader);
        reader.AlignTo(4); /* ForcedPrimaryIndex */
        int _ForcedPrimaryIndex = reader.ReadS32();
        int _ForcedSecondaryIndex = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _IsExportEnabled,
            _CantBeHiddenByDollRoom,
            _Layer,
            _m_HideBodyParts,
            _ShowLowerMaterials,
            _SkeletonModifiers,
            _PrimaryColorsProfile,
            _SecondaryColorsProfile,
            _BakedTextures,
            _PreviewTexture,
            _ColorPresets,
            _m_PrimaryRamps,
            _m_SecondaryRamps,
            _BodyParts,
            _OutfitParts,
            _ForcedPrimaryIndex,
            _ForcedSecondaryIndex);
    }
}

