namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSnapSettings (14 fields) 906FD367B92C79BC0325DE4D65C383A0/CBF405A30FDFDA0D82380B783F0E98C5 */
public record class ObjectSnapSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _useOriginalPivot /* NeedsAlign */,
    byte _enableObjectSurfaceGrid /* NeedsAlign */,
    byte _snapToCursorHitPoint /* NeedsAlign */,
    byte _snapCenterToCenterForXZGrid /* NeedsAlign */,
    byte _snapCenterToCenterForObjectSurface /* NeedsAlign */,
    byte _enableObjectToObjectSnap /* NeedsAlign */,
    float _objectToObjectSnapEpsilon /* NeedsAlign */,
    float _xzGridYOffsetStep /* None */,
    PPtr<ObjectColliderSnapSurfaceGridSettings> _objectColliderSnapSurfaceGridSettings /* None */,
    ObjectSnapSettingsView _view /* None */)
{
    public static ObjectSnapSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _useOriginalPivot */
        byte __useOriginalPivot = reader.ReadU8();
        reader.AlignTo(4); /* _enableObjectSurfaceGrid */
        byte __enableObjectSurfaceGrid = reader.ReadU8();
        reader.AlignTo(4); /* _snapToCursorHitPoint */
        byte __snapToCursorHitPoint = reader.ReadU8();
        reader.AlignTo(4); /* _snapCenterToCenterForXZGrid */
        byte __snapCenterToCenterForXZGrid = reader.ReadU8();
        reader.AlignTo(4); /* _snapCenterToCenterForObjectSurface */
        byte __snapCenterToCenterForObjectSurface = reader.ReadU8();
        reader.AlignTo(4); /* _enableObjectToObjectSnap */
        byte __enableObjectToObjectSnap = reader.ReadU8();
        reader.AlignTo(4); /* _objectToObjectSnapEpsilon */
        float __objectToObjectSnapEpsilon = reader.ReadF32();
        float __xzGridYOffsetStep = reader.ReadF32();
        PPtr<ObjectColliderSnapSurfaceGridSettings> __objectColliderSnapSurfaceGridSettings = PPtr<ObjectColliderSnapSurfaceGridSettings>.Read(reader);
        ObjectSnapSettingsView __view = ObjectSnapSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __useOriginalPivot,
            __enableObjectSurfaceGrid,
            __snapToCursorHitPoint,
            __snapCenterToCenterForXZGrid,
            __snapCenterToCenterForObjectSurface,
            __enableObjectToObjectSnap,
            __objectToObjectSnapEpsilon,
            __xzGridYOffsetStep,
            __objectColliderSnapSurfaceGridSettings,
            __view);
    }
}

