namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SoundSurfaceObject (6 fields) 2614E4CD1C7C5CE0FDEEB9302C46B1AC/CA8A850B4F189F84E6A09D49627A5904 */
public record class SoundSurfaceObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int Switch /* NeedsAlign */,
    byte UseAllColliders /* None */)
{
    public static SoundSurfaceObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Switch */
        int _Switch = reader.ReadS32();
        byte _UseAllColliders = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Switch,
            _UseAllColliders);
    }
}

