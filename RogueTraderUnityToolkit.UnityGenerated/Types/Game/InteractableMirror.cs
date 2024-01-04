namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InteractableMirror (16 fields) FE8DDF732FB9F819BF4F2F4C0C5CB4C1/CEB24105F6639A2BF3AA66C3C41A79B6 */
public record class InteractableMirror(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> _sessionMirrorObject /* NeedsAlign */,
    PPtr<Transform> _sessionMirrorObjectTransform /* None */,
    Mirror _mirror /* None */,
    TransformMatrix _mirrorTransformMatrix /* None */,
    byte _isActive /* None */,
    byte _alignToSurface /* NeedsAlign */,
    byte _mirrorRotation /* NeedsAlign */,
    byte _mirrorSpanningObjects /* NeedsAlign */,
    byte _allowIntersectionForMirroredObjects /* NeedsAlign */,
    PPtr<InteractableMirrorSettings> _settings /* NeedsAlign */,
    PPtr<InteractableMirrorRenderSettings> _renderSettings /* None */,
    InteractableMirrorView _view /* None */)
{
    public static InteractableMirror Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _sessionMirrorObject */
        PPtr<GameObject> __sessionMirrorObject = PPtr<GameObject>.Read(reader);
        PPtr<Transform> __sessionMirrorObjectTransform = PPtr<Transform>.Read(reader);
        Mirror __mirror = Mirror.Read(reader);
        TransformMatrix __mirrorTransformMatrix = TransformMatrix.Read(reader);
        byte __isActive = reader.ReadU8();
        reader.AlignTo(4); /* _alignToSurface */
        byte __alignToSurface = reader.ReadU8();
        reader.AlignTo(4); /* _mirrorRotation */
        byte __mirrorRotation = reader.ReadU8();
        reader.AlignTo(4); /* _mirrorSpanningObjects */
        byte __mirrorSpanningObjects = reader.ReadU8();
        reader.AlignTo(4); /* _allowIntersectionForMirroredObjects */
        byte __allowIntersectionForMirroredObjects = reader.ReadU8();
        reader.AlignTo(4); /* _settings */
        PPtr<InteractableMirrorSettings> __settings = PPtr<InteractableMirrorSettings>.Read(reader);
        PPtr<InteractableMirrorRenderSettings> __renderSettings = PPtr<InteractableMirrorRenderSettings>.Read(reader);
        InteractableMirrorView __view = InteractableMirrorView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __sessionMirrorObject,
            __sessionMirrorObjectTransform,
            __mirror,
            __mirrorTransformMatrix,
            __isActive,
            __alignToSurface,
            __mirrorRotation,
            __mirrorSpanningObjects,
            __allowIntersectionForMirroredObjects,
            __settings,
            __renderSettings,
            __view);
    }
}

