namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AudioTriggerableEvent (12 fields) C5F01F38371BBEBD5272835077DBAD17/B71A479CC1616CEBC80A751C5B75AF72 */
public record class AudioTriggerableEvent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_LogTriggers /* NeedsAlign */,
    int m_Triggers /* NeedsAlign */,
    byte m_TriggerOnce /* None */,
    AkEventReference m_Event /* NeedsAlign */,
    byte m_ActionMode /* NeedsAlign */,
    int m_Action /* NeedsAlign */,
    float m_TransitionDuration /* None */,
    int m_CurveInterpolation /* None */)
{
    public static AudioTriggerableEvent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LogTriggers */
        byte _m_LogTriggers = reader.ReadU8();
        reader.AlignTo(4); /* m_Triggers */
        int _m_Triggers = reader.ReadS32();
        byte _m_TriggerOnce = reader.ReadU8();
        reader.AlignTo(4); /* m_Event */
        AkEventReference _m_Event = AkEventReference.Read(reader);
        reader.AlignTo(4); /* m_ActionMode */
        byte _m_ActionMode = reader.ReadU8();
        reader.AlignTo(4); /* m_Action */
        int _m_Action = reader.ReadS32();
        float _m_TransitionDuration = reader.ReadF32();
        int _m_CurveInterpolation = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LogTriggers,
            _m_Triggers,
            _m_TriggerOnce,
            _m_Event,
            _m_ActionMode,
            _m_Action,
            _m_TransitionDuration,
            _m_CurveInterpolation);
    }
}

