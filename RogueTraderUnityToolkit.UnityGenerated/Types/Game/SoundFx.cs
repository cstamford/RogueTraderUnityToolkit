namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SoundFx (8 fields) A4D1E7221D39DEFED74E17F3AAD51CB8/82E146F26EC4369A579F4E10709467F0 */
public record class SoundFx(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte BlockSoundFXPlaying /* NeedsAlign */,
    SoundFXSettings EventsOnStart /* NeedsAlign */,
    SoundFXSettings EventsOnDestroy /* NeedsAlign */,
    PPtr<SoundFx> Prefab /* NeedsAlign */)
{
    public static SoundFx Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BlockSoundFXPlaying */
        byte _BlockSoundFXPlaying = reader.ReadU8();
        reader.AlignTo(4); /* EventsOnStart */
        SoundFXSettings _EventsOnStart = SoundFXSettings.Read(reader);
        reader.AlignTo(4); /* EventsOnDestroy */
        SoundFXSettings _EventsOnDestroy = SoundFXSettings.Read(reader);
        reader.AlignTo(4); /* Prefab */
        PPtr<SoundFx> _Prefab = PPtr<SoundFx>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BlockSoundFXPlaying,
            _EventsOnStart,
            _EventsOnDestroy,
            _Prefab);
    }
}

