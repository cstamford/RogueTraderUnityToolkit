namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceTypeObject (9 fields) 64C246CEE76468028DE0FE3AB1E45811/8E85E8B0DD399F2995E9BF299CE624FB */
public record class SurfaceTypeObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte[] m_Data /* NeedsAlign */,
    PPtr<TextAsset> m_SoundCacheFile /* NeedsAlign */,
    SceneReference[] m_AdditionalAllowedScenes /* None */,
    AABB Bounds /* NeedsAlign */,
    float m_RaycastThickness /* None */)
{
    public static SurfaceTypeObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Data */
        byte[] _m_Data = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_SoundCacheFile */
        PPtr<TextAsset> _m_SoundCacheFile = PPtr<TextAsset>.Read(reader);
        SceneReference[] _m_AdditionalAllowedScenes = BuiltInArray<SceneReference>.Read(reader);
        reader.AlignTo(4); /* Bounds */
        AABB _Bounds = AABB.Read(reader);
        float _m_RaycastThickness = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Data,
            _m_SoundCacheFile,
            _m_AdditionalAllowedScenes,
            _Bounds,
            _m_RaycastThickness);
    }
}

