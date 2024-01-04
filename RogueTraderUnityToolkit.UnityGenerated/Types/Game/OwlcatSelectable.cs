namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatSelectable (10 fields) E73293EB1302B565BED53D54B2158FED/C5BD51B4823B56CD40CFB01D2C30D5DB */
public record class OwlcatSelectable(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte AutoRefresh /* NeedsAlign */,
    int TestState /* NeedsAlign */,
    byte m_Interactable /* None */,
    byte ResetOnDisable /* NeedsAlign */,
    PPtr<OwlcatSelectable>[] m_ChildSelectables /* NeedsAlign */,
    OwlcatSelectableLayerPart m_CommonLayer /* None */)
{
    public static OwlcatSelectable Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AutoRefresh */
        byte _AutoRefresh = reader.ReadU8();
        reader.AlignTo(4); /* TestState */
        int _TestState = reader.ReadS32();
        byte _m_Interactable = reader.ReadU8();
        reader.AlignTo(4); /* ResetOnDisable */
        byte _ResetOnDisable = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildSelectables */
        PPtr<OwlcatSelectable>[] _m_ChildSelectables = BuiltInArray<PPtr<OwlcatSelectable>>.Read(reader);
        OwlcatSelectableLayerPart _m_CommonLayer = OwlcatSelectableLayerPart.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AutoRefresh,
            _TestState,
            _m_Interactable,
            _ResetOnDisable,
            _m_ChildSelectables,
            _m_CommonLayer);
    }
}

