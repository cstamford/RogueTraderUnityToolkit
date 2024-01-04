namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalNavigationGroupElementConsoleView (26 fields) D55957D68435896B833FD360F37303D4/9B7A4712F085B9C2ECBDEAED4FFAC357 */
public record class JournalNavigationGroupElementConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    byte m_SetLabelBold /* None */,
    PPtr<Image> m_StatusImage /* NeedsAlign */,
    PPtr<Sprite> m_UpdatedPaperMark /* None */,
    PPtr<Sprite> m_NewQuestPaperMark /* None */,
    PPtr<Sprite> m_NewOrderPaperMark /* None */,
    PPtr<Sprite> m_NewRumourPaperMark /* None */,
    PPtr<Sprite> m_CompletedPaperMark /* None */,
    PPtr<Sprite> m_FailedPaperMark /* None */,
    PPtr<Sprite> m_PostponedPaperMark /* None */,
    PPtr<Sprite> m_AlarmPaperMark /* None */,
    PPtr<Sprite> m_UpdatedPantographMark /* None */,
    PPtr<Sprite> m_NewQuestPantographMark /* None */,
    PPtr<Sprite> m_NewOrderPantographMark /* None */,
    PPtr<Sprite> m_NewRumourPantographMark /* None */,
    PPtr<Sprite> m_CompletedPantographMark /* None */,
    PPtr<Sprite> m_FailedPantographMark /* None */,
    PPtr<Sprite> m_PostponedPantographMark /* None */,
    PPtr<Sprite> m_AlarmPantographMark /* None */,
    PPtr<Sprite> m_ReadyToCompletePantographMark /* None */,
    PPtr<RectTransform> m_ReadyToCompleteImage /* None */)
{
    public static JournalNavigationGroupElementConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MultiButton */
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        byte _m_SetLabelBold = reader.ReadU8();
        reader.AlignTo(4); /* m_StatusImage */
        PPtr<Image> _m_StatusImage = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_UpdatedPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NewQuestPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NewOrderPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NewRumourPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_CompletedPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_FailedPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_PostponedPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_AlarmPaperMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_UpdatedPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NewQuestPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NewOrderPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NewRumourPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_CompletedPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_FailedPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_PostponedPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_AlarmPantographMark = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_ReadyToCompletePantographMark = PPtr<Sprite>.Read(reader);
        PPtr<RectTransform> _m_ReadyToCompleteImage = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MultiButton,
            _m_Label,
            _m_SetLabelBold,
            _m_StatusImage,
            _m_UpdatedPaperMark,
            _m_NewQuestPaperMark,
            _m_NewOrderPaperMark,
            _m_NewRumourPaperMark,
            _m_CompletedPaperMark,
            _m_FailedPaperMark,
            _m_PostponedPaperMark,
            _m_AlarmPaperMark,
            _m_UpdatedPantographMark,
            _m_NewQuestPantographMark,
            _m_NewOrderPantographMark,
            _m_NewRumourPantographMark,
            _m_CompletedPantographMark,
            _m_FailedPantographMark,
            _m_PostponedPantographMark,
            _m_AlarmPantographMark,
            _m_ReadyToCompletePantographMark,
            _m_ReadyToCompleteImage);
    }
}

