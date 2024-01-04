namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BlockObjectPlacementSettings (6 fields) F8B4B63BCE673A6A8A8FEDA38BA1B49E/BDFD73267D3C5F47D1CD152EF89FDFBE */
public record class BlockObjectPlacementSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AxisAlignmentSettings> _placementGuideSurfaceAlignmentSettings /* NeedsAlign */,
    BlockObjectPlacementSettingsView _view /* None */)
{
    public static BlockObjectPlacementSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _placementGuideSurfaceAlignmentSettings */
        PPtr<AxisAlignmentSettings> __placementGuideSurfaceAlignmentSettings = PPtr<AxisAlignmentSettings>.Read(reader);
        BlockObjectPlacementSettingsView __view = BlockObjectPlacementSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __placementGuideSurfaceAlignmentSettings,
            __view);
    }
}

