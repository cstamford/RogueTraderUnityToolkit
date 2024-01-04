namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CompositeTrailRenderer (24 fields) 9F59893D7BD646F6D76B6B6B58BF7841/C4785F2EC58B79AFE7AD5E2C463549C5 */
public record class CompositeTrailRenderer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> Material /* NeedsAlign */,
    PPtr<Transform> ProbeAnchor /* None */,
    byte UseLightProbes /* None */,
    float Lifetime /* NeedsAlign */,
    int Alignment /* None */,
    int UvSpace /* None */,
    float m_MinVertexDistance /* None */,
    Vector3f PointVelocity /* None */,
    Gradient ColorOverLifetime /* None */,
    Gradient ColorOverLength /* NeedsAlign */,
    float MaxColorLenght /* NeedsAlign */,
    ColorRGBA MultiplyColor /* None */,
    float Width /* None */,
    AnimationCurve WidthOverLifetime /* None */,
    AnimationCurve WidthOverLength /* NeedsAlign */,
    float MaxLength /* NeedsAlign */,
    int OffsetCurveMode /* None */,
    Entry OffsetCurveRandom /* None */,
    CompositeAnimationCurve OffsetCurve /* None */,
    TrailEmitter[] Emitters /* NeedsAlign */)
{
    public static CompositeTrailRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Material */
        PPtr<Material> _Material = PPtr<Material>.Read(reader);
        PPtr<Transform> _ProbeAnchor = PPtr<Transform>.Read(reader);
        byte _UseLightProbes = reader.ReadU8();
        reader.AlignTo(4); /* Lifetime */
        float _Lifetime = reader.ReadF32();
        int _Alignment = reader.ReadS32();
        int _UvSpace = reader.ReadS32();
        float _m_MinVertexDistance = reader.ReadF32();
        Vector3f _PointVelocity = Vector3f.Read(reader);
        Gradient _ColorOverLifetime = Gradient.Read(reader);
        reader.AlignTo(4); /* ColorOverLength */
        Gradient _ColorOverLength = Gradient.Read(reader);
        reader.AlignTo(4); /* MaxColorLenght */
        float _MaxColorLenght = reader.ReadF32();
        ColorRGBA _MultiplyColor = ColorRGBA.Read(reader);
        float _Width = reader.ReadF32();
        AnimationCurve _WidthOverLifetime = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* WidthOverLength */
        AnimationCurve _WidthOverLength = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* MaxLength */
        float _MaxLength = reader.ReadF32();
        int _OffsetCurveMode = reader.ReadS32();
        Entry _OffsetCurveRandom = Entry.Read(reader);
        CompositeAnimationCurve _OffsetCurve = CompositeAnimationCurve.Read(reader);
        reader.AlignTo(4); /* Emitters */
        TrailEmitter[] _Emitters = BuiltInArray<TrailEmitter>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Material,
            _ProbeAnchor,
            _UseLightProbes,
            _Lifetime,
            _Alignment,
            _UvSpace,
            _m_MinVertexDistance,
            _PointVelocity,
            _ColorOverLifetime,
            _ColorOverLength,
            _MaxColorLenght,
            _MultiplyColor,
            _Width,
            _WidthOverLifetime,
            _WidthOverLength,
            _MaxLength,
            _OffsetCurveMode,
            _OffsetCurveRandom,
            _OffsetCurve,
            _Emitters);
    }
}

