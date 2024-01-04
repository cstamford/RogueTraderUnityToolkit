namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SkinnedMeshRenderersCombiner (22 fields) 4432C494A81A044477A7A9B41D53F0E4/E0AE6D72148DCC59E6B49454479F777D */
public record class SkinnedMeshRenderersCombiner(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SkinnedMeshRenderer> SmrPrefab /* NeedsAlign */,
    PPtr<SkinnedMeshRenderer>[] SMRList /* None */,
    PPtr<SkinnedMeshRenderer>[] SMRListHidden /* None */,
    BoneWeight[] boneWeights /* None */,
    Matrix4x4f[] bindPoses /* None */,
    Vector2f[] uv /* NeedsAlign */,
    Vector3f[] verticies /* NeedsAlign */,
    int[] triangles /* NeedsAlign */,
    PPtr<Material>[] allMaterials /* NeedsAlign */,
    byte m_useMatrices /* None */,
    int atlasWidth /* NeedsAlign */,
    int atlasHeight /* None */,
    PPtr<Texture2D> AtlasTex /* None */,
    PPtr<Texture2D> AtlasTexMask /* None */,
    PPtr<Texture2D> AtlasTexNormal /* None */,
    Rectf[] Rects /* None */,
    PPtr<Material> AtlasMaterial /* NeedsAlign */,
    PPtr<SkinnedMeshRenderer>[] SMRListFixedUV /* None */)
{
    public static SkinnedMeshRenderersCombiner Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SmrPrefab */
        PPtr<SkinnedMeshRenderer> _SmrPrefab = PPtr<SkinnedMeshRenderer>.Read(reader);
        PPtr<SkinnedMeshRenderer>[] _SMRList = BuiltInArray<PPtr<SkinnedMeshRenderer>>.Read(reader);
        PPtr<SkinnedMeshRenderer>[] _SMRListHidden = BuiltInArray<PPtr<SkinnedMeshRenderer>>.Read(reader);
        BoneWeight[] _boneWeights = BuiltInArray<BoneWeight>.Read(reader);
        Matrix4x4f[] _bindPoses = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* uv */
        Vector2f[] _uv = BuiltInArray<Vector2f>.Read(reader);
        reader.AlignTo(4); /* verticies */
        Vector3f[] _verticies = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* triangles */
        int[] _triangles = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* allMaterials */
        PPtr<Material>[] _allMaterials = BuiltInArray<PPtr<Material>>.Read(reader);
        byte _m_useMatrices = reader.ReadU8();
        reader.AlignTo(4); /* atlasWidth */
        int _atlasWidth = reader.ReadS32();
        int _atlasHeight = reader.ReadS32();
        PPtr<Texture2D> _AtlasTex = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _AtlasTexMask = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _AtlasTexNormal = PPtr<Texture2D>.Read(reader);
        Rectf[] _Rects = BuiltInArray<Rectf>.Read(reader);
        reader.AlignTo(4); /* AtlasMaterial */
        PPtr<Material> _AtlasMaterial = PPtr<Material>.Read(reader);
        PPtr<SkinnedMeshRenderer>[] _SMRListFixedUV = BuiltInArray<PPtr<SkinnedMeshRenderer>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SmrPrefab,
            _SMRList,
            _SMRListHidden,
            _boneWeights,
            _bindPoses,
            _uv,
            _verticies,
            _triangles,
            _allMaterials,
            _m_useMatrices,
            _atlasWidth,
            _atlasHeight,
            _AtlasTex,
            _AtlasTexMask,
            _AtlasTexNormal,
            _Rects,
            _AtlasMaterial,
            _SMRListFixedUV);
    }
}

