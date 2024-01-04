namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipComponentSlotConsoleView (23 fields) 5E32E89E3CBC2D6CC7C996869BCA2F86/B0708382850280AF60C961E126AEEA2C */
public record class ShipComponentSlotConsoleView(
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
    PPtr<CanvasGroup> m_SlotCanvasGroup /* None */,
    PPtr<ItemSlotConsoleView> m_ItemSlotPCView /* None */,
    PPtr<GameObject> m_LockState /* None */,
    PPtr<GameObject> m_EmptyPlaceholder /* None */,
    PPtr<OwlcatButton> m_EmptyPlaceholderButton /* None */,
    PPtr<GameObject> m_PossibleTargetHighlight /* None */,
    PPtr<TextMeshProUGUI> m_ShortDescription /* None */,
    PPtr<CanvasGroup> m_LinesBlock /* None */,
    PPtr<GameObject>[] m_ShipLines /* None */)
{
    public static ShipComponentSlotConsoleView Read(EndianBinaryReader reader)
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
        PPtr<CanvasGroup> _m_SlotCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ItemSlotConsoleView> _m_ItemSlotPCView = PPtr<ItemSlotConsoleView>.Read(reader);
        PPtr<GameObject> _m_LockState = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_EmptyPlaceholder = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_EmptyPlaceholderButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<GameObject> _m_PossibleTargetHighlight = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShortDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_LinesBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<GameObject>[] _m_ShipLines = BuiltInArray<PPtr<GameObject>>.Read(reader);
        
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
            _m_SlotCanvasGroup,
            _m_ItemSlotPCView,
            _m_LockState,
            _m_EmptyPlaceholder,
            _m_EmptyPlaceholderButton,
            _m_PossibleTargetHighlight,
            _m_ShortDescription,
            _m_LinesBlock,
            _m_ShipLines);
    }
}

