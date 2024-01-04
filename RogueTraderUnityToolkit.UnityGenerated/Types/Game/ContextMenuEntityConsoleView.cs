namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ContextMenuEntityConsoleView (9 fields) DB022884416373DC2345B5F14E8B0A30/4943BA16A78493353AFF9CCB3F360597 */
public record class ContextMenuEntityConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<ContextButtonFx> m_ButtonFx /* None */,
    PPtr<Image> m_HintIcon /* None */)
{
    public static ContextMenuEntityConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<ContextButtonFx> _m_ButtonFx = PPtr<ContextButtonFx>.Read(reader);
        PPtr<Image> _m_HintIcon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Button,
            _m_Icon,
            _m_ButtonFx,
            _m_HintIcon);
    }
}

