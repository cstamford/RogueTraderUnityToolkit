namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAttributesPhasePantographItemConsoleView (13 fields) 78C409989D6CD4A0F47F9C7F0B98EE3D/71CBCA9BCA2C0581B956434830A85F74 */
public record class CharGenAttributesPhasePantographItemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<ScrambledTMP> m_DisplayName /* None */,
    PPtr<CharGenAttributesPhasePantographItemRankWidget> m_RankWidget /* None */,
    PPtr<RectTransform> m_RanksContainer /* None */,
    PPtr<ScrambledTMP> m_StatValue /* None */,
    PPtr<ScrambledTMP> m_ShortLabel /* None */,
    PPtr<Image> m_StatImage /* None */,
    PPtr<ConsoleHint> m_MinusHint /* None */,
    PPtr<ConsoleHint> m_PlusHint /* None */)
{
    public static CharGenAttributesPhasePantographItemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<ScrambledTMP> _m_DisplayName = PPtr<ScrambledTMP>.Read(reader);
        PPtr<CharGenAttributesPhasePantographItemRankWidget> _m_RankWidget = PPtr<CharGenAttributesPhasePantographItemRankWidget>.Read(reader);
        PPtr<RectTransform> _m_RanksContainer = PPtr<RectTransform>.Read(reader);
        PPtr<ScrambledTMP> _m_StatValue = PPtr<ScrambledTMP>.Read(reader);
        PPtr<ScrambledTMP> _m_ShortLabel = PPtr<ScrambledTMP>.Read(reader);
        PPtr<Image> _m_StatImage = PPtr<Image>.Read(reader);
        PPtr<ConsoleHint> _m_MinusHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PlusHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_DisplayName,
            _m_RankWidget,
            _m_RanksContainer,
            _m_StatValue,
            _m_ShortLabel,
            _m_StatImage,
            _m_MinusHint,
            _m_PlusHint);
    }
}

