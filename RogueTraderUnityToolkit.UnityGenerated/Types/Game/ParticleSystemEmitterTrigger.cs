namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ParticleSystemEmitterTrigger (6 fields) A265AA5584CDBDDE476576C365FAE3C8/BC055FEAE5ADA80E376962003181CEEF */
public record class ParticleSystemEmitterTrigger(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ActionsReference m_OnEmitActions /* NeedsAlign */,
    AsciiString m_EventOnEmit /* NeedsAlign */)
{
    public static ParticleSystemEmitterTrigger Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OnEmitActions */
        ActionsReference _m_OnEmitActions = ActionsReference.Read(reader);
        reader.AlignTo(4); /* m_EventOnEmit */
        AsciiString _m_EventOnEmit = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_OnEmitActions,
            _m_EventOnEmit);
    }
}

