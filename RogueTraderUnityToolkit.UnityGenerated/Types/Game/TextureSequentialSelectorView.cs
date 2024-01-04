namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TextureSequentialSelectorView (11 fields) 9BD31992555E6B14D2B32CB5C79D671C/8CC8BC399A06598933E5B2B1CCEE2404 */
public record class TextureSequentialSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<Image> m_CurrentValue /* None */,
    PPtr<OwlcatMultiButton> m_ButtonNext /* None */,
    PPtr<OwlcatMultiButton> m_ButtonPrevious /* None */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<TextMeshProUGUI> m_Counter /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static TextureSequentialSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<Image> _m_CurrentValue = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ButtonNext = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ButtonPrevious = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Counter = PPtr<TextMeshProUGUI>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_CurrentValue,
            _m_ButtonNext,
            _m_ButtonPrevious,
            _m_Label,
            _m_Counter,
            _m_LayoutSettings);
    }
}

