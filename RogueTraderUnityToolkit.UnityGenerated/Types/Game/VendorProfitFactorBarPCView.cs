namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorProfitFactorBarPCView (6 fields) 2A6D20E22AD80017EAF4B7501BDCFC04/23811F197DABC7FAB3215C99A86363D7 */
public record class VendorProfitFactorBarPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TotalValueText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CurrentValueText /* None */)
{
    public static VendorProfitFactorBarPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TotalValueText */
        PPtr<TextMeshProUGUI> _m_TotalValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentValueText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TotalValueText,
            _m_CurrentValueText);
    }
}

