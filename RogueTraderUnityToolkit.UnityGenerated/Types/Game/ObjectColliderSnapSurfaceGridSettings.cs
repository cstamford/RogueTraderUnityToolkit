namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectColliderSnapSurfaceGridSettings (6 fields) B77C695D1476ED324262F8DD5B301196/60627858D7EC9A4756E51E37B917A736 */
public record class ObjectColliderSnapSurfaceGridSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float _desiredCellSize /* NeedsAlign */,
    ObjectColliderSnapSurfaceGridSettingsView _view /* None */)
{
    public static ObjectColliderSnapSurfaceGridSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _desiredCellSize */
        float __desiredCellSize = reader.ReadF32();
        ObjectColliderSnapSurfaceGridSettingsView __view = ObjectColliderSnapSurfaceGridSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __desiredCellSize,
            __view);
    }
}

