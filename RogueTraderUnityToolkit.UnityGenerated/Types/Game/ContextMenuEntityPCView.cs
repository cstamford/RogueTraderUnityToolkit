namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ContextMenuEntityPCView (8 fields) 2EDFDE22349CBB0BE829654FDEE0BD24/F8B4FDA26FC3EC599587D60F8F80F3AD */
public record class ContextMenuEntityPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<ContextButtonFx> m_ButtonFx /* None */)
{
    public static ContextMenuEntityPCView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Button,
            _m_Icon,
            _m_ButtonFx);
    }
}

