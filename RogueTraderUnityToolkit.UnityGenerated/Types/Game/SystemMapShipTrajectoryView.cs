namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapShipTrajectoryView (7 fields) AC0FE0EFD6FB9EE78DEB76D7D2F82AEF/5A7E19CB88977C58AAD8FD86CE51EB9D */
public record class SystemMapShipTrajectoryView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_TargetPositionPoint /* NeedsAlign */,
    PPtr<CanvasGroup> m_TargetPingPositionPoint /* None */,
    Vector2f m_CorrectTargetPositionPoint /* None */)
{
    public static SystemMapShipTrajectoryView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TargetPositionPoint */
        PPtr<CanvasGroup> _m_TargetPositionPoint = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_TargetPingPositionPoint = PPtr<CanvasGroup>.Read(reader);
        Vector2f _m_CorrectTargetPositionPoint = Vector2f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TargetPositionPoint,
            _m_TargetPingPositionPoint,
            _m_CorrectTargetPositionPoint);
    }
}

