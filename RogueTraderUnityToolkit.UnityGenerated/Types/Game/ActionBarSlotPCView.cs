namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ActionBarSlotPCView (9 fields) F096AACC84E0E15BE5E5CFC8C4030EA6/AA434921C6084453828B28E30549F1BA */
public record class ActionBarSlotPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_ActionBarSlotType /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MainButton /* None */,
    PPtr<TextMeshProUGUI> m_HotkeyText /* None */,
    PPtr<ActionBarConvertedPCView> m_ConvertedView /* None */,
    PPtr<OwlcatMultiButton> m_ConvertButton /* None */)
{
    public static ActionBarSlotPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ActionBarSlotType */
        int _m_ActionBarSlotType = reader.ReadS32();
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HotkeyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ActionBarConvertedPCView> _m_ConvertedView = PPtr<ActionBarConvertedPCView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ConvertButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ActionBarSlotType,
            _m_MainButton,
            _m_HotkeyText,
            _m_ConvertedView,
            _m_ConvertButton);
    }
}

