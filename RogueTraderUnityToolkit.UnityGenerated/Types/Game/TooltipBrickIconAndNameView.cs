namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconAndNameView (13 fields) 0C8B332A025934C3C4DE7762766A79AF/F88F45E3FD3A49163295AAA3F46E1F43 */
public record class TooltipBrickIconAndNameView(
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
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickIconAndNameView Read(EndianBinaryReader reader)
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
            _m_DefaultConsoleFontSize);
    }
}

