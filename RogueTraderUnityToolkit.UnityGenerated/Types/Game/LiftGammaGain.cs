namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LiftGammaGain (8 fields) 2F5BC32C48BF69E15CA74DB6251338F9/F398CCE625533D90FAE3475296C6F08D */
public record class LiftGammaGain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    Vector4Parameter lift /* NeedsAlign */,
    Vector4Parameter gamma /* NeedsAlign */,
    Vector4Parameter gain /* NeedsAlign */)
{
    public static LiftGammaGain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* lift */
        Vector4Parameter _lift = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* gamma */
        Vector4Parameter _gamma = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* gain */
        Vector4Parameter _gain = Vector4Parameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _lift,
            _gamma,
            _gain);
    }
}

