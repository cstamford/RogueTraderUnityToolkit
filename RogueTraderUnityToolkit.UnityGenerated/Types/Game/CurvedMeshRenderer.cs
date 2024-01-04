namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CurvedMeshRenderer (6 fields) 2342CFD39B01CE060E0BA13BAD43FBF5/8C62DD3AD4D13C96AED57DC4C44767C9 */
public record class CurvedMeshRenderer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<MeshFilter> m_MeshFilter /* NeedsAlign */,
    PPtr<MeshRenderer> m_MeshRenderer /* None */)
{
    public static CurvedMeshRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MeshFilter */
        PPtr<MeshFilter> _m_MeshFilter = PPtr<MeshFilter>.Read(reader);
        PPtr<MeshRenderer> _m_MeshRenderer = PPtr<MeshRenderer>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MeshFilter,
            _m_MeshRenderer);
    }
}

