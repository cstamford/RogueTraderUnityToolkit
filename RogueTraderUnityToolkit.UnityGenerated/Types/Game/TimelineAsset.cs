namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TimelineAsset (10 fields) 13758EBF835EA1A697B6346CD7CCF2FC/304BBD7F027B18AC31DB8FE6E4C85C68 */
public record class TimelineAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_Version /* NeedsAlign */,
    PPtr<ScriptableObject>[] m_Tracks /* None */,
    double m_FixedDuration /* None */,
    EditorSettings m_EditorSettings /* None */,
    int m_DurationMode /* NeedsAlign */,
    PPtr<MarkerTrack> m_MarkerTrack /* None */)
{
    public static TimelineAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Version */
        int _m_Version = reader.ReadS32();
        PPtr<ScriptableObject>[] _m_Tracks = BuiltInArray<PPtr<ScriptableObject>>.Read(reader);
        double _m_FixedDuration = reader.ReadF64();
        EditorSettings _m_EditorSettings = EditorSettings.Read(reader);
        reader.AlignTo(4); /* m_DurationMode */
        int _m_DurationMode = reader.ReadS32();
        PPtr<MarkerTrack> _m_MarkerTrack = PPtr<MarkerTrack>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Version,
            _m_Tracks,
            _m_FixedDuration,
            _m_EditorSettings,
            _m_DurationMode,
            _m_MarkerTrack);
    }
}

