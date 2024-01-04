namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaPageBlockPlanetPCView (14 fields) 4F71C3D67C0298C463D65E6A6E535D68/A66AFEFA1C5764FE297B58285EB6466A */
public record class EncyclopediaPageBlockPlanetPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AdminKnowAboutIt /* None */,
    PPtr<TextMeshProUGUI> m_SystemName /* None */,
    PPtr<TextMeshProUGUI> m_IsColonized /* None */,
    PPtr<TextMeshProUGUI> m_Security /* None */,
    PPtr<TextMeshProUGUI> m_HaveQuest /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static EncyclopediaPageBlockPlanetPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AdminKnowAboutIt = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SystemName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_IsColonized = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Security = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HaveQuest = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeTitle = reader.ReadF32();
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSizeTitle = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_AdminKnowAboutIt,
            _m_SystemName,
            _m_IsColonized,
            _m_Security,
            _m_HaveQuest,
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSize);
    }
}

