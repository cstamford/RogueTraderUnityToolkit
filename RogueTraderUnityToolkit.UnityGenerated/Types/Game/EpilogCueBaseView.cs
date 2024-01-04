namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EpilogCueBaseView (10 fields) B25220258C9054B1F05156EFE939AB7A/C2CA9A5443B6622725CCAE4B4DD1560E */
public record class EpilogCueBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<TMP_FontAsset> m_FirstLetterFont /* None */,
    PPtr<Material> m_FirstLetterFontMaterial /* None */,
    ColorRGBA m_FirstLetterColor /* None */,
    int m_FirstLetterSize /* None */,
    int m_FirstLetterVOffset /* None */)
{
    public static EpilogCueBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TMP_FontAsset> _m_FirstLetterFont = PPtr<TMP_FontAsset>.Read(reader);
        PPtr<Material> _m_FirstLetterFontMaterial = PPtr<Material>.Read(reader);
        ColorRGBA _m_FirstLetterColor = ColorRGBA.Read(reader);
        int _m_FirstLetterSize = reader.ReadS32();
        int _m_FirstLetterVOffset = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_FirstLetterFont,
            _m_FirstLetterFontMaterial,
            _m_FirstLetterColor,
            _m_FirstLetterSize,
            _m_FirstLetterVOffset);
    }
}

