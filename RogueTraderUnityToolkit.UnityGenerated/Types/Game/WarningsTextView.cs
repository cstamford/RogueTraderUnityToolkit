namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WarningsTextView (10 fields) 2C9339DE7DB0CEFF1A6FF67690AE9458/F11DDF7181A9136244626E4CD5FD3FBB */
public record class WarningsTextView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    WarningTextElement m_CommonWarning /* NeedsAlign */,
    WarningTextWithCountElement m_CounterElement /* None */,
    WarningTextElement m_AttentionElement /* None */,
    WarningTextElement m_WarningElement /* None */,
    float m_FadeShowHide /* None */,
    float m_FadeStayOnTheScreen /* None */)
{
    public static WarningsTextView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CommonWarning */
        WarningTextElement _m_CommonWarning = WarningTextElement.Read(reader);
        WarningTextWithCountElement _m_CounterElement = WarningTextWithCountElement.Read(reader);
        WarningTextElement _m_AttentionElement = WarningTextElement.Read(reader);
        WarningTextElement _m_WarningElement = WarningTextElement.Read(reader);
        float _m_FadeShowHide = reader.ReadF32();
        float _m_FadeStayOnTheScreen = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CommonWarning,
            _m_CounterElement,
            _m_AttentionElement,
            _m_WarningElement,
            _m_FadeShowHide,
            _m_FadeStayOnTheScreen);
    }
}

