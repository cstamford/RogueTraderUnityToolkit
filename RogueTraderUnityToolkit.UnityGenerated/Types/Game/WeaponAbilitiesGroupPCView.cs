namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeaponAbilitiesGroupPCView (11 fields) F6A0BF2D402D732D4A794F559F21FC0C/6AD8FDA43011E6E7DF62C1A8BA630871 */
public record class WeaponAbilitiesGroupPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_GroupLabel /* NeedsAlign */,
    byte m_HasMultipleSlotsGroups /* None */,
    PPtr<CanvasGroup> m_SingleSlotGroup /* NeedsAlign */,
    PPtr<CanvasGroup> m_DoubleSlotGroup /* None */,
    PPtr<RectTransform> m_SlotsContainer /* None */,
    PPtr<ActionBarBaseSlotView> m_SlotView /* None */,
    float m_AnimationDuration /* None */)
{
    public static WeaponAbilitiesGroupPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GroupLabel */
        PPtr<TextMeshProUGUI> _m_GroupLabel = PPtr<TextMeshProUGUI>.Read(reader);
        byte _m_HasMultipleSlotsGroups = reader.ReadU8();
        reader.AlignTo(4); /* m_SingleSlotGroup */
        PPtr<CanvasGroup> _m_SingleSlotGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_DoubleSlotGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<RectTransform> _m_SlotsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<ActionBarBaseSlotView> _m_SlotView = PPtr<ActionBarBaseSlotView>.Read(reader);
        float _m_AnimationDuration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_GroupLabel,
            _m_HasMultipleSlotsGroups,
            _m_SingleSlotGroup,
            _m_DoubleSlotGroup,
            _m_SlotsContainer,
            _m_SlotView,
            _m_AnimationDuration);
    }
}

