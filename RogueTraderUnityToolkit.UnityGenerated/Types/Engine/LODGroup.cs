namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LODGroup (8 fields) 222071680371689287B490B6347897EB */
public record class LODGroup(
    PPtr<GameObject> m_GameObject,
    Vector3f m_LocalReferencePoint,
    float m_Size,
    int m_FadeMode,
    bool m_AnimateCrossFading,
    bool m_LastLODIsBillboard,
    LOD[] m_LODs,
    bool m_Enabled) : IUnityEngineStructure
{
    public static Hash128 Hash => new(572551528, 57763986, 2276757686, 880318443);

    public static LODGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        Vector3f _m_LocalReferencePoint = Vector3f.Read(reader);
        float _m_Size = reader.ReadF32();
        int _m_FadeMode = reader.ReadS32();
        bool _m_AnimateCrossFading = reader.ReadBool();
        bool _m_LastLODIsBillboard = reader.ReadBool();
        reader.AlignTo(4); /* m_LastLODIsBillboard */
        LOD[] _m_LODs = BuiltInArray<LOD>.Read(reader);
        reader.AlignTo(4); /* m_LODs */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        
        return new(_m_GameObject,
            _m_LocalReferencePoint,
            _m_Size,
            _m_FadeMode,
            _m_AnimateCrossFading,
            _m_LastLODIsBillboard,
            _m_LODs,
            _m_Enabled);
    }

    public override string ToString() => $"LODGroup\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LocalReferencePoint: ");
        sb.AppendLine();
        sb.Append(m_LocalReferencePoint.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Size: ");
        sb.AppendLine(m_Size.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FadeMode: ");
        sb.AppendLine(m_FadeMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnimateCrossFading: ");
        sb.AppendLine(m_AnimateCrossFading.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LastLODIsBillboard: ");
        sb.AppendLine(m_LastLODIsBillboard.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LODs: ");
        sb.AppendLine(m_LODs.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        return sb.ToString();
    }
}

