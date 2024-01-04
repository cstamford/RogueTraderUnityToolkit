namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootSlotConsoleView (15 fields) 3A19D6D442A370D34D72F2157BE24CB5/8B7D6A4B8EE6B7CE5C3E57DDF590840E */
public record class LootSlotConsoleView(
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
    PPtr<ItemSlotConsoleView> m_ItemSlotConsoleView /* None */)
{
    public static LootSlotConsoleView Read(EndianBinaryReader reader)
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
            _m_ItemSlotConsoleView);
    }
}

