namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickProfitFactorView (7 fields) 8D9E46E2A604CFFC60A5FC7DCCC5AF61/390628BE7BA7C17B28287CBC6A5C7891 */
public record class TooltipBrickProfitFactorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TotalValueText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CurrentValueText /* None */,
    PPtr<TextMeshProUGUI> m_RestoreSpeedText /* None */)
{
    public static TooltipBrickProfitFactorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TotalValueText */
        PPtr<TextMeshProUGUI> _m_TotalValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RestoreSpeedText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TotalValueText,
            _m_CurrentValueText,
            _m_RestoreSpeedText);
    }
}

