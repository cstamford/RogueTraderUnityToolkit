namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SplineRenderer (43 fields) A688906FEBED8BEAE772AAA66E27A4D7/348493CB39AB6578B476E208B7D9E3B1 */
public record class SplineRenderer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int updateMethod /* NeedsAlign */,
    PPtr<SplineComputer> _spline /* None */,
    byte _autoUpdate /* None */,
    RotationModifier _rotationModifier /* NeedsAlign */,
    OffsetModifier _offsetModifier /* NeedsAlign */,
    ColorModifier _colorModifier /* NeedsAlign */,
    SizeModifier _sizeModifier /* NeedsAlign */,
    SplineSample _clipFromSample /* NeedsAlign */,
    SplineSample _clipToSample /* None */,
    byte _loopSamples /* None */,
    double _clipFrom /* NeedsAlign */,
    double _clipTo /* None */,
    float animClipFrom /* None */,
    float animClipTo /* None */,
    byte multithreaded /* None */,
    byte buildOnAwake /* NeedsAlign */,
    byte buildOnEnable /* NeedsAlign */,
    byte _baked /* NeedsAlign */,
    byte _markDynamic /* NeedsAlign */,
    float _size /* NeedsAlign */,
    ColorRGBA _color /* None */,
    Vector3f _offset /* None */,
    int _normalMethod /* None */,
    byte _calculateTangents /* None */,
    byte _useSplineSize /* NeedsAlign */,
    byte _useSplineColor /* NeedsAlign */,
    float _rotation /* NeedsAlign */,
    byte _flipFaces /* None */,
    byte _doubleSided /* NeedsAlign */,
    int _uvMode /* NeedsAlign */,
    Vector2f _uvScale /* None */,
    Vector2f _uvOffset /* None */,
    float _uvRotation /* None */,
    int _meshIndexFormat /* None */,
    PPtr<Mesh> _bakedMesh /* None */,
    float colliderUpdateRate /* None */,
    byte autoOrient /* None */,
    int updateFrameInterval /* NeedsAlign */,
    int _slices /* None */)
{
    public static SplineRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* updateMethod */
        int _updateMethod = reader.ReadS32();
        PPtr<SplineComputer> __spline = PPtr<SplineComputer>.Read(reader);
        byte __autoUpdate = reader.ReadU8();
        reader.AlignTo(4); /* _rotationModifier */
        RotationModifier __rotationModifier = RotationModifier.Read(reader);
        reader.AlignTo(4); /* _offsetModifier */
        OffsetModifier __offsetModifier = OffsetModifier.Read(reader);
        reader.AlignTo(4); /* _colorModifier */
        ColorModifier __colorModifier = ColorModifier.Read(reader);
        reader.AlignTo(4); /* _sizeModifier */
        SizeModifier __sizeModifier = SizeModifier.Read(reader);
        reader.AlignTo(4); /* _clipFromSample */
        SplineSample __clipFromSample = SplineSample.Read(reader);
        SplineSample __clipToSample = SplineSample.Read(reader);
        byte __loopSamples = reader.ReadU8();
        reader.AlignTo(4); /* _clipFrom */
        double __clipFrom = reader.ReadF64();
        double __clipTo = reader.ReadF64();
        float _animClipFrom = reader.ReadF32();
        float _animClipTo = reader.ReadF32();
        byte _multithreaded = reader.ReadU8();
        reader.AlignTo(4); /* buildOnAwake */
        byte _buildOnAwake = reader.ReadU8();
        reader.AlignTo(4); /* buildOnEnable */
        byte _buildOnEnable = reader.ReadU8();
        reader.AlignTo(4); /* _baked */
        byte __baked = reader.ReadU8();
        reader.AlignTo(4); /* _markDynamic */
        byte __markDynamic = reader.ReadU8();
        reader.AlignTo(4); /* _size */
        float __size = reader.ReadF32();
        ColorRGBA __color = ColorRGBA.Read(reader);
        Vector3f __offset = Vector3f.Read(reader);
        int __normalMethod = reader.ReadS32();
        byte __calculateTangents = reader.ReadU8();
        reader.AlignTo(4); /* _useSplineSize */
        byte __useSplineSize = reader.ReadU8();
        reader.AlignTo(4); /* _useSplineColor */
        byte __useSplineColor = reader.ReadU8();
        reader.AlignTo(4); /* _rotation */
        float __rotation = reader.ReadF32();
        byte __flipFaces = reader.ReadU8();
        reader.AlignTo(4); /* _doubleSided */
        byte __doubleSided = reader.ReadU8();
        reader.AlignTo(4); /* _uvMode */
        int __uvMode = reader.ReadS32();
        Vector2f __uvScale = Vector2f.Read(reader);
        Vector2f __uvOffset = Vector2f.Read(reader);
        float __uvRotation = reader.ReadF32();
        int __meshIndexFormat = reader.ReadS32();
        PPtr<Mesh> __bakedMesh = PPtr<Mesh>.Read(reader);
        float _colliderUpdateRate = reader.ReadF32();
        byte _autoOrient = reader.ReadU8();
        reader.AlignTo(4); /* updateFrameInterval */
        int _updateFrameInterval = reader.ReadS32();
        int __slices = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _updateMethod,
            __spline,
            __autoUpdate,
            __rotationModifier,
            __offsetModifier,
            __colorModifier,
            __sizeModifier,
            __clipFromSample,
            __clipToSample,
            __loopSamples,
            __clipFrom,
            __clipTo,
            _animClipFrom,
            _animClipTo,
            _multithreaded,
            _buildOnAwake,
            _buildOnEnable,
            __baked,
            __markDynamic,
            __size,
            __color,
            __offset,
            __normalMethod,
            __calculateTangents,
            __useSplineSize,
            __useSplineColor,
            __rotation,
            __flipFaces,
            __doubleSided,
            __uvMode,
            __uvScale,
            __uvOffset,
            __uvRotation,
            __meshIndexFormat,
            __bakedMesh,
            _colliderUpdateRate,
            _autoOrient,
            _updateFrameInterval,
            __slices);
    }
}

