namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbySaveSlotCollectionConsoleView (8 fields) 64B8B92EB2FF322EC0ABE5C677FB8441/EA24AEF1BE1FA634E038479FF0181854 */
public record class NetLobbySaveSlotCollectionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SaveSlotsExpandableTitleView> m_ExpandableTitleView /* NeedsAlign */,
    PPtr<SaveSlotBaseView> m_SaveSlotPrefab /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* None */,
    PPtr<ConsoleHintsWidget> m_CommonHintsWidget /* None */)
{
    public static NetLobbySaveSlotCollectionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExpandableTitleView */
        PPtr<SaveSlotsExpandableTitleView> _m_ExpandableTitleView = PPtr<SaveSlotsExpandableTitleView>.Read(reader);
        PPtr<SaveSlotBaseView> _m_SaveSlotPrefab = PPtr<SaveSlotBaseView>.Read(reader);
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_CommonHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExpandableTitleView,
            _m_SaveSlotPrefab,
            _m_VirtualList,
            _m_CommonHintsWidget);
    }
}

