namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveLoadPCView (13 fields) E6DFB1F9BA60BAEA994CE56BD90D01DA/CCE3E7A61453A950E2EE3C0B6F860554 */
public record class SaveLoadPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<SaveLoadMenuBaseView> m_Menu /* None */,
    PPtr<SaveSlotBaseView> m_NewSaveSlotBaseView /* None */,
    PPtr<SaveSlotCollectionVirtualBaseView> m_SlotCollectionView /* None */,
    PPtr<SaveSlotBaseView> m_DetailedSaveSlotView /* None */,
    PPtr<SaveFullScreenshotBaseView> m_FullScreenshotBaseView /* None */,
    PPtr<RectTransform> m_WaitingForSaveListUpdatingAnimation /* None */,
    PPtr<RectTransform> m_SavesRect /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */)
{
    public static SaveLoadPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<SaveLoadMenuBaseView> _m_Menu = PPtr<SaveLoadMenuBaseView>.Read(reader);
        PPtr<SaveSlotBaseView> _m_NewSaveSlotBaseView = PPtr<SaveSlotBaseView>.Read(reader);
        PPtr<SaveSlotCollectionVirtualBaseView> _m_SlotCollectionView = PPtr<SaveSlotCollectionVirtualBaseView>.Read(reader);
        PPtr<SaveSlotBaseView> _m_DetailedSaveSlotView = PPtr<SaveSlotBaseView>.Read(reader);
        PPtr<SaveFullScreenshotBaseView> _m_FullScreenshotBaseView = PPtr<SaveFullScreenshotBaseView>.Read(reader);
        PPtr<RectTransform> _m_WaitingForSaveListUpdatingAnimation = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_SavesRect = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Menu,
            _m_NewSaveSlotBaseView,
            _m_SlotCollectionView,
            _m_DetailedSaveSlotView,
            _m_FullScreenshotBaseView,
            _m_WaitingForSaveListUpdatingAnimation,
            _m_SavesRect,
            _m_CloseButton);
    }
}

