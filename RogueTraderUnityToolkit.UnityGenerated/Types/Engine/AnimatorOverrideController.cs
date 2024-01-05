namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AnimatorOverrideController (3 fields) 1DAD7181B9D85FFC4DD49722B3175F4C */
public record class AnimatorOverrideController(
    AsciiString m_Name,
    PPtr<RuntimeAnimatorController> m_Controller,
    AnimationClipOverride[] m_Clips) : IUnityEngineStructure
{
    public static Hash128 Hash => new(497906049, 3117965308, 1305777954, 3004653388);

    public static AnimatorOverrideController Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<RuntimeAnimatorController> _m_Controller = PPtr<RuntimeAnimatorController>.Read(reader);
        AnimationClipOverride[] _m_Clips = BuiltInArray<AnimationClipOverride>.Read(reader);
        reader.AlignTo(4); /* m_Clips */
        
        return new(_m_Name,
            _m_Controller,
            _m_Clips);
    }

    public override string ToString() => $"AnimatorOverrideController\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Controller: ");
        sb.AppendLine(m_Controller.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Clips: ");
        sb.AppendLine(m_Clips.ToString());

        return sb.ToString();
    }
}

