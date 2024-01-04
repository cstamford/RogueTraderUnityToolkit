namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryEquipSlotConsoleView (19 fields) B0605BE4E055CAD83A2BD0F00A60EF97/443E8CFEFEB2F54A22C26628D464DB60 */
public record class InventoryEquipSlotConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int UsableSource /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<GameObject> m_CountBackground /* None */,
    PPtr<TextMeshProUGUI> m_Count /* None */,
    PPtr<OwlcatMultiSelectable> m_ItemStatus /* None */,
    PPtr<OwlcatMultiSelectable> m_ItemGrade /* None */,
    PPtr<GameObject> m_UsableBgr /* None */,
    PPtr<RectTransform> m_RaycastZone /* None */,
    Vector2f m_ExpandRaycastSize /* None */,
    PPtr<CanvasGroup> m_BlinkMark /* None */,
    PPtr<Image> TypeIcon /* None */,
    PPtr<GameObject> m_PossibleTargetHighlight /* None */,
    PPtr<GameObject> m_NetLock /* None */,
    PPtr<GameObject> m_IsNotRemovable /* None */,
    PPtr<ItemSlotConsoleView> m_ItemSlotConsoleView /* None */)
{
    public static InventoryEquipSlotConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* UsableSource */
        int _UsableSource = reader.ReadS32();
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_CountBackground = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Count = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_ItemStatus = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_ItemGrade = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<GameObject> _m_UsableBgr = PPtr<GameObject>.Read(reader);
        PPtr<RectTransform> _m_RaycastZone = PPtr<RectTransform>.Read(reader);
        Vector2f _m_ExpandRaycastSize = Vector2f.Read(reader);
        PPtr<CanvasGroup> _m_BlinkMark = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _TypeIcon = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_PossibleTargetHighlight = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_NetLock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_IsNotRemovable = PPtr<GameObject>.Read(reader);
        PPtr<ItemSlotConsoleView> _m_ItemSlotConsoleView = PPtr<ItemSlotConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _UsableSource,
            _m_Icon,
            _m_CountBackground,
            _m_Count,
            _m_ItemStatus,
            _m_ItemGrade,
            _m_UsableBgr,
            _m_RaycastZone,
            _m_ExpandRaycastSize,
            _m_BlinkMark,
            _TypeIcon,
            _m_PossibleTargetHighlight,
            _m_NetLock,
            _m_IsNotRemovable,
            _m_ItemSlotConsoleView);
    }
}

