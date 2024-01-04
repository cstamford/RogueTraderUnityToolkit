namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPivotPointsRenderSettings (8 fields) 6E7D63113193F560DDDCBD35CC47450D/08374A75AC268093DD5D42CAB31E33A0 */
public record class ObjectPivotPointsRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _shapeType /* NeedsAlign */,
    float _pivotPointSizeInPixels /* None */,
    PPtr<ProjectedBoxFacePivotPointsRenderSettings> _projectedBoxFacePivotPointsRenderSettings /* None */,
    ObjectPivotPointsRenderSettingsView _view /* None */)
{
    public static ObjectPivotPointsRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _shapeType */
        int __shapeType = reader.ReadS32();
        float __pivotPointSizeInPixels = reader.ReadF32();
        PPtr<ProjectedBoxFacePivotPointsRenderSettings> __projectedBoxFacePivotPointsRenderSettings = PPtr<ProjectedBoxFacePivotPointsRenderSettings>.Read(reader);
        ObjectPivotPointsRenderSettingsView __view = ObjectPivotPointsRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __shapeType,
            __pivotPointSizeInPixels,
            __projectedBoxFacePivotPointsRenderSettings,
            __view);
    }
}

