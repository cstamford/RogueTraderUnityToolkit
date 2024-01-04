namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoAvailableRanksCommonView (7 fields) 4AE1C42D068C60F25D30594520DFBFD5/23394D52F995217A69A02E8839A380D1 */
public record class CharInfoAvailableRanksCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_RanksContainer /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_RanksDesc /* None */,
    PPtr<TextMeshProUGUI> m_RanksCount /* None */)
{
    public static CharInfoAvailableRanksCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RanksContainer */
        PPtr<GameObject> _m_RanksContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RanksDesc = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RanksCount = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RanksContainer,
            _m_RanksDesc,
            _m_RanksCount);
    }
}

