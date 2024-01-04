namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScriptZoneCylinder (8 fields) B4D720E192001E676C06FD02792200A2/811F1E671FB1EED54C83D3A5DE87D37A */
public record class ScriptZoneCylinder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f ScriptZoneCenter /* NeedsAlign */,
    int Height /* None */,
    int Radius /* None */,
    byte AlwaysShowPattern /* None */)
{
    public static ScriptZoneCylinder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ScriptZoneCenter */
        Vector3f _ScriptZoneCenter = Vector3f.Read(reader);
        int _Height = reader.ReadS32();
        int _Radius = reader.ReadS32();
        byte _AlwaysShowPattern = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ScriptZoneCenter,
            _Height,
            _Radius,
            _AlwaysShowPattern);
    }
}

