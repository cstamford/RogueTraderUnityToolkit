namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CreditsMenuEntityPCView (8 fields) 94391CF74CE64CDCC59952FC7863C014/7EBB7AD6C60A7B85B9A99E010314602D */
public record class CreditsMenuEntityPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    byte m_WithImage /* None */,
    PPtr<Image> m_Image /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */)
{
    public static CreditsMenuEntityPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        byte _m_WithImage = reader.ReadU8();
        reader.AlignTo(4); /* m_Image */
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_WithImage,
            _m_Image,
            _m_Label);
    }
}

