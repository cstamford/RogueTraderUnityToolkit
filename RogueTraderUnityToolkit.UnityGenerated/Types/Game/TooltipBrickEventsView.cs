namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickEventsView (13 fields) 443AC2F00BF35A837A06D4BBB3985D43/6D775054C40B973B9E4218395FA75E68 */
public record class TooltipBrickEventsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_EventName /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_EventDescription /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<Image> m_Background /* None */,
    EventRelationTypeParams[] EventRelationTypeParams /* None */,
    float m_DefaultFontSizeName /* None */,
    float m_DefaultFontSizeDescription /* None */,
    float m_DefaultConsoleFontSizeName /* None */,
    float m_DefaultConsoleFontSizeDescription /* None */)
{
    public static TooltipBrickEventsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EventName */
        PPtr<TextMeshProUGUI> _m_EventName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EventDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Background = PPtr<Image>.Read(reader);
        EventRelationTypeParams[] _EventRelationTypeParams = BuiltInArray<EventRelationTypeParams>.Read(reader);
        float _m_DefaultFontSizeName = reader.ReadF32();
        float _m_DefaultFontSizeDescription = reader.ReadF32();
        float _m_DefaultConsoleFontSizeName = reader.ReadF32();
        float _m_DefaultConsoleFontSizeDescription = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EventName,
            _m_EventDescription,
            _m_Icon,
            _m_Background,
            _EventRelationTypeParams,
            _m_DefaultFontSizeName,
            _m_DefaultFontSizeDescription,
            _m_DefaultConsoleFontSizeName,
            _m_DefaultConsoleFontSizeDescription);
    }
}

