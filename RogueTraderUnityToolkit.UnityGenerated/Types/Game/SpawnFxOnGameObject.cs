namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnFxOnGameObject (14 fields) D66FE16113A66E62D7F1C1B3108E609A/C96BE1D7F3469ABF1FFCE8108C623315 */
public record class SpawnFxOnGameObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> fxPrefab /* NeedsAlign */,
    PPtr<GameObject> targetGameObject /* None */,
    byte spawnOnStart /* None */,
    float spawnOnStartDelay /* NeedsAlign */,
    byte spawnRightNow /* None */,
    PPtr<GameObject> spawnedFx /* NeedsAlign */,
    byte SubmeshesInRenderers /* None */,
    byte IsPrefabInstance /* NeedsAlign */,
    byte IsUsedWithStaticPrefab /* NeedsAlign */,
    PPtr<Mesh>[] cutMeshes /* NeedsAlign */)
{
    public static SpawnFxOnGameObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* fxPrefab */
        PPtr<GameObject> _fxPrefab = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _targetGameObject = PPtr<GameObject>.Read(reader);
        byte _spawnOnStart = reader.ReadU8();
        reader.AlignTo(4); /* spawnOnStartDelay */
        float _spawnOnStartDelay = reader.ReadF32();
        byte _spawnRightNow = reader.ReadU8();
        reader.AlignTo(4); /* spawnedFx */
        PPtr<GameObject> _spawnedFx = PPtr<GameObject>.Read(reader);
        byte _SubmeshesInRenderers = reader.ReadU8();
        reader.AlignTo(4); /* IsPrefabInstance */
        byte _IsPrefabInstance = reader.ReadU8();
        reader.AlignTo(4); /* IsUsedWithStaticPrefab */
        byte _IsUsedWithStaticPrefab = reader.ReadU8();
        reader.AlignTo(4); /* cutMeshes */
        PPtr<Mesh>[] _cutMeshes = BuiltInArray<PPtr<Mesh>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _fxPrefab,
            _targetGameObject,
            _spawnOnStart,
            _spawnOnStartDelay,
            _spawnRightNow,
            _spawnedFx,
            _SubmeshesInRenderers,
            _IsPrefabInstance,
            _IsUsedWithStaticPrefab,
            _cutMeshes);
    }
}

