namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RespecWindowPCView (11 fields) 79C9C9CEE7F4824BBE99C2B6048861E3/92A603CD04E28E5B83E0289454631738 */
public record class RespecWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    PPtr<TextMeshProUGUI> m_RespecCost /* None */,
    PPtr<RespecCharactersSelectorView> m_RespecCharactersSelectorView /* None */,
    PPtr<SystemMapSpaceResourcesPCView> m_SystemMapSpaceResourcesView /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_AcceptButton /* None */)
{
    public static RespecWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RespecCost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RespecCharactersSelectorView> _m_RespecCharactersSelectorView = PPtr<RespecCharactersSelectorView>.Read(reader);
        PPtr<SystemMapSpaceResourcesPCView> _m_SystemMapSpaceResourcesView = PPtr<SystemMapSpaceResourcesPCView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatButton> _m_AcceptButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_HeaderLabel,
            _m_RespecCost,
            _m_RespecCharactersSelectorView,
            _m_SystemMapSpaceResourcesView,
            _m_CloseButton,
            _m_AcceptButton);
    }
}

