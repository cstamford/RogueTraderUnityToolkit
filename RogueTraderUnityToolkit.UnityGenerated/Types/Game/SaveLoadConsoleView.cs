namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveLoadConsoleView (15 fields) 7BD552C457527C83187AD287B9AB3F15/BF5335AD004D319E3D22924F3725D279 */
public record class SaveLoadConsoleView(
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
    PPtr<ConsoleHintsWidget> m_CommonHintsWidget /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */)
{
    public static SaveLoadConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ConsoleHintsWidget> _m_CommonHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        
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
            _m_CommonHintsWidget,
            _m_PrevHint,
            _m_NextHint);
    }
}

