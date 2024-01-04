namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootMainPagePCView (6 fields) 43900FD41BB94F73060C04BE11DAF492/E4702CE3073DD9BA2D5F587A05A8A9B9 */
public record class StatCheckLootMainPagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<StatCheckLootUnitCardPCView>[] m_UnitCardSlots /* NeedsAlign */,
    PPtr<OwlcatButton> m_CloseButton /* None */)
{
    public static StatCheckLootMainPagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UnitCardSlots */
        PPtr<StatCheckLootUnitCardPCView>[] _m_UnitCardSlots = BuiltInArray<PPtr<StatCheckLootUnitCardPCView>>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitCardSlots,
            _m_CloseButton);
    }
}

