namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GridLayoutGroupWorkaround (13 fields) D8C1DAB143A18669A176BD6D86C6B60A/87C2A25654DC626B26CEA8EFB9882972 */
public record class GridLayoutGroupWorkaround(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    RectOffset m_Padding /* NeedsAlign */,
    int m_ChildAlignment /* None */,
    int m_StartCorner /* None */,
    int m_StartAxis /* None */,
    Vector2f m_CellSize /* None */,
    Vector2f m_Spacing /* None */,
    int m_Constraint /* None */,
    int m_ConstraintCount /* None */,
    byte DoWorkaround /* None */)
{
    public static GridLayoutGroupWorkaround Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Padding */
        RectOffset _m_Padding = RectOffset.Read(reader);
        int _m_ChildAlignment = reader.ReadS32();
        int _m_StartCorner = reader.ReadS32();
        int _m_StartAxis = reader.ReadS32();
        Vector2f _m_CellSize = Vector2f.Read(reader);
        Vector2f _m_Spacing = Vector2f.Read(reader);
        int _m_Constraint = reader.ReadS32();
        int _m_ConstraintCount = reader.ReadS32();
        byte _DoWorkaround = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Padding,
            _m_ChildAlignment,
            _m_StartCorner,
            _m_StartAxis,
            _m_CellSize,
            _m_Spacing,
            _m_Constraint,
            _m_ConstraintCount,
            _DoWorkaround);
    }
}

