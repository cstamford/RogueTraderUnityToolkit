namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoSoulMarkShiftRecordPCView (8 fields) 177274F80B9B109E1F09C1BA510F01BA/1F54D9AB8139F560A3BF3987F47C5085 */
public record class CharInfoSoulMarkShiftRecordPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Description /* NeedsAlign */,
    ColorRGBA m_FaithColor /* None */,
    ColorRGBA m_CorruptionColor /* None */,
    ColorRGBA m_HopeColor /* None */)
{
    public static CharInfoSoulMarkShiftRecordPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Description */
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_FaithColor = ColorRGBA.Read(reader);
        ColorRGBA _m_CorruptionColor = ColorRGBA.Read(reader);
        ColorRGBA _m_HopeColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Description,
            _m_FaithColor,
            _m_CorruptionColor,
            _m_HopeColor);
    }
}

