namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceTypeData (8 fields) CEDFF7B748A5A71CEA12DA8636495065/13BABAFC0FEDFFA1172BAA60D47122D7 */
public record class SurfaceTypeData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Entry Types /* NeedsAlign */,
    AsciiString[] SortedMaskNames /* NeedsAlign */,
    Setting[] Settings /* NeedsAlign */,
    SurfaceDebugInfo[] m_SurfaceDebugInfos /* NeedsAlign */)
{
    public static SurfaceTypeData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Types */
        Entry _Types = Entry.Read(reader);
        reader.AlignTo(4); /* SortedMaskNames */
        AsciiString[] _SortedMaskNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* Settings */
        Setting[] _Settings = BuiltInArray<Setting>.Read(reader);
        reader.AlignTo(4); /* m_SurfaceDebugInfos */
        SurfaceDebugInfo[] _m_SurfaceDebugInfos = BuiltInArray<SurfaceDebugInfo>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Types,
            _SortedMaskNames,
            _Settings,
            _m_SurfaceDebugInfos);
    }
}

