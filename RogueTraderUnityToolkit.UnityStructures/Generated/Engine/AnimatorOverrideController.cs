namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $AnimatorOverrideController (3 fields) (IsEngineType) */
public record class AnimatorOverrideController(
    AsciiString m_Name,
    PPtr<RuntimeAnimatorController> m_Controller,
    AnimationClipOverride[] m_Clips)
{
    public static AnimatorOverrideController Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        PPtr<RuntimeAnimatorController> m_Controller = PPtr<RuntimeAnimatorController>.Read(reader);
        AnimationClipOverride[] m_Clips = Array<AnimationClipOverride>.Read(reader);
        
        return new(m_Name,
            m_Controller,
            m_Clips);
    }
}

