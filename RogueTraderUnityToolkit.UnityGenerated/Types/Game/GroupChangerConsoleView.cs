namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GroupChangerConsoleView (10 fields) 5600A9A83671D3CEE933462691FAE6AD/49DD1DDFD3CDA4F90194A7D1F3208882 */
public record class GroupChangerConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GroupChangerCharacterBaseView> m_RemoteCharacterView /* NeedsAlign */,
    PPtr<RectTransform> m_RemoteContainer /* None */,
    PPtr<GroupChangerCharacterBaseView> m_PartyCharacterView /* None */,
    PPtr<RectTransform> m_PartyContainer /* None */,
    PPtr<WindowAnimator> m_WindowAnimator /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static GroupChangerConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RemoteCharacterView,
            _m_RemoteContainer,
            _m_PartyCharacterView,
            _m_PartyContainer,
            _m_WindowAnimator,
            _m_HintsWidget);
    }
}

