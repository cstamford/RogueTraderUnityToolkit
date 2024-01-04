namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceHitObject (6 fields) 95D70A28FF549C8028FBBEE03250F02D/7E856FCC6F5D0AF47BDD39D8DAF508EA */
public record class SurfaceHitObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _SoundSurfaceType /* NeedsAlign */,
    PPtr<Collider>[] _Colliders /* None */)
{
    public static SurfaceHitObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _SoundSurfaceType */
        int __SoundSurfaceType = reader.ReadS32();
        PPtr<Collider>[] __Colliders = BuiltInArray<PPtr<Collider>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __SoundSurfaceType,
            __Colliders);
    }
}

