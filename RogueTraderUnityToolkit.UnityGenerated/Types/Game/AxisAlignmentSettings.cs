namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AxisAlignmentSettings (7 fields) F977E0FD0E6580511CB31DC58AD0EC80/36191B5ADA48A28B3E7047DBC85956C1 */
public record class AxisAlignmentSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _isEnabled /* NeedsAlign */,
    int _alignmentAxis /* NeedsAlign */,
    AxisAlignmentSettingsView _view /* None */)
{
    public static AxisAlignmentSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _isEnabled */
        byte __isEnabled = reader.ReadU8();
        reader.AlignTo(4); /* _alignmentAxis */
        int __alignmentAxis = reader.ReadS32();
        AxisAlignmentSettingsView __view = AxisAlignmentSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __isEnabled,
            __alignmentAxis,
            __view);
    }
}

