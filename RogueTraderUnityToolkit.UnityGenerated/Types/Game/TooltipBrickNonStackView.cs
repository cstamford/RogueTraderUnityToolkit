namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickNonStackView (8 fields) 985FF5787346A44900A1D5E78B26B08C/C85DE8EE4B1C47C735BEA29ED46FEAB8 */
public record class TooltipBrickNonStackView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Header /* NeedsAlign */,
    PPtr<TooltipBrickNonStackEntityView> m_EntityView /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickNonStackView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Header */
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TooltipBrickNonStackEntityView> _m_EntityView = PPtr<TooltipBrickNonStackEntityView>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Header,
            _m_EntityView,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}

