namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickUnifiedStatusView (10 fields) 731F23F08702068DBD3A24372948618C/F26F14A2587276C40E6C6255FB7358A8 */
public record class TooltipBrickUnifiedStatusView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Image /* None */,
    PPtr<Image> m_Frame /* None */,
    UnifiedStatusParams[] UnifiedStatusParams /* None */,
    float m_DefaultFontSize /* NeedsAlign */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickUnifiedStatusView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Frame = PPtr<Image>.Read(reader);
        UnifiedStatusParams[] _UnifiedStatusParams = BuiltInArray<UnifiedStatusParams>.Read(reader);
        reader.AlignTo(4); /* m_DefaultFontSize */
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Image,
            _m_Frame,
            _UnifiedStatusParams,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}

