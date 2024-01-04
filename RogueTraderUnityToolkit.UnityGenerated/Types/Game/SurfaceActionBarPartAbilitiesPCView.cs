namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPartAbilitiesPCView (9 fields) 16B88064F5EDE965360A91E43AE23A21/11DF58BD5C7D20E9F2D6DB5877E74B61 */
public record class SurfaceActionBarPartAbilitiesPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_TooltipPlace /* NeedsAlign */,
    PPtr<OwlcatButton> m_CharacterButton /* None */,
    PPtr<SurfaceActionBarAbilitiesRowView> m_SurfaceActionBarAbilitiesViewRowPrefab /* None */,
    PPtr<Transform> m_RowsContainer /* None */,
    PPtr<SurfaceActionBarSlotAbilityPCView> m_SlotPCView /* None */)
{
    public static SurfaceActionBarPartAbilitiesPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipPlace */
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatButton> _m_CharacterButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<SurfaceActionBarAbilitiesRowView> _m_SurfaceActionBarAbilitiesViewRowPrefab = PPtr<SurfaceActionBarAbilitiesRowView>.Read(reader);
        PPtr<Transform> _m_RowsContainer = PPtr<Transform>.Read(reader);
        PPtr<SurfaceActionBarSlotAbilityPCView> _m_SlotPCView = PPtr<SurfaceActionBarSlotAbilityPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipPlace,
            _m_CharacterButton,
            _m_SurfaceActionBarAbilitiesViewRowPrefab,
            _m_RowsContainer,
            _m_SlotPCView);
    }
}

