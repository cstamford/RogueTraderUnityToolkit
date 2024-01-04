namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExpandableTitleView (11 fields) 1431E9C3998FF582D6B62826DCA544CC/182BD37D868FDDFF72289EEE9650657F */
public record class ExpandableTitleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_ExpandButton /* None */,
    PPtr<Transform> m_ExpandArrow /* None */,
    float m_CollapsedAngle /* None */,
    byte m_HasNavigation /* None */,
    PPtr<OwlcatMultiButton> m_ConsoleFocusButton /* NeedsAlign */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static ExpandableTitleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ExpandButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Transform> _m_ExpandArrow = PPtr<Transform>.Read(reader);
        float _m_CollapsedAngle = reader.ReadF32();
        byte _m_HasNavigation = reader.ReadU8();
        reader.AlignTo(4); /* m_ConsoleFocusButton */
        PPtr<OwlcatMultiButton> _m_ConsoleFocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_ExpandButton,
            _m_ExpandArrow,
            _m_CollapsedAngle,
            _m_HasNavigation,
            _m_ConsoleFocusButton,
            _m_LayoutSettings);
    }
}

