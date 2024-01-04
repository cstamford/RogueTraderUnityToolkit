namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InteractableMirrorRenderSettings (13 fields) D703FB94C2B941DD0BD2233B4DE6FA39/29725AFACDC8647D6BCC05305384220D */
public record class InteractableMirrorRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA _mirrorPlaneColor /* NeedsAlign */,
    ColorRGBA _mirrorPlaneBorderLineColor /* None */,
    float _mirrorWidth /* None */,
    float _mirrorHeight /* None */,
    byte _useInfiniteWidth /* None */,
    byte _useInfiniteHeight /* NeedsAlign */,
    ColorRGBA _mirroredBoxColor /* NeedsAlign */,
    ColorRGBA _mirroredBoxBorderLineColor /* None */,
    InteractableMirrorRenderSettingsView _view /* None */)
{
    public static InteractableMirrorRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mirrorPlaneColor */
        ColorRGBA __mirrorPlaneColor = ColorRGBA.Read(reader);
        ColorRGBA __mirrorPlaneBorderLineColor = ColorRGBA.Read(reader);
        float __mirrorWidth = reader.ReadF32();
        float __mirrorHeight = reader.ReadF32();
        byte __useInfiniteWidth = reader.ReadU8();
        reader.AlignTo(4); /* _useInfiniteHeight */
        byte __useInfiniteHeight = reader.ReadU8();
        reader.AlignTo(4); /* _mirroredBoxColor */
        ColorRGBA __mirroredBoxColor = ColorRGBA.Read(reader);
        ColorRGBA __mirroredBoxBorderLineColor = ColorRGBA.Read(reader);
        InteractableMirrorRenderSettingsView __view = InteractableMirrorRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mirrorPlaneColor,
            __mirrorPlaneBorderLineColor,
            __mirrorWidth,
            __mirrorHeight,
            __useInfiniteWidth,
            __useInfiniteHeight,
            __mirroredBoxColor,
            __mirroredBoxBorderLineColor,
            __view);
    }
}

