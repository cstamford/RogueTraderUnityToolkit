namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Animation (8 fields) 6EACAB9E81FE6FC68388008E1BCC8F72 */
public record class Animation(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<AnimationClip> m_Animation,
    PPtr<AnimationClip>[] m_Animations,
    int m_WrapMode,
    bool m_PlayAutomatically,
    bool m_AnimatePhysics,
    int m_CullingType) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1856809886, 2180935622, 2206728334, 466390898);

    public static Animation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<AnimationClip> _m_Animation = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip>[] _m_Animations = BuiltInArray<PPtr<AnimationClip>>.Read(reader);
        reader.AlignTo(4); /* m_Animations */
        int _m_WrapMode = reader.ReadS32();
        bool _m_PlayAutomatically = reader.ReadBool();
        bool _m_AnimatePhysics = reader.ReadBool();
        reader.AlignTo(4); /* m_AnimatePhysics */
        int _m_CullingType = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Animation,
            _m_Animations,
            _m_WrapMode,
            _m_PlayAutomatically,
            _m_AnimatePhysics,
            _m_CullingType);
    }

    public override string ToString() => $"Animation\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Animation: ");
        sb.AppendLine(m_Animation.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Animations: ");
        sb.AppendLine(m_Animations.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WrapMode: ");
        sb.AppendLine(m_WrapMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlayAutomatically: ");
        sb.AppendLine(m_PlayAutomatically.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AnimatePhysics: ");
        sb.AppendLine(m_AnimatePhysics.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CullingType: ");
        sb.AppendLine(m_CullingType.ToString());

        return sb.ToString();
    }
}

