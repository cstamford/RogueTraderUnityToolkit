namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TransitionPCView (8 fields) B9070D5035735DF175C6C16E6EA7F67D/D315F2C857FC488061BA49B90198AC1E */
public record class TransitionPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MapName /* NeedsAlign */,
    TransitionMapPart[] m_Parts /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<TransitionLegendButtonView> m_TransitionLegendButtonViewPrefab /* None */)
{
    public static TransitionPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MapName */
        PPtr<TextMeshProUGUI> _m_MapName = PPtr<TextMeshProUGUI>.Read(reader);
        TransitionMapPart[] _m_Parts = BuiltInArray<TransitionMapPart>.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<TransitionLegendButtonView> _m_TransitionLegendButtonViewPrefab = PPtr<TransitionLegendButtonView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MapName,
            _m_Parts,
            _m_PantographView,
            _m_TransitionLegendButtonViewPrefab);
    }
}

