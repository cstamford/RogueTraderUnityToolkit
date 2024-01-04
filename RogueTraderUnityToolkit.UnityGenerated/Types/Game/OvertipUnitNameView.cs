namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipUnitNameView (8 fields) 7C8604F1B6A00ACED9895D3160935EA1/1F5912F8CA0BE3ABD0E86C6DF0806AA4 */
public record class OvertipUnitNameView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameText /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_MultiSelectable /* None */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<RectTransform>[] m_ContainersList /* None */)
{
    public static OvertipUnitNameView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameText */
        PPtr<TextMeshProUGUI> _m_NameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_MultiSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform>[] _m_ContainersList = BuiltInArray<PPtr<RectTransform>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameText,
            _m_MultiSelectable,
            _m_Animator,
            _m_ContainersList);
    }
}

