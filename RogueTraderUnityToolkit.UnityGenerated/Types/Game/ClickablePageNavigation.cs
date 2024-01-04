namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ClickablePageNavigation (6 fields) 943FE341B1B9924E4F3E4A1306C77EA9/F6A8013926766E8A39A31A3296E9CE63 */
public record class ClickablePageNavigation(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ClickablePageNavigationEntity> m_PointPrefab /* NeedsAlign */,
    PPtr<Transform> m_PointsContainer /* None */)
{
    public static ClickablePageNavigation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PointPrefab */
        PPtr<ClickablePageNavigationEntity> _m_PointPrefab = PPtr<ClickablePageNavigationEntity>.Read(reader);
        PPtr<Transform> _m_PointsContainer = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PointPrefab,
            _m_PointsContainer);
    }
}

