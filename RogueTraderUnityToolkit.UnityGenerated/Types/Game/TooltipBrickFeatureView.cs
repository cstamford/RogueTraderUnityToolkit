namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickFeatureView (12 fields) CC71C27413BAC50AC462E1B24A45228C/4D0F6FA5A352B3570A58BF8C94A2DD4F */
public record class TooltipBrickFeatureView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    MutableFeatureElements m_MutableElementsList /* NeedsAlign */,
    PPtr<GameObject> m_Background /* None */,
    PPtr<HorizontalLayoutGroup> m_HorizontalLayoutGroup /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<TextMeshProUGUI> m_Acronym /* None */,
    PPtr<GameObject> m_IconBlock /* None */,
    float m_DefaultFontSizeLabel /* None */,
    float m_DefaultConsoleFontSizeLabel /* None */)
{
    public static TooltipBrickFeatureView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MutableElementsList */
        MutableFeatureElements _m_MutableElementsList = MutableFeatureElements.Read(reader);
        PPtr<GameObject> _m_Background = PPtr<GameObject>.Read(reader);
        PPtr<HorizontalLayoutGroup> _m_HorizontalLayoutGroup = PPtr<HorizontalLayoutGroup>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Acronym = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_IconBlock = PPtr<GameObject>.Read(reader);
        float _m_DefaultFontSizeLabel = reader.ReadF32();
        float _m_DefaultConsoleFontSizeLabel = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MutableElementsList,
            _m_Background,
            _m_HorizontalLayoutGroup,
            _m_Icon,
            _m_Acronym,
            _m_IconBlock,
            _m_DefaultFontSizeLabel,
            _m_DefaultConsoleFontSizeLabel);
    }
}

