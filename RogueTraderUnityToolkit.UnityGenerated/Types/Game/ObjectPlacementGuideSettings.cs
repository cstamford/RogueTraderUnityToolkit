namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementGuideSettings (9 fields) D3C7A366F9729410DC63E2FF574138D1/713DE3D785CC3868C75D60D783143192 */
public record class ObjectPlacementGuideSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectMouseMoveAlongDirectionSettings> _mouseOffsetFromPlacementSurfaceSettings /* NeedsAlign */,
    PPtr<ObjectKeyboardRotationSettings> _keyboardRotationSettings /* None */,
    PPtr<ObjectMouseRotationSettings> _mouseRotationSettings /* None */,
    PPtr<ObjectMouseUniformScaleSettings> _mouseUniformScaleSettings /* None */,
    ObjectPlacementGuideSettingsView _view /* None */)
{
    public static ObjectPlacementGuideSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mouseOffsetFromPlacementSurfaceSettings */
        PPtr<ObjectMouseMoveAlongDirectionSettings> __mouseOffsetFromPlacementSurfaceSettings = PPtr<ObjectMouseMoveAlongDirectionSettings>.Read(reader);
        PPtr<ObjectKeyboardRotationSettings> __keyboardRotationSettings = PPtr<ObjectKeyboardRotationSettings>.Read(reader);
        PPtr<ObjectMouseRotationSettings> __mouseRotationSettings = PPtr<ObjectMouseRotationSettings>.Read(reader);
        PPtr<ObjectMouseUniformScaleSettings> __mouseUniformScaleSettings = PPtr<ObjectMouseUniformScaleSettings>.Read(reader);
        ObjectPlacementGuideSettingsView __view = ObjectPlacementGuideSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mouseOffsetFromPlacementSurfaceSettings,
            __keyboardRotationSettings,
            __mouseRotationSettings,
            __mouseUniformScaleSettings,
            __view);
    }
}

