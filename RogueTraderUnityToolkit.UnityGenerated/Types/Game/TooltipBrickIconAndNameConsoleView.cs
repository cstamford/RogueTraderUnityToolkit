namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconAndNameConsoleView (14 fields) 7142364ED32795608AD5B43E79BF62DB/2CBAD2431283F65CD9AFA17E5DDFE11C */
public record class TooltipBrickIconAndNameConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<LayoutElement> m_IconContainer /* None */,
    PPtr<GameObject> m_Frame /* None */,
    int m_BigSize /* None */,
    int m_MediumSize /* None */,
    int m_SmallSize /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickIconAndNameConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LayoutElement> _m_IconContainer = PPtr<LayoutElement>.Read(reader);
        PPtr<GameObject> _m_Frame = PPtr<GameObject>.Read(reader);
        int _m_BigSize = reader.ReadS32();
        int _m_MediumSize = reader.ReadS32();
        int _m_SmallSize = reader.ReadS32();
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Title,
            _m_IconContainer,
            _m_Frame,
            _m_BigSize,
            _m_MediumSize,
            _m_SmallSize,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_MultiButton);
    }
}

