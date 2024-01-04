namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PartyConsoleView (9 fields) 807D8AE8A502C1A0EEBB12C5B550A406/01F0B3314A24DFE265AB506207ED57CD */
public record class PartyConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<HorizontalLayoutGroup> m_LayoutGroup /* NeedsAlign */,
    PPtr<ContentSizeFitterExtended> m_ContentSizeFitter /* None */,
    PPtr<ConsoleHint> m_PreviousHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */,
    int[] m_WindowsWithParty /* None */)
{
    public static PartyConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LayoutGroup */
        PPtr<HorizontalLayoutGroup> _m_LayoutGroup = PPtr<HorizontalLayoutGroup>.Read(reader);
        PPtr<ContentSizeFitterExtended> _m_ContentSizeFitter = PPtr<ContentSizeFitterExtended>.Read(reader);
        PPtr<ConsoleHint> _m_PreviousHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        int[] _m_WindowsWithParty = BuiltInArray<int>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LayoutGroup,
            _m_ContentSizeFitter,
            _m_PreviousHint,
            _m_NextHint,
            _m_WindowsWithParty);
    }
}

