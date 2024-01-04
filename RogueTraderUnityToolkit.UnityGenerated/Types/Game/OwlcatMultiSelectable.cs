namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatMultiSelectable (11 fields) 77A05445AA192C3D6573E7AA065755A6/91922D33C33BA613ED1E566D9F905A15 */
public record class OwlcatMultiSelectable(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte AutoRefresh /* NeedsAlign */,
    int TestState /* NeedsAlign */,
    byte m_Interactable /* None */,
    byte ResetOnDisable /* NeedsAlign */,
    PPtr<OwlcatSelectable>[] m_ChildSelectables /* NeedsAlign */,
    OwlcatSelectableLayerPart m_CommonLayer /* None */,
    OwlcatMultiLayer[] m_MultiLayers /* NeedsAlign */)
{
    public static OwlcatMultiSelectable Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_MultiLayers */
        OwlcatMultiLayer[] _m_MultiLayers = BuiltInArray<OwlcatMultiLayer>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AutoRefresh,
            _TestState,
            _m_Interactable,
            _ResetOnDisable,
            _m_ChildSelectables,
            _m_CommonLayer,
            _m_MultiLayers);
    }
}

