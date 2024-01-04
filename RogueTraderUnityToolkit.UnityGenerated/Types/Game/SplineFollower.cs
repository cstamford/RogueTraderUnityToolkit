namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SplineFollower (44 fields) 77B4E4DF4EB4312A1BD4BF922E47D947/50F5830506C6CF958D7B260CBFBB7BDD */
public record class SplineFollower(
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
    byte applyDirectionRotation /* NeedsAlign */,
    byte useTriggers /* NeedsAlign */,
    int triggerGroup /* NeedsAlign */,
    int _direction /* None */,
    byte _dontLerpDirection /* None */,
    int _physicsMode /* NeedsAlign */,
    TransformModule _motion /* None */,
    PPtr<Rigidbody> targetRigidbody /* NeedsAlign */,
    PPtr<Rigidbody2D> targetRigidbody2D /* None */,
    PPtr<Transform> targetTransform /* None */,
    SplineSample _result /* None */,
    SplineSample _finalResult /* None */,
    int wrapMode /* None */,
    int followMode /* None */,
    byte autoStartPosition /* None */,
    byte _follow /* NeedsAlign */,
    double _startPosition /* NeedsAlign */,
    byte preserveUniformSpeedWithOffset /* None */,
    float _followSpeed /* NeedsAlign */,
    float _followDuration /* None */,
    FollowerSpeedModifier _speedModifier /* None */,
    FloatEvent _unityOnEndReached /* NeedsAlign */,
    FloatEvent _unityOnBeginningReached /* NeedsAlign */)
{
    public static SplineFollower Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* applyDirectionRotation */
        byte _applyDirectionRotation = reader.ReadU8();
        reader.AlignTo(4); /* useTriggers */
        byte _useTriggers = reader.ReadU8();
        reader.AlignTo(4); /* triggerGroup */
        int _triggerGroup = reader.ReadS32();
        int __direction = reader.ReadS32();
        byte __dontLerpDirection = reader.ReadU8();
        reader.AlignTo(4); /* _physicsMode */
        int __physicsMode = reader.ReadS32();
        TransformModule __motion = TransformModule.Read(reader);
        reader.AlignTo(4); /* targetRigidbody */
        PPtr<Rigidbody> _targetRigidbody = PPtr<Rigidbody>.Read(reader);
        PPtr<Rigidbody2D> _targetRigidbody2D = PPtr<Rigidbody2D>.Read(reader);
        PPtr<Transform> _targetTransform = PPtr<Transform>.Read(reader);
        SplineSample __result = SplineSample.Read(reader);
        SplineSample __finalResult = SplineSample.Read(reader);
        int _wrapMode = reader.ReadS32();
        int _followMode = reader.ReadS32();
        byte _autoStartPosition = reader.ReadU8();
        reader.AlignTo(4); /* _follow */
        byte __follow = reader.ReadU8();
        reader.AlignTo(4); /* _startPosition */
        double __startPosition = reader.ReadF64();
        byte _preserveUniformSpeedWithOffset = reader.ReadU8();
        reader.AlignTo(4); /* _followSpeed */
        float __followSpeed = reader.ReadF32();
        float __followDuration = reader.ReadF32();
        FollowerSpeedModifier __speedModifier = FollowerSpeedModifier.Read(reader);
        reader.AlignTo(4); /* _unityOnEndReached */
        FloatEvent __unityOnEndReached = FloatEvent.Read(reader);
        reader.AlignTo(4); /* _unityOnBeginningReached */
        FloatEvent __unityOnBeginningReached = FloatEvent.Read(reader);
        
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
            _applyDirectionRotation,
            _useTriggers,
            _triggerGroup,
            __direction,
            __dontLerpDirection,
            __physicsMode,
            __motion,
            _targetRigidbody,
            _targetRigidbody2D,
            _targetTransform,
            __result,
            __finalResult,
            _wrapMode,
            _followMode,
            _autoStartPosition,
            __follow,
            __startPosition,
            _preserveUniformSpeedWithOffset,
            __followSpeed,
            __followDuration,
            __speedModifier,
            __unityOnEndReached,
            __unityOnBeginningReached);
    }
}

