namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AwarenessCheckComponent (6 fields) 89D427972B89C4E6524C2E0E012DC6FB/CA8942D434DBC0C7D393E04D45207D9C */
public record class AwarenessCheckComponent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int DC /* NeedsAlign */,
    float Radius /* None */)
{
    public static AwarenessCheckComponent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DC */
        int _DC = reader.ReadS32();
        float _Radius = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DC,
            _Radius);
    }
}

