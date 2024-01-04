namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipTransitionPCView (8 fields) 99111422F93EE651F3FE016C09CF298C/4A7FA2D150F89A6AD1E4FBBC173EB5A9 */
public record class OvertipTransitionPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<CanvasGroup> m_TitleBlock /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<CanvasGroup> m_ActiveLayer /* None */)
{
    public static OvertipTransitionPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<CanvasGroup> _m_TitleBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_ActiveLayer = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_TitleBlock,
            _m_Title,
            _m_ActiveLayer);
    }
}

