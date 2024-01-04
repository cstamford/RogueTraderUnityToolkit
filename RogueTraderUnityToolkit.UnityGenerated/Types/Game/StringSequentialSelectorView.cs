namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StringSequentialSelectorView (13 fields) B987122057A10DB455DE4FE74AA64ABE/08287F05B9D1E74A1A175BE1D90998ED */
public record class StringSequentialSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CurrentValue /* None */,
    PPtr<GameObject> m_DescriptionObject /* None */,
    PPtr<TextMeshProUGUI> m_CurrentDescription /* None */,
    PPtr<OwlcatMultiButton> ButtonNext /* None */,
    PPtr<OwlcatMultiButton> ButtonPrevious /* None */,
    PPtr<TextMeshProUGUI> m_Counter /* None */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static StringSequentialSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_DescriptionObject = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _ButtonNext = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _ButtonPrevious = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Counter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_CurrentValue,
            _m_DescriptionObject,
            _m_CurrentDescription,
            _ButtonNext,
            _ButtonPrevious,
            _m_Counter,
            _m_Label,
            _m_LayoutSettings);
    }
}

