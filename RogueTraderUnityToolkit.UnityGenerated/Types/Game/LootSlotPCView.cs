namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootSlotPCView (15 fields) 70F1AF0B03D8B27D303C9E800D68D8DA/72F2EAF6B859646D85FDF98BE2E965CF */
public record class LootSlotPCView(
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
    PPtr<ItemSlotPCView> m_ItemSlotPCView /* None */)
{
    public static LootSlotPCView Read(EndianBinaryReader reader)
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
        PPtr<ItemSlotPCView> _m_ItemSlotPCView = PPtr<ItemSlotPCView>.Read(reader);
        
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
            _m_ItemSlotPCView);
    }
}

