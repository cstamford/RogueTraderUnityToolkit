namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickUnifiedStatusConsoleView (11 fields) 83D72120A4986098D6B3E0F59B8A5987/FAC209E561FB15B86D2075A25F7E1ED8 */
public record class TooltipBrickUnifiedStatusConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Image /* None */,
    PPtr<Image> m_Frame /* None */,
    UnifiedStatusParams UnifiedStatusParams /* None */,
    float m_DefaultFontSize /* NeedsAlign */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickUnifiedStatusConsoleView Read(EndianBinaryReader reader)
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
        UnifiedStatusParams _UnifiedStatusParams = UnifiedStatusParams.Read(reader);
        reader.AlignTo(4); /* m_DefaultFontSize */
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Image,
            _m_Frame,
            _UnifiedStatusParams,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_MultiButton);
    }
}

