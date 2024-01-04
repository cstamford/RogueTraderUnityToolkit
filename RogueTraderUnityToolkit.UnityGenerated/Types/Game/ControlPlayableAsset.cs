namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ControlPlayableAsset (13 fields) 5D83DB98499D65D05167ED0D89423502/C5C341A14688D9E7C4DB5225FF357C31 */
public record class ControlPlayableAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ExposedReference_1 sourceGameObject /* NeedsAlign */,
    PPtr<GameObject> prefabGameObject /* NeedsAlign */,
    byte updateParticle /* None */,
    uint particleRandomSeed /* NeedsAlign */,
    byte updateDirector /* None */,
    byte updateITimeControl /* NeedsAlign */,
    byte searchHierarchy /* NeedsAlign */,
    byte active /* NeedsAlign */,
    int postPlayback /* NeedsAlign */)
{
    public static ControlPlayableAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* sourceGameObject */
        ExposedReference_1 _sourceGameObject = ExposedReference_1.Read(reader);
        reader.AlignTo(4); /* prefabGameObject */
        PPtr<GameObject> _prefabGameObject = PPtr<GameObject>.Read(reader);
        byte _updateParticle = reader.ReadU8();
        reader.AlignTo(4); /* particleRandomSeed */
        uint _particleRandomSeed = reader.ReadU32();
        byte _updateDirector = reader.ReadU8();
        reader.AlignTo(4); /* updateITimeControl */
        byte _updateITimeControl = reader.ReadU8();
        reader.AlignTo(4); /* searchHierarchy */
        byte _searchHierarchy = reader.ReadU8();
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* postPlayback */
        int _postPlayback = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _sourceGameObject,
            _prefabGameObject,
            _updateParticle,
            _particleRandomSeed,
            _updateDirector,
            _updateITimeControl,
            _searchHierarchy,
            _active,
            _postPlayback);
    }
}

