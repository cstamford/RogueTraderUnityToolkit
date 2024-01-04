namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $AnimatorOverrideController (3 fields) 1DAD7181B9D85FFC4DD49722B3175F4C */
public record class AnimatorOverrideController(
    AsciiString m_Name /* None */,
    PPtr<RuntimeAnimatorController> m_Controller /* NeedsAlign */,
    AnimationClipOverride[] m_Clips /* None */) : IUnityObject
{
    public static Hash128 Hash => new(497906049, 3117965308, 1305777954, 3004653388);
    public static AnimatorOverrideController Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Controller */
        PPtr<RuntimeAnimatorController> _m_Controller = PPtr<RuntimeAnimatorController>.Read(reader);
        AnimationClipOverride[] _m_Clips = BuiltInArray<AnimationClipOverride>.Read(reader);
        
        return new(_m_Name,
            _m_Controller,
            _m_Clips);
    }
}

