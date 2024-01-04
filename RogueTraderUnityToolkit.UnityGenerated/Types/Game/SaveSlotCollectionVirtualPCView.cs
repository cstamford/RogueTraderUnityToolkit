namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveSlotCollectionVirtualPCView (7 fields) 6F0E1682D87BA08B60C66D889F18C76D/6D906681BE84075B1699EB02984689AC */
public record class SaveSlotCollectionVirtualPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SaveSlotsExpandableTitleView> m_ExpandableTitleView /* NeedsAlign */,
    PPtr<SaveSlotBaseView> m_SaveSlotPrefab /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* None */)
{
    public static SaveSlotCollectionVirtualPCView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExpandableTitleView,
            _m_SaveSlotPrefab,
            _m_VirtualList);
    }
}

