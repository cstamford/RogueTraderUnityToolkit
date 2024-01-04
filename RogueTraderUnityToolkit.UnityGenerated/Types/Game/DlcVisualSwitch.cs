namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DlcVisualSwitch (7 fields) C29232C10EF46D767C729DDE8BABCB9A/33F27044A151BE2F5D0368134098D842 */
public record class DlcVisualSwitch(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintDlcReference m_Dlc /* NeedsAlign */,
    PPtr<GameObject> m_defaultVisual /* NeedsAlign */,
    PPtr<GameObject> m_dlcVisual /* None */)
{
    public static DlcVisualSwitch Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Dlc */
        BlueprintDlcReference _m_Dlc = BlueprintDlcReference.Read(reader);
        reader.AlignTo(4); /* m_defaultVisual */
        PPtr<GameObject> _m_defaultVisual = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_dlcVisual = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Dlc,
            _m_defaultVisual,
            _m_dlcVisual);
    }
}

