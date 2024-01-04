namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipUpgradeStructureSlotConsoleView (13 fields) FAEE4CA5AD3A4CDEDEBD2EB64D7A2BED/371ADFA55533C4C82D31060159E01D80 */
public record class ShipUpgradeStructureSlotConsoleView(
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
    PPtr<TextMeshProUGUI> m_CurrentInternalStructureLevel /* None */,
    PPtr<GameObject> m_Hint /* None */,
    PPtr<TextMeshProUGUI> m_HintText /* None */)
{
    public static ShipUpgradeStructureSlotConsoleView Read(EndianBinaryReader reader)
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
        PPtr<TextMeshProUGUI> _m_CurrentInternalStructureLevel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_Hint = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintText = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _m_CurrentInternalStructureLevel,
            _m_Hint,
            _m_HintText);
    }
}

