namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DOTweenAnimation (50 fields) B6F0B27C26A5739DD610BBFA0CAA1B3C/0BB897CFF35C2AE16DB221CBEBD4872B */
public record class DOTweenAnimation(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int updateType /* NeedsAlign */,
    byte isSpeedBased /* None */,
    byte hasOnStart /* NeedsAlign */,
    byte hasOnPlay /* NeedsAlign */,
    byte hasOnUpdate /* NeedsAlign */,
    byte hasOnStepComplete /* NeedsAlign */,
    byte hasOnComplete /* NeedsAlign */,
    byte hasOnTweenCreated /* NeedsAlign */,
    UnityEvent onStart /* NeedsAlign */,
    UnityEvent onPlay /* NeedsAlign */,
    UnityEvent onUpdate /* NeedsAlign */,
    UnityEvent onStepComplete /* NeedsAlign */,
    UnityEvent onComplete /* NeedsAlign */,
    UnityEvent onTweenCreated /* NeedsAlign */,
    float delay /* NeedsAlign */,
    float duration /* None */,
    int easeType /* None */,
    AnimationCurve easeCurve /* None */,
    int loopType /* NeedsAlign */,
    int loops /* None */,
    AsciiString id /* None */,
    byte isRelative /* NeedsAlign */,
    byte isFrom /* NeedsAlign */,
    byte isIndependentUpdate /* NeedsAlign */,
    byte autoKill /* NeedsAlign */,
    byte isActive /* NeedsAlign */,
    byte isValid /* NeedsAlign */,
    PPtr<Component> target /* NeedsAlign */,
    int animationType /* None */,
    int targetType /* None */,
    int forcedTargetType /* None */,
    byte autoPlay /* None */,
    byte useTargetAsV3 /* NeedsAlign */,
    float endValueFloat /* NeedsAlign */,
    Vector3f endValueV3 /* None */,
    Vector2f endValueV2 /* None */,
    ColorRGBA endValueColor /* None */,
    AsciiString endValueString /* None */,
    Rectf endValueRect /* NeedsAlign */,
    PPtr<Transform> endValueTransform /* None */,
    byte optionalBool0 /* None */,
    float optionalFloat0 /* NeedsAlign */,
    int optionalInt0 /* None */,
    int optionalRotationMode /* None */,
    int optionalScrambleMode /* None */,
    AsciiString optionalString /* None */)
{
    public static DOTweenAnimation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* updateType */
        int _updateType = reader.ReadS32();
        byte _isSpeedBased = reader.ReadU8();
        reader.AlignTo(4); /* hasOnStart */
        byte _hasOnStart = reader.ReadU8();
        reader.AlignTo(4); /* hasOnPlay */
        byte _hasOnPlay = reader.ReadU8();
        reader.AlignTo(4); /* hasOnUpdate */
        byte _hasOnUpdate = reader.ReadU8();
        reader.AlignTo(4); /* hasOnStepComplete */
        byte _hasOnStepComplete = reader.ReadU8();
        reader.AlignTo(4); /* hasOnComplete */
        byte _hasOnComplete = reader.ReadU8();
        reader.AlignTo(4); /* hasOnTweenCreated */
        byte _hasOnTweenCreated = reader.ReadU8();
        reader.AlignTo(4); /* onStart */
        UnityEvent _onStart = UnityEvent.Read(reader);
        reader.AlignTo(4); /* onPlay */
        UnityEvent _onPlay = UnityEvent.Read(reader);
        reader.AlignTo(4); /* onUpdate */
        UnityEvent _onUpdate = UnityEvent.Read(reader);
        reader.AlignTo(4); /* onStepComplete */
        UnityEvent _onStepComplete = UnityEvent.Read(reader);
        reader.AlignTo(4); /* onComplete */
        UnityEvent _onComplete = UnityEvent.Read(reader);
        reader.AlignTo(4); /* onTweenCreated */
        UnityEvent _onTweenCreated = UnityEvent.Read(reader);
        reader.AlignTo(4); /* delay */
        float _delay = reader.ReadF32();
        float _duration = reader.ReadF32();
        int _easeType = reader.ReadS32();
        AnimationCurve _easeCurve = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* loopType */
        int _loopType = reader.ReadS32();
        int _loops = reader.ReadS32();
        AsciiString _id = BuiltInString.Read(reader);
        reader.AlignTo(4); /* isRelative */
        byte _isRelative = reader.ReadU8();
        reader.AlignTo(4); /* isFrom */
        byte _isFrom = reader.ReadU8();
        reader.AlignTo(4); /* isIndependentUpdate */
        byte _isIndependentUpdate = reader.ReadU8();
        reader.AlignTo(4); /* autoKill */
        byte _autoKill = reader.ReadU8();
        reader.AlignTo(4); /* isActive */
        byte _isActive = reader.ReadU8();
        reader.AlignTo(4); /* isValid */
        byte _isValid = reader.ReadU8();
        reader.AlignTo(4); /* target */
        PPtr<Component> _target = PPtr<Component>.Read(reader);
        int _animationType = reader.ReadS32();
        int _targetType = reader.ReadS32();
        int _forcedTargetType = reader.ReadS32();
        byte _autoPlay = reader.ReadU8();
        reader.AlignTo(4); /* useTargetAsV3 */
        byte _useTargetAsV3 = reader.ReadU8();
        reader.AlignTo(4); /* endValueFloat */
        float _endValueFloat = reader.ReadF32();
        Vector3f _endValueV3 = Vector3f.Read(reader);
        Vector2f _endValueV2 = Vector2f.Read(reader);
        ColorRGBA _endValueColor = ColorRGBA.Read(reader);
        AsciiString _endValueString = BuiltInString.Read(reader);
        reader.AlignTo(4); /* endValueRect */
        Rectf _endValueRect = Rectf.Read(reader);
        PPtr<Transform> _endValueTransform = PPtr<Transform>.Read(reader);
        byte _optionalBool0 = reader.ReadU8();
        reader.AlignTo(4); /* optionalFloat0 */
        float _optionalFloat0 = reader.ReadF32();
        int _optionalInt0 = reader.ReadS32();
        int _optionalRotationMode = reader.ReadS32();
        int _optionalScrambleMode = reader.ReadS32();
        AsciiString _optionalString = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _updateType,
            _isSpeedBased,
            _hasOnStart,
            _hasOnPlay,
            _hasOnUpdate,
            _hasOnStepComplete,
            _hasOnComplete,
            _hasOnTweenCreated,
            _onStart,
            _onPlay,
            _onUpdate,
            _onStepComplete,
            _onComplete,
            _onTweenCreated,
            _delay,
            _duration,
            _easeType,
            _easeCurve,
            _loopType,
            _loops,
            _id,
            _isRelative,
            _isFrom,
            _isIndependentUpdate,
            _autoKill,
            _isActive,
            _isValid,
            _target,
            _animationType,
            _targetType,
            _forcedTargetType,
            _autoPlay,
            _useTargetAsV3,
            _endValueFloat,
            _endValueV3,
            _endValueV2,
            _endValueColor,
            _endValueString,
            _endValueRect,
            _endValueTransform,
            _optionalBool0,
            _optionalFloat0,
            _optionalInt0,
            _optionalRotationMode,
            _optionalScrambleMode,
            _optionalString);
    }
}

