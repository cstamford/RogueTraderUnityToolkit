namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipUpgradeProwRamSlotPCView (11 fields) D204D01C7DB3785257BDDD47F09554FA/A4DC003A3010C2B95CFF65A2FDDE600B */
public record class ShipUpgradeProwRamSlotPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* NeedsAlign */,
    PPtr<Image> m_CanUpgrade /* None */,
    PPtr<CanvasGroup> m_LinesBlock /* None */,
    PPtr<GameObject>[] m_ShipLines /* None */,
    PPtr<Sprite> m_Upgrade /* None */,
    PPtr<Sprite> m_Downgrade /* None */,
    PPtr<TextMeshProUGUI> m_CurrentProwRamLevel /* None */)
{
    public static ShipUpgradeProwRamSlotPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MultiButton */
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_CanUpgrade = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_LinesBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<GameObject>[] _m_ShipLines = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<Sprite> _m_Upgrade = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_Downgrade = PPtr<Sprite>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentProwRamLevel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MultiButton,
            _m_CanUpgrade,
            _m_LinesBlock,
            _m_ShipLines,
            _m_Upgrade,
            _m_Downgrade,
            _m_CurrentProwRamLevel);
    }
}

