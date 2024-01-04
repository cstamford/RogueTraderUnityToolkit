namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PointMarkerLOSView (6 fields) A8631A66B3A81AAC3DC0D7FAEE5BB3D6/E099B150ED4E19C917493B4EF3C14AE5 */
public record class PointMarkerLOSView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LineOfSightColor[] m_ColorsTable /* NeedsAlign */,
    PPtr<Image> m_Image /* NeedsAlign */)
{
    public static PointMarkerLOSView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColorsTable */
        LineOfSightColor[] _m_ColorsTable = BuiltInArray<LineOfSightColor>.Read(reader);
        reader.AlignTo(4); /* m_Image */
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColorsTable,
            _m_Image);
    }
}

