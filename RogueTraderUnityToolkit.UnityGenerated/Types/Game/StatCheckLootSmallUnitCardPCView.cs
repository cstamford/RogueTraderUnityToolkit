namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootSmallUnitCardPCView (8 fields) AB40F266E4475B8C39577A980549C9F7/C3E4932FE66FC0495ABD2FA6779A77E6 */
public record class StatCheckLootSmallUnitCardPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_UnitNameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_StatValueLabel /* None */,
    PPtr<Image> m_UnitPortraitImage /* None */,
    PPtr<OwlcatToggle> m_SelectUnitToggle /* None */)
{
    public static StatCheckLootSmallUnitCardPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UnitNameLabel */
        PPtr<TextMeshProUGUI> _m_UnitNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatValueLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_UnitPortraitImage = PPtr<Image>.Read(reader);
        PPtr<OwlcatToggle> _m_SelectUnitToggle = PPtr<OwlcatToggle>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitNameLabel,
            _m_StatValueLabel,
            _m_UnitPortraitImage,
            _m_SelectUnitToggle);
    }
}

