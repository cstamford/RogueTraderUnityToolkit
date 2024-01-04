namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimationClipWrapperStateMachineBehaviour (5 fields) C5FE21954962D312DD7917BC23EFDB66/2161D114EA01F11ADF342654F1EF923D */
public record class AnimationClipWrapperStateMachineBehaviour(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AnimationClipWrapper> AnimationClipWrapper /* NeedsAlign */)
{
    public static AnimationClipWrapperStateMachineBehaviour Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AnimationClipWrapper */
        PPtr<AnimationClipWrapper> _AnimationClipWrapper = PPtr<AnimationClipWrapper>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AnimationClipWrapper);
    }
}

