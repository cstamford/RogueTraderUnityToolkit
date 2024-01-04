namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GroupChangerPCView (12 fields) B309CF916637B66B0805C2B84742AB13/220B5CFF82F5BCA5CFFF4061348C93FE */
public record class GroupChangerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GroupChangerCharacterBaseView> m_RemoteCharacterView /* NeedsAlign */,
    PPtr<RectTransform> m_RemoteContainer /* None */,
    PPtr<GroupChangerCharacterBaseView> m_PartyCharacterView /* None */,
    PPtr<RectTransform> m_PartyContainer /* None */,
    PPtr<WindowAnimator> m_WindowAnimator /* None */,
    PPtr<OwlcatButton> m_AcceptButton /* None */,
    PPtr<TextMeshProUGUI> m_AcceptLabel /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */)
{
    public static GroupChangerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RemoteCharacterView */
        PPtr<GroupChangerCharacterBaseView> _m_RemoteCharacterView = PPtr<GroupChangerCharacterBaseView>.Read(reader);
        PPtr<RectTransform> _m_RemoteContainer = PPtr<RectTransform>.Read(reader);
        PPtr<GroupChangerCharacterBaseView> _m_PartyCharacterView = PPtr<GroupChangerCharacterBaseView>.Read(reader);
        PPtr<RectTransform> _m_PartyContainer = PPtr<RectTransform>.Read(reader);
        PPtr<WindowAnimator> _m_WindowAnimator = PPtr<WindowAnimator>.Read(reader);
        PPtr<OwlcatButton> _m_AcceptButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AcceptLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RemoteCharacterView,
            _m_RemoteContainer,
            _m_PartyCharacterView,
            _m_PartyContainer,
            _m_WindowAnimator,
            _m_AcceptButton,
            _m_AcceptLabel,
            _m_CloseButton);
    }
}

