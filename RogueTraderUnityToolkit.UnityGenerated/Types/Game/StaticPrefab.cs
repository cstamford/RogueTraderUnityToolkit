namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StaticPrefab (8 fields) 964F5441C6DF635ECCB21502F730DA74/B25B247CDA2B1E8144C4DB6DAEC313EC */
public record class StaticPrefab(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> LightsRoot /* NeedsAlign */,
    PPtr<GameObject> VisualRoot /* None */,
    PPtr<ShadowProxy>[] ShadowProxies /* None */,
    PPtr<SurfaceHitObject>[] SurfaceHitObjects /* None */)
{
    public static StaticPrefab Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LightsRoot */
        PPtr<GameObject> _LightsRoot = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _VisualRoot = PPtr<GameObject>.Read(reader);
        PPtr<ShadowProxy>[] _ShadowProxies = BuiltInArray<PPtr<ShadowProxy>>.Read(reader);
        PPtr<SurfaceHitObject>[] _SurfaceHitObjects = BuiltInArray<PPtr<SurfaceHitObject>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _LightsRoot,
            _VisualRoot,
            _ShadowProxies,
            _SurfaceHitObjects);
    }
}

