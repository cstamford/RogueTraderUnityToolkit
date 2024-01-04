namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ProBuilderMesh (23 fields) 8963322829D833239176E4611AAA1E57/D4501FD5AB0C88B92CAEE010660F7D49 */
public record class ProBuilderMesh(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_MeshFormatVersion /* NeedsAlign */,
    Face[] m_Faces /* None */,
    SharedVertex[] m_SharedVertices /* NeedsAlign */,
    SharedVertex m_SharedTextures /* NeedsAlign */,
    Vector3f[] m_Positions /* NeedsAlign */,
    Vector2f[] m_Textures0 /* NeedsAlign */,
    Vector4f[] m_Textures2 /* NeedsAlign */,
    Vector4f[] m_Textures3 /* NeedsAlign */,
    Vector4f[] m_Tangents /* NeedsAlign */,
    ColorRGBA[] m_Colors /* NeedsAlign */,
    UnwrapParameters m_UnwrapParameters /* NeedsAlign */,
    byte m_PreserveMeshAssetOnDestroy /* None */,
    AsciiString assetGuid /* NeedsAlign */,
    PPtr<Mesh> m_Mesh /* NeedsAlign */,
    ushort m_VersionIndex /* None */,
    byte m_IsSelectable /* NeedsAlign */,
    int[] m_SelectedFaces /* NeedsAlign */,
    Edge[] m_SelectedEdges /* NeedsAlign */,
    int[] m_SelectedVertices /* None */)
{
    public static ProBuilderMesh Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MeshFormatVersion */
        int _m_MeshFormatVersion = reader.ReadS32();
        Face[] _m_Faces = BuiltInArray<Face>.Read(reader);
        reader.AlignTo(4); /* m_SharedVertices */
        SharedVertex[] _m_SharedVertices = BuiltInArray<SharedVertex>.Read(reader);
        reader.AlignTo(4); /* m_SharedTextures */
        SharedVertex _m_SharedTextures = SharedVertex.Read(reader);
        reader.AlignTo(4); /* m_Positions */
        Vector3f[] _m_Positions = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_Textures0 */
        Vector2f[] _m_Textures0 = BuiltInArray<Vector2f>.Read(reader);
        reader.AlignTo(4); /* m_Textures2 */
        Vector4f[] _m_Textures2 = BuiltInArray<Vector4f>.Read(reader);
        reader.AlignTo(4); /* m_Textures3 */
        Vector4f[] _m_Textures3 = BuiltInArray<Vector4f>.Read(reader);
        reader.AlignTo(4); /* m_Tangents */
        Vector4f[] _m_Tangents = BuiltInArray<Vector4f>.Read(reader);
        reader.AlignTo(4); /* m_Colors */
        ColorRGBA[] _m_Colors = BuiltInArray<ColorRGBA>.Read(reader);
        reader.AlignTo(4); /* m_UnwrapParameters */
        UnwrapParameters _m_UnwrapParameters = UnwrapParameters.Read(reader);
        byte _m_PreserveMeshAssetOnDestroy = reader.ReadU8();
        reader.AlignTo(4); /* assetGuid */
        AsciiString _assetGuid = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Mesh */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        ushort _m_VersionIndex = reader.ReadU16();
        reader.AlignTo(4); /* m_IsSelectable */
        byte _m_IsSelectable = reader.ReadU8();
        reader.AlignTo(4); /* m_SelectedFaces */
        int[] _m_SelectedFaces = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_SelectedEdges */
        Edge[] _m_SelectedEdges = BuiltInArray<Edge>.Read(reader);
        int[] _m_SelectedVertices = BuiltInArray<int>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MeshFormatVersion,
            _m_Faces,
            _m_SharedVertices,
            _m_SharedTextures,
            _m_Positions,
            _m_Textures0,
            _m_Textures2,
            _m_Textures3,
            _m_Tangents,
            _m_Colors,
            _m_UnwrapParameters,
            _m_PreserveMeshAssetOnDestroy,
            _assetGuid,
            _m_Mesh,
            _m_VersionIndex,
            _m_IsSelectable,
            _m_SelectedFaces,
            _m_SelectedEdges,
            _m_SelectedVertices);
    }
}

