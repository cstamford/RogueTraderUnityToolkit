namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickRateConsoleView (10 fields) 2301366286DF677D04155A7CA593936D/FB97BDA4A5C856E2FB7CAEBE0382EE38 */
public record class TooltipBrickRateConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_RateTitle /* NeedsAlign */,
    PPtr<GameObject>[] m_RateSlots /* None */,
    PPtr<GameObject>[] m_RatePoints /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton>[] m_Buttons /* None */)
{
    public static TooltipBrickRateConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RateTitle */
        PPtr<TextMeshProUGUI> _m_RateTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject>[] _m_RateSlots = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<GameObject>[] _m_RatePoints = BuiltInArray<PPtr<GameObject>>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton>[] _m_Buttons = BuiltInArray<PPtr<OwlcatMultiButton>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RateTitle,
            _m_RateSlots,
            _m_RatePoints,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_Buttons);
    }
}

