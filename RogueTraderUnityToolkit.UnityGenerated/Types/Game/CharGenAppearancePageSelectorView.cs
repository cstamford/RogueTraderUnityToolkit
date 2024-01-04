namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAppearancePageSelectorView (7 fields) 091BC8347B6C76332561C01AEFFF14AA/57D16EF4329E864EB327093B65E81ECD */
public record class CharGenAppearancePageSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VirtualListComponent> VirtualList /* NeedsAlign */,
    PPtr<CharGenAppearancePageMenuItemView> SlotPrefab /* None */,
    byte HasSorter /* None */)
{
    public static CharGenAppearancePageSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* VirtualList */
        PPtr<VirtualListComponent> _VirtualList = PPtr<VirtualListComponent>.Read(reader);
        PPtr<CharGenAppearancePageMenuItemView> _SlotPrefab = PPtr<CharGenAppearancePageMenuItemView>.Read(reader);
        byte _HasSorter = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _VirtualList,
            _SlotPrefab,
            _HasSorter);
    }
}

