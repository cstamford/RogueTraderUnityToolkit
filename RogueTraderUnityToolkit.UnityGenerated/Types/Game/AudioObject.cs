namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AudioObject (7 fields) B2856B946A27EA1100BE17619BEF7553/8772E62FCEBDC217E61EA7FC5396E919 */
public record class AudioObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_ShouldUpdatePosition /* NeedsAlign */,
    byte m_ShouldUpdateZones /* NeedsAlign */,
    byte m_LogEverything /* NeedsAlign */)
{
    public static AudioObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShouldUpdatePosition */
        byte _m_ShouldUpdatePosition = reader.ReadU8();
        reader.AlignTo(4); /* m_ShouldUpdateZones */
        byte _m_ShouldUpdateZones = reader.ReadU8();
        reader.AlignTo(4); /* m_LogEverything */
        byte _m_LogEverything = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShouldUpdatePosition,
            _m_ShouldUpdateZones,
            _m_LogEverything);
    }
}

