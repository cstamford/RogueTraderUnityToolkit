namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $PlayableDirector (9 fields) D200DB4E6F5FC6A9C3CDF5258063B81B */
public record class PlayableDirector(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<Object> m_PlayableAsset /* NeedsAlign */,
    int m_InitialState /* None */,
    int m_WrapMode /* None */,
    int m_DirectorUpdateMode /* None */,
    double m_InitialTime /* None */,
    DirectorGenericBinding[] m_SceneBindings /* None */,
    ExposedReferenceTable m_ExposedReferences /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3523271502, 1868547753, 3285054757, 2154018843);
    public static PlayableDirector Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_PlayableAsset */
        PPtr<Object> _m_PlayableAsset = PPtr<Object>.Read(reader);
        int _m_InitialState = reader.ReadS32();
        int _m_WrapMode = reader.ReadS32();
        int _m_DirectorUpdateMode = reader.ReadS32();
        double _m_InitialTime = reader.ReadF64();
        DirectorGenericBinding[] _m_SceneBindings = BuiltInArray<DirectorGenericBinding>.Read(reader);
        reader.AlignTo(4); /* m_ExposedReferences */
        ExposedReferenceTable _m_ExposedReferences = ExposedReferenceTable.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_PlayableAsset,
            _m_InitialState,
            _m_WrapMode,
            _m_DirectorUpdateMode,
            _m_InitialTime,
            _m_SceneBindings,
            _m_ExposedReferences);
    }
}

