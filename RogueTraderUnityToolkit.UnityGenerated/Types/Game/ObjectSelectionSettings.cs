namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelectionSettings (16 fields) 25ADC91735B211E20AEF5B08DC1D98A3/B97A42651B4FB997B1620426BA77CE49 */
public record class ObjectSelectionSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _selectionShapeType /* NeedsAlign */,
    int _selectionMode /* None */,
    int _selectionUpdateMode /* None */,
    SelectionObjectGroupSettings _objectGroupSettings /* None */,
    SelectionObject2ObjectSnapSettings _object2ObjectSnapSettings /* NeedsAlign */,
    float _xRotationStep /* NeedsAlign */,
    float _yRotationStep /* None */,
    float _zRotationStep /* None */,
    byte _rotateAroundSelectionCenter /* None */,
    byte _allowPartialOverlap /* NeedsAlign */,
    PPtr<ObjectSelectionPaintModeSettings> _paintModeSettings /* NeedsAlign */,
    ObjectSelectionSettingsView _view /* None */)
{
    public static ObjectSelectionSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _selectionShapeType */
        int __selectionShapeType = reader.ReadS32();
        int __selectionMode = reader.ReadS32();
        int __selectionUpdateMode = reader.ReadS32();
        SelectionObjectGroupSettings __objectGroupSettings = SelectionObjectGroupSettings.Read(reader);
        reader.AlignTo(4); /* _object2ObjectSnapSettings */
        SelectionObject2ObjectSnapSettings __object2ObjectSnapSettings = SelectionObject2ObjectSnapSettings.Read(reader);
        reader.AlignTo(4); /* _xRotationStep */
        float __xRotationStep = reader.ReadF32();
        float __yRotationStep = reader.ReadF32();
        float __zRotationStep = reader.ReadF32();
        byte __rotateAroundSelectionCenter = reader.ReadU8();
        reader.AlignTo(4); /* _allowPartialOverlap */
        byte __allowPartialOverlap = reader.ReadU8();
        reader.AlignTo(4); /* _paintModeSettings */
        PPtr<ObjectSelectionPaintModeSettings> __paintModeSettings = PPtr<ObjectSelectionPaintModeSettings>.Read(reader);
        ObjectSelectionSettingsView __view = ObjectSelectionSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __selectionShapeType,
            __selectionMode,
            __selectionUpdateMode,
            __objectGroupSettings,
            __object2ObjectSnapSettings,
            __xRotationStep,
            __yRotationStep,
            __zRotationStep,
            __rotateAroundSelectionCenter,
            __allowPartialOverlap,
            __paintModeSettings,
            __view);
    }
}

