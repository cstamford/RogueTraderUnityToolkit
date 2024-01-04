namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TextureSelectorPagedView (10 fields) CE5B854E19EA997C9C42A0326F367952/A92E3C2711B1057E884E280D93CD2625 */
public record class TextureSelectorPagedView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<TextureSelectorGroupView> m_GroupView /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */,
    PPtr<GameObject>[] m_NoSelectionsGroup /* NeedsAlign */,
    PPtr<GameObject>[] m_HasSelectionsGroup /* None */,
    PPtr<TextMeshProUGUI> m_NoSelectionsWarning /* None */)
{
    public static TextureSelectorPagedView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<TextureSelectorGroupView> _m_GroupView = PPtr<TextureSelectorGroupView>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_NoSelectionsGroup */
        PPtr<GameObject>[] _m_NoSelectionsGroup = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<GameObject>[] _m_HasSelectionsGroup = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoSelectionsWarning = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_GroupView,
            _m_LayoutSettings,
            _m_NoSelectionsGroup,
            _m_HasSelectionsGroup,
            _m_NoSelectionsWarning);
    }
}

