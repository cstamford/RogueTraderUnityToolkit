namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatDropdown (12 fields) C0F92A024948218468B805DB0CF05DAD/63ED07649382230105B5BD027A581A35 */
public record class OwlcatDropdown(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainMultiButton /* NeedsAlign */,
    PPtr<DropdownItemView> m_DropdownItemView /* None */,
    PPtr<DropdownItemView> m_DropdownItemViewPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<OwlcatToggleGroup> m_ToggleGroup /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    float m_ItemHeight /* None */)
{
    public static OwlcatDropdown Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainMultiButton */
        PPtr<OwlcatMultiButton> _m_MainMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<DropdownItemView> _m_DropdownItemView = PPtr<DropdownItemView>.Read(reader);
        PPtr<DropdownItemView> _m_DropdownItemViewPrefab = PPtr<DropdownItemView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<OwlcatToggleGroup> _m_ToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        float _m_ItemHeight = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainMultiButton,
            _m_DropdownItemView,
            _m_DropdownItemViewPrefab,
            _m_WidgetList,
            _m_ToggleGroup,
            _m_ScrollRect,
            _m_FadeAnimator,
            _m_ItemHeight);
    }
}

