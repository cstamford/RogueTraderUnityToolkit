namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ProBuilderShape (12 fields) 2ABFF19ED2638C5AEF8BB5F980242CCB/A688F9C638E308553FF688397A4BCE8A */
public record class ProBuilderShape(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    managedReference m_Shape /* NeedsAlign */,
    Vector3f m_Size /* None */,
    Quaternionf m_Rotation /* None */,
    int m_PivotLocation /* None */,
    Vector3f m_PivotPosition /* None */,
    ushort m_UnmodifiedMeshVersion /* None */,
    AABB m_ShapeBox /* NeedsAlign */,
    RefRegistry references /* None */)
{
    public static ProBuilderShape Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Shape */
        managedReference _m_Shape = managedReference.Read(reader);
        Vector3f _m_Size = Vector3f.Read(reader);
        Quaternionf _m_Rotation = Quaternionf.Read(reader);
        int _m_PivotLocation = reader.ReadS32();
        Vector3f _m_PivotPosition = Vector3f.Read(reader);
        ushort _m_UnmodifiedMeshVersion = reader.ReadU16();
        reader.AlignTo(4); /* m_ShapeBox */
        AABB _m_ShapeBox = AABB.Read(reader);
        RefRegistry _references = default! /* RefRegistry_0 */;
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Shape,
            _m_Size,
            _m_Rotation,
            _m_PivotLocation,
            _m_PivotPosition,
            _m_UnmodifiedMeshVersion,
            _m_ShapeBox,
            _references);
    }
}

