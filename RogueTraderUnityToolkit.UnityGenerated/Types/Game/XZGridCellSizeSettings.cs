namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $XZGridCellSizeSettings (7 fields) 47B95CFBE447C470592C9A175124060F/2044E62D75B5C556435E72F9BAAD8A29 */
public record class XZGridCellSizeSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float _cellSizeX /* NeedsAlign */,
    float _cellSizeZ /* None */,
    XZGridCellSizeSettingsView _view /* None */)
{
    public static XZGridCellSizeSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _cellSizeX */
        float __cellSizeX = reader.ReadF32();
        float __cellSizeZ = reader.ReadF32();
        XZGridCellSizeSettingsView __view = XZGridCellSizeSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __cellSizeX,
            __cellSizeZ,
            __view);
    }
}

