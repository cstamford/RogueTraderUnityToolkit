namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DetailsMesh (11 fields) DBF1F54EA78F03492C18EAA411F23197/858FB8C7DF692510C0578E04268EAA63 */
public record class DetailsMesh(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Mesh> m_Mesh /* NeedsAlign */,
    PPtr<Material>[] m_Materials /* None */,
    int m_RenderingLayerMask /* None */,
    PPtr<DetailsData> m_Data /* None */,
    Vector2f m_ScaleRange /* None */,
    Vector2f m_RotationRange /* None */,
    AsciiString m_Guid /* None */)
{
    public static DetailsMesh Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Mesh */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<Material>[] _m_Materials = BuiltInArray<PPtr<Material>>.Read(reader);
        int _m_RenderingLayerMask = reader.ReadS32();
        PPtr<DetailsData> _m_Data = PPtr<DetailsData>.Read(reader);
        Vector2f _m_ScaleRange = Vector2f.Read(reader);
        Vector2f _m_RotationRange = Vector2f.Read(reader);
        AsciiString _m_Guid = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Mesh,
            _m_Materials,
            _m_RenderingLayerMask,
            _m_Data,
            _m_ScaleRange,
            _m_RotationRange,
            _m_Guid);
    }
}

