namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorReputationForItemWindowPCView (6 fields) C0DD4176AEF9420989DE0CE554547FCE/DA7625F9D389C605DDFE8FC864F05185 */
public record class VendorReputationForItemWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* NeedsAlign */,
    PPtr<VirtualListElementViewBase_1> m_ReputationForItemPrefab /* None */)
{
    public static VendorReputationForItemWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VirtualList */
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<VirtualListElementViewBase_1> _m_ReputationForItemPrefab = PPtr<VirtualListElementViewBase_1>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VirtualList,
            _m_ReputationForItemPrefab);
    }
}

