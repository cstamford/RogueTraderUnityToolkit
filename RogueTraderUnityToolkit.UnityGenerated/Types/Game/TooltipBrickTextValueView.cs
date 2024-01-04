namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTextValueView (12 fields) 59CC7992A9994B872B70796580157191/8A24475194E6882B7F5AB9015EC3239E */
public record class TooltipBrickTextValueView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<GameObject> m_ResultLineImage /* None */,
    PPtr<GameObject> m_FirstNestedBlock /* None */,
    PPtr<GameObject> m_SecondNestedBlock /* None */,
    PPtr<GameObject> m_ThirdNestedBlock /* None */,
    PPtr<GameObject> m_FourthNestedBlock /* None */,
    PPtr<Image> m_Line /* None */)
{
    public static TooltipBrickTextValueView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ResultLineImage = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FirstNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SecondNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ThirdNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FourthNestedBlock = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_Line = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Value,
            _m_ResultLineImage,
            _m_FirstNestedBlock,
            _m_SecondNestedBlock,
            _m_ThirdNestedBlock,
            _m_FourthNestedBlock,
            _m_Line);
    }
}

