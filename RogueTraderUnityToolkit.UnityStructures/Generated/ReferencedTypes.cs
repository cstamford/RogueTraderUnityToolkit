namespace RogueTraderUnityToolkit.UnityStructures.Generated;

using Core;
using Unity.BuiltInTypes;
using Engine;

/* $AssetInfo (3 fields) (None) */
public record class AssetInfo(
    int preloadIndex,
    int preloadSize,
    PPtr<Object> asset)
{
    public static AssetInfo Read(EndianBinaryReader reader)
    {
        int preloadIndex = reader.ReadS32();
        int preloadSize = reader.ReadS32();
        PPtr<Object> asset = PPtr<Object>.Read(reader);
        
        return new(preloadIndex,
            preloadSize,
            asset);
    }
}

/* $Vector2f (2 fields) (None) */
public readonly record struct Vector2f(
    float x,
    float y)
{
    public static Vector2f Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        
        return new(x,
            y);
    }
}

/* $UnityTexEnv (3 fields) (None) */
public record class UnityTexEnv(
    PPtr<Texture> m_Texture,
    Vector2f m_Scale,
    Vector2f m_Offset)
{
    public static UnityTexEnv Read(EndianBinaryReader reader)
    {
        PPtr<Texture> m_Texture = PPtr<Texture>.Read(reader);
        Vector2f m_Scale = Vector2f.Read(reader);
        Vector2f m_Offset = Vector2f.Read(reader);
        
        return new(m_Texture,
            m_Scale,
            m_Offset);
    }
}

/* $ColorRGBA (4 fields) (None) */
public readonly record struct ColorRGBA(
    float r,
    float g,
    float b,
    float a)
{
    public static ColorRGBA Read(EndianBinaryReader reader)
    {
        float r = reader.ReadF32();
        float g = reader.ReadF32();
        float b = reader.ReadF32();
        float a = reader.ReadF32();
        
        return new(r,
            g,
            b,
            a);
    }
}

/* $UnityPropertySheet (4 fields) (None) */
public record class UnityPropertySheet(
    Dictionary<AsciiString, UnityTexEnv> m_TexEnvs,
    Dictionary<AsciiString, int> m_Ints,
    Dictionary<AsciiString, float> m_Floats,
    Dictionary<AsciiString, ColorRGBA> m_Colors)
{
    public static UnityPropertySheet Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, UnityTexEnv> m_TexEnvs = Map<AsciiString, UnityTexEnv>.Read(reader);
        Dictionary<AsciiString, int> m_Ints = Map<AsciiString, int>.Read(reader);
        Dictionary<AsciiString, float> m_Floats = Map<AsciiString, float>.Read(reader);
        Dictionary<AsciiString, ColorRGBA> m_Colors = Map<AsciiString, ColorRGBA>.Read(reader);
        
        return new(m_TexEnvs,
            m_Ints,
            m_Floats,
            m_Colors);
    }
}

/* $BuildTextureStackReference (2 fields) (None) */
public record class BuildTextureStackReference(
    AsciiString groupName,
    AsciiString itemName)
{
    public static BuildTextureStackReference Read(EndianBinaryReader reader)
    {
        AsciiString groupName = String.Read(reader);
        AsciiString itemName = String.Read(reader);
        
        return new(groupName,
            itemName);
    }
}

/* $Quaternionf (4 fields) (None) */
public readonly record struct Quaternionf(
    float x,
    float y,
    float z,
    float w)
{
    public static Quaternionf Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        float z = reader.ReadF32();
        float w = reader.ReadF32();
        
        return new(x,
            y,
            z,
            w);
    }
}

/* $Keyframe (7 fields) (None) */
public record class Keyframe(
    float time,
    Quaternionf @value,
    Quaternionf inSlope,
    Quaternionf outSlope,
    int weightedMode,
    Quaternionf inWeight,
    Quaternionf outWeight)
{
    public static Keyframe Read(EndianBinaryReader reader)
    {
        float time = reader.ReadF32();
        Quaternionf @value = Quaternionf.Read(reader);
        Quaternionf inSlope = Quaternionf.Read(reader);
        Quaternionf outSlope = Quaternionf.Read(reader);
        int weightedMode = reader.ReadS32();
        Quaternionf inWeight = Quaternionf.Read(reader);
        Quaternionf outWeight = Quaternionf.Read(reader);
        
        return new(time,
            @value,
            inSlope,
            outSlope,
            weightedMode,
            inWeight,
            outWeight);
    }
}

/* $AnimationCurve (4 fields) (None) */
public record class AnimationCurve(
    Keyframe[] m_Curve,
    int m_PreInfinity,
    int m_PostInfinity,
    int m_RotationOrder)
{
    public static AnimationCurve Read(EndianBinaryReader reader)
    {
        Keyframe[] m_Curve = Array<Keyframe>.Read(reader);
        int m_PreInfinity = reader.ReadS32();
        int m_PostInfinity = reader.ReadS32();
        int m_RotationOrder = reader.ReadS32();
        
        return new(m_Curve,
            m_PreInfinity,
            m_PostInfinity,
            m_RotationOrder);
    }
}

/* $QuaternionCurve (2 fields) (None) */
public record class QuaternionCurve(
    AnimationCurve curve,
    AsciiString path)
{
    public static QuaternionCurve Read(EndianBinaryReader reader)
    {
        AnimationCurve curve = AnimationCurve.Read(reader);
        AsciiString path = String.Read(reader);
        
        return new(curve,
            path);
    }
}

/* $PackedBitVector (3 fields) (None) */
public record class PackedBitVector(
    uint m_NumItems,
    byte[] m_Data,
    byte m_BitSize)
{
    public static PackedBitVector Read(EndianBinaryReader reader)
    {
        uint m_NumItems = reader.ReadU32();
        byte[] m_Data = Array<byte>.Read(reader);
        byte m_BitSize = reader.ReadU8();
        
        return new(m_NumItems,
            m_Data,
            m_BitSize);
    }
}

/* $CompressedAnimationCurve (6 fields) (None) */
public record class CompressedAnimationCurve(
    AsciiString m_Path,
    PackedBitVector m_Times,
    PackedBitVector m_Values,
    PackedBitVector m_Slopes,
    int m_PreInfinity,
    int m_PostInfinity)
{
    public static CompressedAnimationCurve Read(EndianBinaryReader reader)
    {
        AsciiString m_Path = String.Read(reader);
        PackedBitVector m_Times = PackedBitVector.Read(reader);
        PackedBitVector m_Values = PackedBitVector.Read(reader);
        PackedBitVector m_Slopes = PackedBitVector.Read(reader);
        int m_PreInfinity = reader.ReadS32();
        int m_PostInfinity = reader.ReadS32();
        
        return new(m_Path,
            m_Times,
            m_Values,
            m_Slopes,
            m_PreInfinity,
            m_PostInfinity);
    }
}

/* $Vector3Curve (2 fields) (None) */
public record class Vector3Curve(
    AnimationCurve curve,
    AsciiString path)
{
    public static Vector3Curve Read(EndianBinaryReader reader)
    {
        AnimationCurve curve = AnimationCurve.Read(reader);
        AsciiString path = String.Read(reader);
        
        return new(curve,
            path);
    }
}

/* $FloatCurve (6 fields) (None) */
public record class FloatCurve(
    AnimationCurve curve,
    AsciiString attribute,
    AsciiString path,
    int classID,
    PPtr<MonoScript> script,
    int flags)
{
    public static FloatCurve Read(EndianBinaryReader reader)
    {
        AnimationCurve curve = AnimationCurve.Read(reader);
        AsciiString attribute = String.Read(reader);
        AsciiString path = String.Read(reader);
        int classID = reader.ReadS32();
        PPtr<MonoScript> script = PPtr<MonoScript>.Read(reader);
        int flags = reader.ReadS32();
        
        return new(curve,
            attribute,
            path,
            classID,
            script,
            flags);
    }
}

/* $PPtrKeyframe (2 fields) (None) */
public record class PPtrKeyframe(
    float time,
    PPtr<Object> @value)
{
    public static PPtrKeyframe Read(EndianBinaryReader reader)
    {
        float time = reader.ReadF32();
        PPtr<Object> @value = PPtr<Object>.Read(reader);
        
        return new(time,
            @value);
    }
}

/* $PPtrCurve (6 fields) (None) */
public record class PPtrCurve(
    PPtrKeyframe[] curve,
    AsciiString attribute,
    AsciiString path,
    int classID,
    PPtr<MonoScript> script,
    int flags)
{
    public static PPtrCurve Read(EndianBinaryReader reader)
    {
        PPtrKeyframe[] curve = Array<PPtrKeyframe>.Read(reader);
        AsciiString attribute = String.Read(reader);
        AsciiString path = String.Read(reader);
        int classID = reader.ReadS32();
        PPtr<MonoScript> script = PPtr<MonoScript>.Read(reader);
        int flags = reader.ReadS32();
        
        return new(curve,
            attribute,
            path,
            classID,
            script,
            flags);
    }
}

/* $AABB (2 fields) (None) */
public record class AABB(
    Vector3f m_Center,
    Vector3f m_Extent)
{
    public static AABB Read(EndianBinaryReader reader)
    {
        Vector3f m_Center = Vector3f.Read(reader);
        Vector3f m_Extent = Vector3f.Read(reader);
        
        return new(m_Center,
            m_Extent);
    }
}

/* $float3 (3 fields) (None) */
public readonly record struct float3(
    float x,
    float y,
    float z)
{
    public static float3 Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        float z = reader.ReadF32();
        
        return new(x,
            y,
            z);
    }
}

/* $float4 (4 fields) (None) */
public readonly record struct float4(
    float x,
    float y,
    float z,
    float w)
{
    public static float4 Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        float z = reader.ReadF32();
        float w = reader.ReadF32();
        
        return new(x,
            y,
            z,
            w);
    }
}

/* $xform (3 fields) (None) */
public record class xform(
    float3 t,
    float4 q,
    float3 s)
{
    public static xform Read(EndianBinaryReader reader)
    {
        float3 t = float3.Read(reader);
        float4 q = float4.Read(reader);
        float3 s = float3.Read(reader);
        
        return new(t,
            q,
            s);
    }
}

/* $HumanGoal (5 fields) (None) */
public record class HumanGoal(
    xform m_X,
    float m_WeightT,
    float m_WeightR,
    float3 m_HintT,
    float m_HintWeightT)
{
    public static HumanGoal Read(EndianBinaryReader reader)
    {
        xform m_X = xform.Read(reader);
        float m_WeightT = reader.ReadF32();
        float m_WeightR = reader.ReadF32();
        float3 m_HintT = float3.Read(reader);
        float m_HintWeightT = reader.ReadF32();
        
        return new(m_X,
            m_WeightT,
            m_WeightR,
            m_HintT,
            m_HintWeightT);
    }
}

/* $HandPose (6 fields) (None) */
public record class HandPose(
    xform m_GrabX,
    float[] m_DoFArray,
    float m_Override,
    float m_CloseOpen,
    float m_InOut,
    float m_Grab)
{
    public static HandPose Read(EndianBinaryReader reader)
    {
        xform m_GrabX = xform.Read(reader);
        float[] m_DoFArray = Array<float>.Read(reader);
        float m_Override = reader.ReadF32();
        float m_CloseOpen = reader.ReadF32();
        float m_InOut = reader.ReadF32();
        float m_Grab = reader.ReadF32();
        
        return new(m_GrabX,
            m_DoFArray,
            m_Override,
            m_CloseOpen,
            m_InOut,
            m_Grab);
    }
}

/* $HumanPose (8 fields) (None) */
public record class HumanPose(
    xform m_RootX,
    float3 m_LookAtPosition,
    float4 m_LookAtWeight,
    HumanGoal[] m_GoalArray,
    HandPose m_LeftHandPose,
    HandPose m_RightHandPose,
    float[] m_DoFArray,
    float3[] m_TDoFArray)
{
    public static HumanPose Read(EndianBinaryReader reader)
    {
        xform m_RootX = xform.Read(reader);
        float3 m_LookAtPosition = float3.Read(reader);
        float4 m_LookAtWeight = float4.Read(reader);
        HumanGoal[] m_GoalArray = Array<HumanGoal>.Read(reader);
        HandPose m_LeftHandPose = HandPose.Read(reader);
        HandPose m_RightHandPose = HandPose.Read(reader);
        float[] m_DoFArray = Array<float>.Read(reader);
        float3[] m_TDoFArray = Array<float3>.Read(reader);
        
        return new(m_RootX,
            m_LookAtPosition,
            m_LookAtWeight,
            m_GoalArray,
            m_LeftHandPose,
            m_RightHandPose,
            m_DoFArray,
            m_TDoFArray);
    }
}

/* $StreamedClip (2 fields) (None) */
public record class StreamedClip(
    uint[] data,
    uint curveCount)
{
    public static StreamedClip Read(EndianBinaryReader reader)
    {
        uint[] data = Array<uint>.Read(reader);
        uint curveCount = reader.ReadU32();
        
        return new(data,
            curveCount);
    }
}

/* $DenseClip (5 fields) (None) */
public record class DenseClip(
    int m_FrameCount,
    uint m_CurveCount,
    float m_SampleRate,
    float m_BeginTime,
    float[] m_SampleArray)
{
    public static DenseClip Read(EndianBinaryReader reader)
    {
        int m_FrameCount = reader.ReadS32();
        uint m_CurveCount = reader.ReadU32();
        float m_SampleRate = reader.ReadF32();
        float m_BeginTime = reader.ReadF32();
        float[] m_SampleArray = Array<float>.Read(reader);
        
        return new(m_FrameCount,
            m_CurveCount,
            m_SampleRate,
            m_BeginTime,
            m_SampleArray);
    }
}

/* $ConstantClip (1 fields) (None) */
public record class ConstantClip(
    float[] data)
{
    public static ConstantClip Read(EndianBinaryReader reader)
    {
        float[] data = Array<float>.Read(reader);
        
        return new(data);
    }
}

/* $Clip (3 fields) (None) */
public record class Clip(
    StreamedClip m_StreamedClip,
    DenseClip m_DenseClip,
    ConstantClip m_ConstantClip)
{
    public static Clip Read(EndianBinaryReader reader)
    {
        StreamedClip m_StreamedClip = StreamedClip.Read(reader);
        DenseClip m_DenseClip = DenseClip.Read(reader);
        ConstantClip m_ConstantClip = ConstantClip.Read(reader);
        
        return new(m_StreamedClip,
            m_DenseClip,
            m_ConstantClip);
    }
}

/* $OffsetPtr (1 fields) (None) */
public record class OffsetPtr(
    Clip data)
{
    public static OffsetPtr Read(EndianBinaryReader reader)
    {
        Clip data = Clip.Read(reader);
        
        return new(data);
    }
}

/* $ValueDelta (2 fields) (None) */
public readonly record struct ValueDelta(
    float m_Start,
    float m_Stop)
{
    public static ValueDelta Read(EndianBinaryReader reader)
    {
        float m_Start = reader.ReadF32();
        float m_Stop = reader.ReadF32();
        
        return new(m_Start,
            m_Stop);
    }
}

/* $ClipMuscleConstant (27 fields) (None) */
public record class ClipMuscleConstant(
    HumanPose m_DeltaPose,
    xform m_StartX,
    xform m_StopX,
    xform m_LeftFootStartX,
    xform m_RightFootStartX,
    float3 m_AverageSpeed,
    OffsetPtr m_Clip,
    float m_StartTime,
    float m_StopTime,
    float m_OrientationOffsetY,
    float m_Level,
    float m_CycleOffset,
    float m_AverageAngularSpeed,
    int[] m_IndexArray,
    ValueDelta[] m_ValueArrayDelta,
    float[] m_ValueArrayReferencePose,
    bool m_Mirror,
    bool m_LoopTime,
    bool m_LoopBlend,
    bool m_LoopBlendOrientation,
    bool m_LoopBlendPositionY,
    bool m_LoopBlendPositionXZ,
    bool m_StartAtOrigin,
    bool m_KeepOriginalOrientation,
    bool m_KeepOriginalPositionY,
    bool m_KeepOriginalPositionXZ,
    bool m_HeightFromFeet)
{
    public static ClipMuscleConstant Read(EndianBinaryReader reader)
    {
        HumanPose m_DeltaPose = HumanPose.Read(reader);
        xform m_StartX = xform.Read(reader);
        xform m_StopX = xform.Read(reader);
        xform m_LeftFootStartX = xform.Read(reader);
        xform m_RightFootStartX = xform.Read(reader);
        float3 m_AverageSpeed = float3.Read(reader);
        OffsetPtr m_Clip = OffsetPtr.Read(reader);
        float m_StartTime = reader.ReadF32();
        float m_StopTime = reader.ReadF32();
        float m_OrientationOffsetY = reader.ReadF32();
        float m_Level = reader.ReadF32();
        float m_CycleOffset = reader.ReadF32();
        float m_AverageAngularSpeed = reader.ReadF32();
        int[] m_IndexArray = Array<int>.Read(reader);
        ValueDelta[] m_ValueArrayDelta = Array<ValueDelta>.Read(reader);
        float[] m_ValueArrayReferencePose = Array<float>.Read(reader);
        bool m_Mirror = reader.ReadBool();
        bool m_LoopTime = reader.ReadBool();
        bool m_LoopBlend = reader.ReadBool();
        bool m_LoopBlendOrientation = reader.ReadBool();
        bool m_LoopBlendPositionY = reader.ReadBool();
        bool m_LoopBlendPositionXZ = reader.ReadBool();
        bool m_StartAtOrigin = reader.ReadBool();
        bool m_KeepOriginalOrientation = reader.ReadBool();
        bool m_KeepOriginalPositionY = reader.ReadBool();
        bool m_KeepOriginalPositionXZ = reader.ReadBool();
        bool m_HeightFromFeet = reader.ReadBool();
        
        return new(m_DeltaPose,
            m_StartX,
            m_StopX,
            m_LeftFootStartX,
            m_RightFootStartX,
            m_AverageSpeed,
            m_Clip,
            m_StartTime,
            m_StopTime,
            m_OrientationOffsetY,
            m_Level,
            m_CycleOffset,
            m_AverageAngularSpeed,
            m_IndexArray,
            m_ValueArrayDelta,
            m_ValueArrayReferencePose,
            m_Mirror,
            m_LoopTime,
            m_LoopBlend,
            m_LoopBlendOrientation,
            m_LoopBlendPositionY,
            m_LoopBlendPositionXZ,
            m_StartAtOrigin,
            m_KeepOriginalOrientation,
            m_KeepOriginalPositionY,
            m_KeepOriginalPositionXZ,
            m_HeightFromFeet);
    }
}

/* $GenericBinding (8 fields) (None) */
public record class GenericBinding(
    uint path,
    uint attribute,
    PPtr<Object> script,
    int typeID,
    byte customType,
    byte isPPtrCurve,
    byte isIntCurve,
    byte isSerializeReferenceCurve)
{
    public static GenericBinding Read(EndianBinaryReader reader)
    {
        uint path = reader.ReadU32();
        uint attribute = reader.ReadU32();
        PPtr<Object> script = PPtr<Object>.Read(reader);
        int typeID = reader.ReadS32();
        byte customType = reader.ReadU8();
        byte isPPtrCurve = reader.ReadU8();
        byte isIntCurve = reader.ReadU8();
        byte isSerializeReferenceCurve = reader.ReadU8();
        
        return new(path,
            attribute,
            script,
            typeID,
            customType,
            isPPtrCurve,
            isIntCurve,
            isSerializeReferenceCurve);
    }
}

/* $AnimationClipBindingConstant (2 fields) (None) */
public record class AnimationClipBindingConstant(
    GenericBinding[] genericBindings,
    PPtr<Object>[] pptrCurveMapping)
{
    public static AnimationClipBindingConstant Read(EndianBinaryReader reader)
    {
        GenericBinding[] genericBindings = Array<GenericBinding>.Read(reader);
        PPtr<Object>[] pptrCurveMapping = Array<PPtr<Object>>.Read(reader);
        
        return new(genericBindings,
            pptrCurveMapping);
    }
}

/* $AnimationEvent (7 fields) (None) */
public record class AnimationEvent(
    float time,
    AsciiString functionName,
    AsciiString data,
    PPtr<Object> objectReferenceParameter,
    float floatParameter,
    int intParameter,
    int messageOptions)
{
    public static AnimationEvent Read(EndianBinaryReader reader)
    {
        float time = reader.ReadF32();
        AsciiString functionName = String.Read(reader);
        AsciiString data = String.Read(reader);
        PPtr<Object> objectReferenceParameter = PPtr<Object>.Read(reader);
        float floatParameter = reader.ReadF32();
        int intParameter = reader.ReadS32();
        int messageOptions = reader.ReadS32();
        
        return new(time,
            functionName,
            data,
            objectReferenceParameter,
            floatParameter,
            intParameter,
            messageOptions);
    }
}

/* $BitField (1 fields) (None) */
public readonly record struct BitField(
    uint m_Bits)
{
    public static BitField Read(EndianBinaryReader reader)
    {
        uint m_Bits = reader.ReadU32();
        
        return new(m_Bits);
    }
}

/* $SoftJointLimitSpring (2 fields) (None) */
public readonly record struct SoftJointLimitSpring(
    float spring,
    float damper)
{
    public static SoftJointLimitSpring Read(EndianBinaryReader reader)
    {
        float spring = reader.ReadF32();
        float damper = reader.ReadF32();
        
        return new(spring,
            damper);
    }
}

/* $SoftJointLimit (3 fields) (None) */
public readonly record struct SoftJointLimit(
    float limit,
    float bounciness,
    float contactDistance)
{
    public static SoftJointLimit Read(EndianBinaryReader reader)
    {
        float limit = reader.ReadF32();
        float bounciness = reader.ReadF32();
        float contactDistance = reader.ReadF32();
        
        return new(limit,
            bounciness,
            contactDistance);
    }
}

/* $GLTextureSettings (6 fields) (None) */
public readonly record struct GLTextureSettings(
    int m_FilterMode,
    int m_Aniso,
    float m_MipBias,
    int m_WrapU,
    int m_WrapV,
    int m_WrapW)
{
    public static GLTextureSettings Read(EndianBinaryReader reader)
    {
        int m_FilterMode = reader.ReadS32();
        int m_Aniso = reader.ReadS32();
        float m_MipBias = reader.ReadF32();
        int m_WrapU = reader.ReadS32();
        int m_WrapV = reader.ReadS32();
        int m_WrapW = reader.ReadS32();
        
        return new(m_FilterMode,
            m_Aniso,
            m_MipBias,
            m_WrapU,
            m_WrapV,
            m_WrapW);
    }
}

/* $TypelessData (2 fields) (None) */
public readonly record struct TypelessData(
    int size,
    byte data)
{
    public static TypelessData Read(EndianBinaryReader reader)
    {
        int size = reader.ReadS32();
        byte data = reader.ReadU8();
        
        return new(size,
            data);
    }
}

/* $StreamingInfo (3 fields) (None) */
public record class StreamingInfo(
    ulong offset,
    uint size,
    AsciiString path)
{
    public static StreamingInfo Read(EndianBinaryReader reader)
    {
        ulong offset = reader.ReadU64();
        uint size = reader.ReadU32();
        AsciiString path = String.Read(reader);
        
        return new(offset,
            size,
            path);
    }
}

/* $TransformMaskElement (2 fields) (None) */
public record class TransformMaskElement(
    AsciiString m_Path,
    float m_Weight)
{
    public static TransformMaskElement Read(EndianBinaryReader reader)
    {
        AsciiString m_Path = String.Read(reader);
        float m_Weight = reader.ReadF32();
        
        return new(m_Path,
            m_Weight);
    }
}

/* $ControllerConstant (4 fields) (None) */
public record class ControllerConstant(
    OffsetPtr[] m_LayerArray,
    OffsetPtr[] m_StateMachineArray,
    OffsetPtr m_Values,
    OffsetPtr m_DefaultValues)
{
    public static ControllerConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr[] m_LayerArray = Array<OffsetPtr>.Read(reader);
        OffsetPtr[] m_StateMachineArray = Array<OffsetPtr>.Read(reader);
        OffsetPtr m_Values = OffsetPtr.Read(reader);
        OffsetPtr m_DefaultValues = OffsetPtr.Read(reader);
        
        return new(m_LayerArray,
            m_StateMachineArray,
            m_Values,
            m_DefaultValues);
    }
}

/* $StateKey (2 fields) (None) */
public readonly record struct StateKey(
    uint m_StateID,
    int m_LayerIndex)
{
    public static StateKey Read(EndianBinaryReader reader)
    {
        uint m_StateID = reader.ReadU32();
        int m_LayerIndex = reader.ReadS32();
        
        return new(m_StateID,
            m_LayerIndex);
    }
}

/* $StateRange (2 fields) (None) */
public readonly record struct StateRange(
    uint m_StartIndex,
    uint m_Count)
{
    public static StateRange Read(EndianBinaryReader reader)
    {
        uint m_StartIndex = reader.ReadU32();
        uint m_Count = reader.ReadU32();
        
        return new(m_StartIndex,
            m_Count);
    }
}

/* $StateMachineBehaviourVectorDescription (2 fields) (None) */
public record class StateMachineBehaviourVectorDescription(
    Dictionary<StateKey, StateRange> m_StateMachineBehaviourRanges,
    uint[] m_StateMachineBehaviourIndices)
{
    public static StateMachineBehaviourVectorDescription Read(EndianBinaryReader reader)
    {
        Dictionary<StateKey, StateRange> m_StateMachineBehaviourRanges = Map<StateKey, StateRange>.Read(reader);
        uint[] m_StateMachineBehaviourIndices = Array<uint>.Read(reader);
        
        return new(m_StateMachineBehaviourRanges,
            m_StateMachineBehaviourIndices);
    }
}

/* $ComponentPair (1 fields) (None) */
public record class ComponentPair(
    PPtr<Component> component)
{
    public static ComponentPair Read(EndianBinaryReader reader)
    {
        PPtr<Component> component = PPtr<Component>.Read(reader);
        
        return new(component);
    }
}

/* $SerializedTextureProperty (2 fields) (None) */
public record class SerializedTextureProperty(
    AsciiString m_DefaultName,
    int m_TexDim)
{
    public static SerializedTextureProperty Read(EndianBinaryReader reader)
    {
        AsciiString m_DefaultName = String.Read(reader);
        int m_TexDim = reader.ReadS32();
        
        return new(m_DefaultName,
            m_TexDim);
    }
}

/* $SerializedProperty (10 fields) (None) */
public record class SerializedProperty(
    AsciiString m_Name,
    AsciiString m_Description,
    AsciiString[] m_Attributes,
    int m_Type,
    uint m_Flags,
    float m_DefValue_0,
    float m_DefValue_1,
    float m_DefValue_2,
    float m_DefValue_3,
    SerializedTextureProperty m_DefTexture)
{
    public static SerializedProperty Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        AsciiString m_Description = String.Read(reader);
        AsciiString[] m_Attributes = Array<AsciiString>.Read(reader);
        int m_Type = reader.ReadS32();
        uint m_Flags = reader.ReadU32();
        float m_DefValue_0 = reader.ReadF32();
        float m_DefValue_1 = reader.ReadF32();
        float m_DefValue_2 = reader.ReadF32();
        float m_DefValue_3 = reader.ReadF32();
        SerializedTextureProperty m_DefTexture = SerializedTextureProperty.Read(reader);
        
        return new(m_Name,
            m_Description,
            m_Attributes,
            m_Type,
            m_Flags,
            m_DefValue_0,
            m_DefValue_1,
            m_DefValue_2,
            m_DefValue_3,
            m_DefTexture);
    }
}

/* $SerializedProperties (1 fields) (None) */
public record class SerializedProperties(
    SerializedProperty[] m_Props)
{
    public static SerializedProperties Read(EndianBinaryReader reader)
    {
        SerializedProperty[] m_Props = Array<SerializedProperty>.Read(reader);
        
        return new(m_Props);
    }
}

/* $SerializedShaderFloatValue (2 fields) (None) */
public record class SerializedShaderFloatValue(
    float val,
    AsciiString name)
{
    public static SerializedShaderFloatValue Read(EndianBinaryReader reader)
    {
        float val = reader.ReadF32();
        AsciiString name = String.Read(reader);
        
        return new(val,
            name);
    }
}

/* $SerializedShaderRTBlendState (7 fields) (None) */
public record class SerializedShaderRTBlendState(
    SerializedShaderFloatValue srcBlend,
    SerializedShaderFloatValue destBlend,
    SerializedShaderFloatValue srcBlendAlpha,
    SerializedShaderFloatValue destBlendAlpha,
    SerializedShaderFloatValue blendOp,
    SerializedShaderFloatValue blendOpAlpha,
    SerializedShaderFloatValue colMask)
{
    public static SerializedShaderRTBlendState Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue srcBlend = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue destBlend = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue srcBlendAlpha = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue destBlendAlpha = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue blendOp = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue blendOpAlpha = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue colMask = SerializedShaderFloatValue.Read(reader);
        
        return new(srcBlend,
            destBlend,
            srcBlendAlpha,
            destBlendAlpha,
            blendOp,
            blendOpAlpha,
            colMask);
    }
}

/* $SerializedStencilOp (4 fields) (None) */
public record class SerializedStencilOp(
    SerializedShaderFloatValue pass,
    SerializedShaderFloatValue fail,
    SerializedShaderFloatValue zFail,
    SerializedShaderFloatValue comp)
{
    public static SerializedStencilOp Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue pass = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue fail = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue zFail = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue comp = SerializedShaderFloatValue.Read(reader);
        
        return new(pass,
            fail,
            zFail,
            comp);
    }
}

/* $SerializedShaderVectorValue (5 fields) (None) */
public record class SerializedShaderVectorValue(
    SerializedShaderFloatValue x,
    SerializedShaderFloatValue y,
    SerializedShaderFloatValue z,
    SerializedShaderFloatValue w,
    AsciiString name)
{
    public static SerializedShaderVectorValue Read(EndianBinaryReader reader)
    {
        SerializedShaderFloatValue x = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue y = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue z = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue w = SerializedShaderFloatValue.Read(reader);
        AsciiString name = String.Read(reader);
        
        return new(x,
            y,
            z,
            w,
            name);
    }
}

/* $SerializedTagMap (1 fields) (None) */
public record class SerializedTagMap(
    Dictionary<AsciiString, AsciiString> tags)
{
    public static SerializedTagMap Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, AsciiString> tags = Map<AsciiString, AsciiString>.Read(reader);
        
        return new(tags);
    }
}

/* $SerializedShaderState (33 fields) (None) */
public record class SerializedShaderState(
    AsciiString m_Name,
    SerializedShaderRTBlendState rtBlend0,
    SerializedShaderRTBlendState rtBlend1,
    SerializedShaderRTBlendState rtBlend2,
    SerializedShaderRTBlendState rtBlend3,
    SerializedShaderRTBlendState rtBlend4,
    SerializedShaderRTBlendState rtBlend5,
    SerializedShaderRTBlendState rtBlend6,
    SerializedShaderRTBlendState rtBlend7,
    bool rtSeparateBlend,
    SerializedShaderFloatValue zClip,
    SerializedShaderFloatValue zTest,
    SerializedShaderFloatValue zWrite,
    SerializedShaderFloatValue culling,
    SerializedShaderFloatValue conservative,
    SerializedShaderFloatValue offsetFactor,
    SerializedShaderFloatValue offsetUnits,
    SerializedShaderFloatValue alphaToMask,
    SerializedStencilOp stencilOp,
    SerializedStencilOp stencilOpFront,
    SerializedStencilOp stencilOpBack,
    SerializedShaderFloatValue stencilReadMask,
    SerializedShaderFloatValue stencilWriteMask,
    SerializedShaderFloatValue stencilRef,
    SerializedShaderFloatValue fogStart,
    SerializedShaderFloatValue fogEnd,
    SerializedShaderFloatValue fogDensity,
    SerializedShaderVectorValue fogColor,
    int fogMode,
    int gpuProgramID,
    SerializedTagMap m_Tags,
    int m_LOD,
    bool lighting)
{
    public static SerializedShaderState Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        SerializedShaderRTBlendState rtBlend0 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend1 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend2 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend3 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend4 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend5 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend6 = SerializedShaderRTBlendState.Read(reader);
        SerializedShaderRTBlendState rtBlend7 = SerializedShaderRTBlendState.Read(reader);
        bool rtSeparateBlend = reader.ReadBool();
        SerializedShaderFloatValue zClip = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue zTest = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue zWrite = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue culling = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue conservative = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue offsetFactor = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue offsetUnits = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue alphaToMask = SerializedShaderFloatValue.Read(reader);
        SerializedStencilOp stencilOp = SerializedStencilOp.Read(reader);
        SerializedStencilOp stencilOpFront = SerializedStencilOp.Read(reader);
        SerializedStencilOp stencilOpBack = SerializedStencilOp.Read(reader);
        SerializedShaderFloatValue stencilReadMask = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue stencilWriteMask = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue stencilRef = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue fogStart = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue fogEnd = SerializedShaderFloatValue.Read(reader);
        SerializedShaderFloatValue fogDensity = SerializedShaderFloatValue.Read(reader);
        SerializedShaderVectorValue fogColor = SerializedShaderVectorValue.Read(reader);
        int fogMode = reader.ReadS32();
        int gpuProgramID = reader.ReadS32();
        SerializedTagMap m_Tags = SerializedTagMap.Read(reader);
        int m_LOD = reader.ReadS32();
        bool lighting = reader.ReadBool();
        
        return new(m_Name,
            rtBlend0,
            rtBlend1,
            rtBlend2,
            rtBlend3,
            rtBlend4,
            rtBlend5,
            rtBlend6,
            rtBlend7,
            rtSeparateBlend,
            zClip,
            zTest,
            zWrite,
            culling,
            conservative,
            offsetFactor,
            offsetUnits,
            alphaToMask,
            stencilOp,
            stencilOpFront,
            stencilOpBack,
            stencilReadMask,
            stencilWriteMask,
            stencilRef,
            fogStart,
            fogEnd,
            fogDensity,
            fogColor,
            fogMode,
            gpuProgramID,
            m_Tags,
            m_LOD,
            lighting);
    }
}

/* $ShaderBindChannel (2 fields) (None) */
public readonly record struct ShaderBindChannel(
    sbyte source,
    sbyte target)
{
    public static ShaderBindChannel Read(EndianBinaryReader reader)
    {
        sbyte source = reader.ReadS8();
        sbyte target = reader.ReadS8();
        
        return new(source,
            target);
    }
}

/* $ParserBindChannels (2 fields) (None) */
public record class ParserBindChannels(
    ShaderBindChannel[] m_Channels,
    int m_SourceMap)
{
    public static ParserBindChannels Read(EndianBinaryReader reader)
    {
        ShaderBindChannel[] m_Channels = Array<ShaderBindChannel>.Read(reader);
        int m_SourceMap = reader.ReadS32();
        
        return new(m_Channels,
            m_SourceMap);
    }
}

/* $VectorParameter (5 fields) (None) */
public readonly record struct VectorParameter(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    sbyte m_Type,
    sbyte m_Dim)
{
    public static VectorParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        int m_Index = reader.ReadS32();
        int m_ArraySize = reader.ReadS32();
        sbyte m_Type = reader.ReadS8();
        sbyte m_Dim = reader.ReadS8();
        
        return new(m_NameIndex,
            m_Index,
            m_ArraySize,
            m_Type,
            m_Dim);
    }
}

/* $MatrixParameter (5 fields) (None) */
public readonly record struct MatrixParameter(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    sbyte m_Type,
    sbyte m_RowCount)
{
    public static MatrixParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        int m_Index = reader.ReadS32();
        int m_ArraySize = reader.ReadS32();
        sbyte m_Type = reader.ReadS8();
        sbyte m_RowCount = reader.ReadS8();
        
        return new(m_NameIndex,
            m_Index,
            m_ArraySize,
            m_Type,
            m_RowCount);
    }
}

/* $TextureParameter (5 fields) (None) */
public readonly record struct TextureParameter(
    int m_NameIndex,
    int m_Index,
    int m_SamplerIndex,
    bool m_MultiSampled,
    sbyte m_Dim)
{
    public static TextureParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        int m_Index = reader.ReadS32();
        int m_SamplerIndex = reader.ReadS32();
        bool m_MultiSampled = reader.ReadBool();
        sbyte m_Dim = reader.ReadS8();
        
        return new(m_NameIndex,
            m_Index,
            m_SamplerIndex,
            m_MultiSampled,
            m_Dim);
    }
}

/* $BufferBinding (3 fields) (None) */
public readonly record struct BufferBinding(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize)
{
    public static BufferBinding Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        int m_Index = reader.ReadS32();
        int m_ArraySize = reader.ReadS32();
        
        return new(m_NameIndex,
            m_Index,
            m_ArraySize);
    }
}

/* $StructParameter (6 fields) (None) */
public record class StructParameter(
    int m_NameIndex,
    int m_Index,
    int m_ArraySize,
    int m_StructSize,
    VectorParameter[] m_VectorMembers,
    MatrixParameter[] m_MatrixMembers)
{
    public static StructParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        int m_Index = reader.ReadS32();
        int m_ArraySize = reader.ReadS32();
        int m_StructSize = reader.ReadS32();
        VectorParameter[] m_VectorMembers = Array<VectorParameter>.Read(reader);
        MatrixParameter[] m_MatrixMembers = Array<MatrixParameter>.Read(reader);
        
        return new(m_NameIndex,
            m_Index,
            m_ArraySize,
            m_StructSize,
            m_VectorMembers,
            m_MatrixMembers);
    }
}

/* $ConstantBuffer (6 fields) (None) */
public record class ConstantBuffer(
    int m_NameIndex,
    MatrixParameter[] m_MatrixParams,
    VectorParameter[] m_VectorParams,
    StructParameter[] m_StructParams,
    int m_Size,
    bool m_IsPartialCB)
{
    public static ConstantBuffer Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        MatrixParameter[] m_MatrixParams = Array<MatrixParameter>.Read(reader);
        VectorParameter[] m_VectorParams = Array<VectorParameter>.Read(reader);
        StructParameter[] m_StructParams = Array<StructParameter>.Read(reader);
        int m_Size = reader.ReadS32();
        bool m_IsPartialCB = reader.ReadBool();
        
        return new(m_NameIndex,
            m_MatrixParams,
            m_VectorParams,
            m_StructParams,
            m_Size,
            m_IsPartialCB);
    }
}

/* $UAVParameter (3 fields) (None) */
public readonly record struct UAVParameter(
    int m_NameIndex,
    int m_Index,
    int m_OriginalIndex)
{
    public static UAVParameter Read(EndianBinaryReader reader)
    {
        int m_NameIndex = reader.ReadS32();
        int m_Index = reader.ReadS32();
        int m_OriginalIndex = reader.ReadS32();
        
        return new(m_NameIndex,
            m_Index,
            m_OriginalIndex);
    }
}

/* $SamplerParameter (2 fields) (None) */
public readonly record struct SamplerParameter(
    uint sampler,
    int bindPoint)
{
    public static SamplerParameter Read(EndianBinaryReader reader)
    {
        uint sampler = reader.ReadU32();
        int bindPoint = reader.ReadS32();
        
        return new(sampler,
            bindPoint);
    }
}

/* $SerializedProgramParameters (8 fields) (None) */
public record class SerializedProgramParameters(
    VectorParameter[] m_VectorParams,
    MatrixParameter[] m_MatrixParams,
    TextureParameter[] m_TextureParams,
    BufferBinding[] m_BufferParams,
    ConstantBuffer[] m_ConstantBuffers,
    BufferBinding[] m_ConstantBufferBindings,
    UAVParameter[] m_UAVParams,
    SamplerParameter[] m_Samplers)
{
    public static SerializedProgramParameters Read(EndianBinaryReader reader)
    {
        VectorParameter[] m_VectorParams = Array<VectorParameter>.Read(reader);
        MatrixParameter[] m_MatrixParams = Array<MatrixParameter>.Read(reader);
        TextureParameter[] m_TextureParams = Array<TextureParameter>.Read(reader);
        BufferBinding[] m_BufferParams = Array<BufferBinding>.Read(reader);
        ConstantBuffer[] m_ConstantBuffers = Array<ConstantBuffer>.Read(reader);
        BufferBinding[] m_ConstantBufferBindings = Array<BufferBinding>.Read(reader);
        UAVParameter[] m_UAVParams = Array<UAVParameter>.Read(reader);
        SamplerParameter[] m_Samplers = Array<SamplerParameter>.Read(reader);
        
        return new(m_VectorParams,
            m_MatrixParams,
            m_TextureParams,
            m_BufferParams,
            m_ConstantBuffers,
            m_ConstantBufferBindings,
            m_UAVParams,
            m_Samplers);
    }
}

/* $SerializedSubProgram (7 fields) (None) */
public record class SerializedSubProgram(
    uint m_BlobIndex,
    ParserBindChannels m_Channels,
    ushort[] m_KeywordIndices,
    sbyte m_ShaderHardwareTier,
    sbyte m_GpuProgramType,
    SerializedProgramParameters m_Parameters,
    long m_ShaderRequirements)
{
    public static SerializedSubProgram Read(EndianBinaryReader reader)
    {
        uint m_BlobIndex = reader.ReadU32();
        ParserBindChannels m_Channels = ParserBindChannels.Read(reader);
        ushort[] m_KeywordIndices = Array<ushort>.Read(reader);
        sbyte m_ShaderHardwareTier = reader.ReadS8();
        sbyte m_GpuProgramType = reader.ReadS8();
        SerializedProgramParameters m_Parameters = SerializedProgramParameters.Read(reader);
        long m_ShaderRequirements = reader.ReadS64();
        
        return new(m_BlobIndex,
            m_Channels,
            m_KeywordIndices,
            m_ShaderHardwareTier,
            m_GpuProgramType,
            m_Parameters,
            m_ShaderRequirements);
    }
}

/* $SerializedPlayerSubProgram (4 fields) (None) */
public record class SerializedPlayerSubProgram(
    uint m_BlobIndex,
    ushort[] m_KeywordIndices,
    long m_ShaderRequirements,
    sbyte m_GpuProgramType)
{
    public static SerializedPlayerSubProgram Read(EndianBinaryReader reader)
    {
        uint m_BlobIndex = reader.ReadU32();
        ushort[] m_KeywordIndices = Array<ushort>.Read(reader);
        long m_ShaderRequirements = reader.ReadS64();
        sbyte m_GpuProgramType = reader.ReadS8();
        
        return new(m_BlobIndex,
            m_KeywordIndices,
            m_ShaderRequirements,
            m_GpuProgramType);
    }
}

/* $SerializedProgram (5 fields) (None) */
public record class SerializedProgram(
    SerializedSubProgram[] m_SubPrograms,
    SerializedPlayerSubProgram[][] m_PlayerSubPrograms,
    uint[][] m_ParameterBlobIndices,
    SerializedProgramParameters m_CommonParameters,
    ushort[] m_SerializedKeywordStateMask)
{
    public static SerializedProgram Read(EndianBinaryReader reader)
    {
        SerializedSubProgram[] m_SubPrograms = Array<SerializedSubProgram>.Read(reader);
        SerializedPlayerSubProgram[][] m_PlayerSubPrograms = Array<SerializedPlayerSubProgram[]>.Read(reader);
        uint[][] m_ParameterBlobIndices = Array<uint[]>.Read(reader);
        SerializedProgramParameters m_CommonParameters = SerializedProgramParameters.Read(reader);
        ushort[] m_SerializedKeywordStateMask = Array<ushort>.Read(reader);
        
        return new(m_SubPrograms,
            m_PlayerSubPrograms,
            m_ParameterBlobIndices,
            m_CommonParameters,
            m_SerializedKeywordStateMask);
    }
}

/* $SerializedPass (18 fields) (None) */
public record class SerializedPass(
    Hash128[] m_EditorDataHash,
    byte[] m_Platforms,
    Dictionary<AsciiString, int> m_NameIndices,
    int m_Type,
    SerializedShaderState m_State,
    uint m_ProgramMask,
    SerializedProgram progVertex,
    SerializedProgram progFragment,
    SerializedProgram progGeometry,
    SerializedProgram progHull,
    SerializedProgram progDomain,
    SerializedProgram progRayTracing,
    bool m_HasInstancingVariant,
    bool m_HasProceduralInstancingVariant,
    AsciiString m_UseName,
    AsciiString m_Name,
    AsciiString m_TextureName,
    SerializedTagMap m_Tags)
{
    public static SerializedPass Read(EndianBinaryReader reader)
    {
        Hash128[] m_EditorDataHash = Array<Hash128>.Read(reader);
        byte[] m_Platforms = Array<byte>.Read(reader);
        Dictionary<AsciiString, int> m_NameIndices = Map<AsciiString, int>.Read(reader);
        int m_Type = reader.ReadS32();
        SerializedShaderState m_State = SerializedShaderState.Read(reader);
        uint m_ProgramMask = reader.ReadU32();
        SerializedProgram progVertex = SerializedProgram.Read(reader);
        SerializedProgram progFragment = SerializedProgram.Read(reader);
        SerializedProgram progGeometry = SerializedProgram.Read(reader);
        SerializedProgram progHull = SerializedProgram.Read(reader);
        SerializedProgram progDomain = SerializedProgram.Read(reader);
        SerializedProgram progRayTracing = SerializedProgram.Read(reader);
        bool m_HasInstancingVariant = reader.ReadBool();
        bool m_HasProceduralInstancingVariant = reader.ReadBool();
        AsciiString m_UseName = String.Read(reader);
        AsciiString m_Name = String.Read(reader);
        AsciiString m_TextureName = String.Read(reader);
        SerializedTagMap m_Tags = SerializedTagMap.Read(reader);
        
        return new(m_EditorDataHash,
            m_Platforms,
            m_NameIndices,
            m_Type,
            m_State,
            m_ProgramMask,
            progVertex,
            progFragment,
            progGeometry,
            progHull,
            progDomain,
            progRayTracing,
            m_HasInstancingVariant,
            m_HasProceduralInstancingVariant,
            m_UseName,
            m_Name,
            m_TextureName,
            m_Tags);
    }
}

/* $SerializedSubShader (3 fields) (None) */
public record class SerializedSubShader(
    SerializedPass[] m_Passes,
    SerializedTagMap m_Tags,
    int m_LOD)
{
    public static SerializedSubShader Read(EndianBinaryReader reader)
    {
        SerializedPass[] m_Passes = Array<SerializedPass>.Read(reader);
        SerializedTagMap m_Tags = SerializedTagMap.Read(reader);
        int m_LOD = reader.ReadS32();
        
        return new(m_Passes,
            m_Tags,
            m_LOD);
    }
}

/* $SerializedShaderDependency (2 fields) (None) */
public record class SerializedShaderDependency(
    AsciiString @from,
    AsciiString to)
{
    public static SerializedShaderDependency Read(EndianBinaryReader reader)
    {
        AsciiString @from = String.Read(reader);
        AsciiString to = String.Read(reader);
        
        return new(@from,
            to);
    }
}

/* $SerializedCustomEditorForRenderPipeline (2 fields) (None) */
public record class SerializedCustomEditorForRenderPipeline(
    AsciiString customEditorName,
    AsciiString renderPipelineType)
{
    public static SerializedCustomEditorForRenderPipeline Read(EndianBinaryReader reader)
    {
        AsciiString customEditorName = String.Read(reader);
        AsciiString renderPipelineType = String.Read(reader);
        
        return new(customEditorName,
            renderPipelineType);
    }
}

/* $SerializedShader (10 fields) (None) */
public record class SerializedShader(
    SerializedProperties m_PropInfo,
    SerializedSubShader[] m_SubShaders,
    AsciiString[] m_KeywordNames,
    byte[] m_KeywordFlags,
    AsciiString m_Name,
    AsciiString m_CustomEditorName,
    AsciiString m_FallbackName,
    SerializedShaderDependency[] m_Dependencies,
    SerializedCustomEditorForRenderPipeline[] m_CustomEditorForRenderPipelines,
    bool m_DisableNoSubshadersMessage)
{
    public static SerializedShader Read(EndianBinaryReader reader)
    {
        SerializedProperties m_PropInfo = SerializedProperties.Read(reader);
        SerializedSubShader[] m_SubShaders = Array<SerializedSubShader>.Read(reader);
        AsciiString[] m_KeywordNames = Array<AsciiString>.Read(reader);
        byte[] m_KeywordFlags = Array<byte>.Read(reader);
        AsciiString m_Name = String.Read(reader);
        AsciiString m_CustomEditorName = String.Read(reader);
        AsciiString m_FallbackName = String.Read(reader);
        SerializedShaderDependency[] m_Dependencies = Array<SerializedShaderDependency>.Read(reader);
        SerializedCustomEditorForRenderPipeline[] m_CustomEditorForRenderPipelines = Array<SerializedCustomEditorForRenderPipeline>.Read(reader);
        bool m_DisableNoSubshadersMessage = reader.ReadBool();
        
        return new(m_PropInfo,
            m_SubShaders,
            m_KeywordNames,
            m_KeywordFlags,
            m_Name,
            m_CustomEditorName,
            m_FallbackName,
            m_Dependencies,
            m_CustomEditorForRenderPipelines,
            m_DisableNoSubshadersMessage);
    }
}

/* $Matrix3x4f (12 fields) (None) */
public readonly record struct Matrix3x4f(
    float e00,
    float e01,
    float e02,
    float e03,
    float e10,
    float e11,
    float e12,
    float e13,
    float e20,
    float e21,
    float e22,
    float e23)
{
    public static Matrix3x4f Read(EndianBinaryReader reader)
    {
        float e00 = reader.ReadF32();
        float e01 = reader.ReadF32();
        float e02 = reader.ReadF32();
        float e03 = reader.ReadF32();
        float e10 = reader.ReadF32();
        float e11 = reader.ReadF32();
        float e12 = reader.ReadF32();
        float e13 = reader.ReadF32();
        float e20 = reader.ReadF32();
        float e21 = reader.ReadF32();
        float e22 = reader.ReadF32();
        float e23 = reader.ReadF32();
        
        return new(e00,
            e01,
            e02,
            e03,
            e10,
            e11,
            e12,
            e13,
            e20,
            e21,
            e22,
            e23);
    }
}

/* $Tetrahedron (9 fields) (None) */
public record class Tetrahedron(
    int indices_0,
    int indices_1,
    int indices_2,
    int indices_3,
    int neighbors_0,
    int neighbors_1,
    int neighbors_2,
    int neighbors_3,
    Matrix3x4f matrix)
{
    public static Tetrahedron Read(EndianBinaryReader reader)
    {
        int indices_0 = reader.ReadS32();
        int indices_1 = reader.ReadS32();
        int indices_2 = reader.ReadS32();
        int indices_3 = reader.ReadS32();
        int neighbors_0 = reader.ReadS32();
        int neighbors_1 = reader.ReadS32();
        int neighbors_2 = reader.ReadS32();
        int neighbors_3 = reader.ReadS32();
        Matrix3x4f matrix = Matrix3x4f.Read(reader);
        
        return new(indices_0,
            indices_1,
            indices_2,
            indices_3,
            neighbors_0,
            neighbors_1,
            neighbors_2,
            neighbors_3,
            matrix);
    }
}

/* $ProbeSetTetrahedralization (2 fields) (None) */
public record class ProbeSetTetrahedralization(
    Tetrahedron[] m_Tetrahedra,
    Vector3f[] m_HullRays)
{
    public static ProbeSetTetrahedralization Read(EndianBinaryReader reader)
    {
        Tetrahedron[] m_Tetrahedra = Array<Tetrahedron>.Read(reader);
        Vector3f[] m_HullRays = Array<Vector3f>.Read(reader);
        
        return new(m_Tetrahedra,
            m_HullRays);
    }
}

/* $ProbeSetIndex (3 fields) (None) */
public record class ProbeSetIndex(
    Hash128 m_Hash,
    int m_Offset,
    int m_Size)
{
    public static ProbeSetIndex Read(EndianBinaryReader reader)
    {
        Hash128 m_Hash = Hash128.Read(reader);
        int m_Offset = reader.ReadS32();
        int m_Size = reader.ReadS32();
        
        return new(m_Hash,
            m_Offset,
            m_Size);
    }
}

/* $LightProbeData (4 fields) (None) */
public record class LightProbeData(
    ProbeSetTetrahedralization m_Tetrahedralization,
    ProbeSetIndex[] m_ProbeSets,
    Vector3f[] m_Positions,
    Dictionary<Hash128, int> m_NonTetrahedralizedProbeSetIndexMap)
{
    public static LightProbeData Read(EndianBinaryReader reader)
    {
        ProbeSetTetrahedralization m_Tetrahedralization = ProbeSetTetrahedralization.Read(reader);
        ProbeSetIndex[] m_ProbeSets = Array<ProbeSetIndex>.Read(reader);
        Vector3f[] m_Positions = Array<Vector3f>.Read(reader);
        Dictionary<Hash128, int> m_NonTetrahedralizedProbeSetIndexMap = Map<Hash128, int>.Read(reader);
        
        return new(m_Tetrahedralization,
            m_ProbeSets,
            m_Positions,
            m_NonTetrahedralizedProbeSetIndexMap);
    }
}

/* $SphericalHarmonicsL2 (27 fields) (None) */
public readonly record struct SphericalHarmonicsL2(
    float sh_0,
    float sh_1,
    float sh_2,
    float sh_3,
    float sh_4,
    float sh_5,
    float sh_6,
    float sh_7,
    float sh_8,
    float sh_9,
    float sh_10,
    float sh_11,
    float sh_12,
    float sh_13,
    float sh_14,
    float sh_15,
    float sh_16,
    float sh_17,
    float sh_18,
    float sh_19,
    float sh_20,
    float sh_21,
    float sh_22,
    float sh_23,
    float sh_24,
    float sh_25,
    float sh_26)
{
    public static SphericalHarmonicsL2 Read(EndianBinaryReader reader)
    {
        float sh_0 = reader.ReadF32();
        float sh_1 = reader.ReadF32();
        float sh_2 = reader.ReadF32();
        float sh_3 = reader.ReadF32();
        float sh_4 = reader.ReadF32();
        float sh_5 = reader.ReadF32();
        float sh_6 = reader.ReadF32();
        float sh_7 = reader.ReadF32();
        float sh_8 = reader.ReadF32();
        float sh_9 = reader.ReadF32();
        float sh_10 = reader.ReadF32();
        float sh_11 = reader.ReadF32();
        float sh_12 = reader.ReadF32();
        float sh_13 = reader.ReadF32();
        float sh_14 = reader.ReadF32();
        float sh_15 = reader.ReadF32();
        float sh_16 = reader.ReadF32();
        float sh_17 = reader.ReadF32();
        float sh_18 = reader.ReadF32();
        float sh_19 = reader.ReadF32();
        float sh_20 = reader.ReadF32();
        float sh_21 = reader.ReadF32();
        float sh_22 = reader.ReadF32();
        float sh_23 = reader.ReadF32();
        float sh_24 = reader.ReadF32();
        float sh_25 = reader.ReadF32();
        float sh_26 = reader.ReadF32();
        
        return new(sh_0,
            sh_1,
            sh_2,
            sh_3,
            sh_4,
            sh_5,
            sh_6,
            sh_7,
            sh_8,
            sh_9,
            sh_10,
            sh_11,
            sh_12,
            sh_13,
            sh_14,
            sh_15,
            sh_16,
            sh_17,
            sh_18,
            sh_19,
            sh_20,
            sh_21,
            sh_22,
            sh_23,
            sh_24,
            sh_25,
            sh_26);
    }
}

/* $LightProbeOcclusion (3 fields) (None) */
public record class LightProbeOcclusion(
    int[] m_ProbeOcclusionLightIndex,
    float[] m_Occlusion,
    sbyte[] m_OcclusionMaskChannel)
{
    public static LightProbeOcclusion Read(EndianBinaryReader reader)
    {
        int[] m_ProbeOcclusionLightIndex = Array<int>.Read(reader);
        float[] m_Occlusion = Array<float>.Read(reader);
        sbyte[] m_OcclusionMaskChannel = Array<sbyte>.Read(reader);
        
        return new(m_ProbeOcclusionLightIndex,
            m_Occlusion,
            m_OcclusionMaskChannel);
    }
}

/* $SubMesh (7 fields) (None) */
public record class SubMesh(
    uint firstByte,
    uint indexCount,
    int topology,
    uint baseVertex,
    uint firstVertex,
    uint vertexCount,
    AABB localAABB)
{
    public static SubMesh Read(EndianBinaryReader reader)
    {
        uint firstByte = reader.ReadU32();
        uint indexCount = reader.ReadU32();
        int topology = reader.ReadS32();
        uint baseVertex = reader.ReadU32();
        uint firstVertex = reader.ReadU32();
        uint vertexCount = reader.ReadU32();
        AABB localAABB = AABB.Read(reader);
        
        return new(firstByte,
            indexCount,
            topology,
            baseVertex,
            firstVertex,
            vertexCount,
            localAABB);
    }
}

/* $BlendShapeVertex (4 fields) (None) */
public record class BlendShapeVertex(
    Vector3f vertex,
    Vector3f normal,
    Vector3f tangent,
    uint index)
{
    public static BlendShapeVertex Read(EndianBinaryReader reader)
    {
        Vector3f vertex = Vector3f.Read(reader);
        Vector3f normal = Vector3f.Read(reader);
        Vector3f tangent = Vector3f.Read(reader);
        uint index = reader.ReadU32();
        
        return new(vertex,
            normal,
            tangent,
            index);
    }
}

/* $MeshBlendShape (4 fields) (None) */
public readonly record struct MeshBlendShape(
    uint firstVertex,
    uint vertexCount,
    bool hasNormals,
    bool hasTangents)
{
    public static MeshBlendShape Read(EndianBinaryReader reader)
    {
        uint firstVertex = reader.ReadU32();
        uint vertexCount = reader.ReadU32();
        bool hasNormals = reader.ReadBool();
        bool hasTangents = reader.ReadBool();
        
        return new(firstVertex,
            vertexCount,
            hasNormals,
            hasTangents);
    }
}

/* $MeshBlendShapeChannel (4 fields) (None) */
public record class MeshBlendShapeChannel(
    AsciiString name,
    uint nameHash,
    int frameIndex,
    int frameCount)
{
    public static MeshBlendShapeChannel Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        uint nameHash = reader.ReadU32();
        int frameIndex = reader.ReadS32();
        int frameCount = reader.ReadS32();
        
        return new(name,
            nameHash,
            frameIndex,
            frameCount);
    }
}

/* $BlendShapeData (4 fields) (None) */
public record class BlendShapeData(
    BlendShapeVertex[] vertices,
    MeshBlendShape[] shapes,
    MeshBlendShapeChannel[] channels,
    float[] fullWeights)
{
    public static BlendShapeData Read(EndianBinaryReader reader)
    {
        BlendShapeVertex[] vertices = Array<BlendShapeVertex>.Read(reader);
        MeshBlendShape[] shapes = Array<MeshBlendShape>.Read(reader);
        MeshBlendShapeChannel[] channels = Array<MeshBlendShapeChannel>.Read(reader);
        float[] fullWeights = Array<float>.Read(reader);
        
        return new(vertices,
            shapes,
            channels,
            fullWeights);
    }
}

/* $Matrix4x4f (16 fields) (None) */
public readonly record struct Matrix4x4f(
    float e00,
    float e01,
    float e02,
    float e03,
    float e10,
    float e11,
    float e12,
    float e13,
    float e20,
    float e21,
    float e22,
    float e23,
    float e30,
    float e31,
    float e32,
    float e33)
{
    public static Matrix4x4f Read(EndianBinaryReader reader)
    {
        float e00 = reader.ReadF32();
        float e01 = reader.ReadF32();
        float e02 = reader.ReadF32();
        float e03 = reader.ReadF32();
        float e10 = reader.ReadF32();
        float e11 = reader.ReadF32();
        float e12 = reader.ReadF32();
        float e13 = reader.ReadF32();
        float e20 = reader.ReadF32();
        float e21 = reader.ReadF32();
        float e22 = reader.ReadF32();
        float e23 = reader.ReadF32();
        float e30 = reader.ReadF32();
        float e31 = reader.ReadF32();
        float e32 = reader.ReadF32();
        float e33 = reader.ReadF32();
        
        return new(e00,
            e01,
            e02,
            e03,
            e10,
            e11,
            e12,
            e13,
            e20,
            e21,
            e22,
            e23,
            e30,
            e31,
            e32,
            e33);
    }
}

/* $MinMaxAABB (2 fields) (None) */
public record class MinMaxAABB(
    Vector3f m_Min,
    Vector3f m_Max)
{
    public static MinMaxAABB Read(EndianBinaryReader reader)
    {
        Vector3f m_Min = Vector3f.Read(reader);
        Vector3f m_Max = Vector3f.Read(reader);
        
        return new(m_Min,
            m_Max);
    }
}

/* $VariableBoneCountWeights (1 fields) (None) */
public record class VariableBoneCountWeights(
    uint[] m_Data)
{
    public static VariableBoneCountWeights Read(EndianBinaryReader reader)
    {
        uint[] m_Data = Array<uint>.Read(reader);
        
        return new(m_Data);
    }
}

/* $ChannelInfo (4 fields) (None) */
public readonly record struct ChannelInfo(
    byte stream,
    byte offset,
    byte format,
    byte dimension)
{
    public static ChannelInfo Read(EndianBinaryReader reader)
    {
        byte stream = reader.ReadU8();
        byte offset = reader.ReadU8();
        byte format = reader.ReadU8();
        byte dimension = reader.ReadU8();
        
        return new(stream,
            offset,
            format,
            dimension);
    }
}

/* $VertexData (3 fields) (None) */
public record class VertexData(
    uint m_VertexCount,
    ChannelInfo[] m_Channels,
    TypelessData m_DataSize)
{
    public static VertexData Read(EndianBinaryReader reader)
    {
        uint m_VertexCount = reader.ReadU32();
        ChannelInfo[] m_Channels = Array<ChannelInfo>.Read(reader);
        TypelessData m_DataSize = TypelessData.Read(reader);
        
        return new(m_VertexCount,
            m_Channels,
            m_DataSize);
    }
}

/* $CompressedMesh (11 fields) (None) */
public record class CompressedMesh(
    PackedBitVector m_Vertices,
    PackedBitVector m_UV,
    PackedBitVector m_Normals,
    PackedBitVector m_Tangents,
    PackedBitVector m_Weights,
    PackedBitVector m_NormalSigns,
    PackedBitVector m_TangentSigns,
    PackedBitVector m_FloatColors,
    PackedBitVector m_BoneIndices,
    PackedBitVector m_Triangles,
    uint m_UVInfo)
{
    public static CompressedMesh Read(EndianBinaryReader reader)
    {
        PackedBitVector m_Vertices = PackedBitVector.Read(reader);
        PackedBitVector m_UV = PackedBitVector.Read(reader);
        PackedBitVector m_Normals = PackedBitVector.Read(reader);
        PackedBitVector m_Tangents = PackedBitVector.Read(reader);
        PackedBitVector m_Weights = PackedBitVector.Read(reader);
        PackedBitVector m_NormalSigns = PackedBitVector.Read(reader);
        PackedBitVector m_TangentSigns = PackedBitVector.Read(reader);
        PackedBitVector m_FloatColors = PackedBitVector.Read(reader);
        PackedBitVector m_BoneIndices = PackedBitVector.Read(reader);
        PackedBitVector m_Triangles = PackedBitVector.Read(reader);
        uint m_UVInfo = reader.ReadU32();
        
        return new(m_Vertices,
            m_UV,
            m_Normals,
            m_Tangents,
            m_Weights,
            m_NormalSigns,
            m_TangentSigns,
            m_FloatColors,
            m_BoneIndices,
            m_Triangles,
            m_UVInfo);
    }
}

/* $Vector4f (4 fields) (None) */
public readonly record struct Vector4f(
    float x,
    float y,
    float z,
    float w)
{
    public static Vector4f Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        float z = reader.ReadF32();
        float w = reader.ReadF32();
        
        return new(x,
            y,
            z,
            w);
    }
}

/* $StaticBatchInfo (2 fields) (None) */
public readonly record struct StaticBatchInfo(
    ushort firstSubMesh,
    ushort subMeshCount)
{
    public static StaticBatchInfo Read(EndianBinaryReader reader)
    {
        ushort firstSubMesh = reader.ReadU16();
        ushort subMeshCount = reader.ReadU16();
        
        return new(firstSubMesh,
            subMeshCount);
    }
}

/* $ShadowSettings (9 fields) (None) */
public record class ShadowSettings(
    int m_Type,
    int m_Resolution,
    int m_CustomResolution,
    float m_Strength,
    float m_Bias,
    float m_NormalBias,
    float m_NearPlane,
    Matrix4x4f m_CullingMatrixOverride,
    bool m_UseCullingMatrixOverride)
{
    public static ShadowSettings Read(EndianBinaryReader reader)
    {
        int m_Type = reader.ReadS32();
        int m_Resolution = reader.ReadS32();
        int m_CustomResolution = reader.ReadS32();
        float m_Strength = reader.ReadF32();
        float m_Bias = reader.ReadF32();
        float m_NormalBias = reader.ReadF32();
        float m_NearPlane = reader.ReadF32();
        Matrix4x4f m_CullingMatrixOverride = Matrix4x4f.Read(reader);
        bool m_UseCullingMatrixOverride = reader.ReadBool();
        
        return new(m_Type,
            m_Resolution,
            m_CustomResolution,
            m_Strength,
            m_Bias,
            m_NormalBias,
            m_NearPlane,
            m_CullingMatrixOverride,
            m_UseCullingMatrixOverride);
    }
}

/* $LightmapBakeMode (2 fields) (None) */
public readonly record struct LightmapBakeMode(
    int lightmapBakeType,
    int mixedLightingMode)
{
    public static LightmapBakeMode Read(EndianBinaryReader reader)
    {
        int lightmapBakeType = reader.ReadS32();
        int mixedLightingMode = reader.ReadS32();
        
        return new(lightmapBakeType,
            mixedLightingMode);
    }
}

/* $LightBakingOutput (4 fields) (None) */
public record class LightBakingOutput(
    int probeOcclusionLightIndex,
    int occlusionMaskChannel,
    LightmapBakeMode lightmapBakeMode,
    bool isBaked)
{
    public static LightBakingOutput Read(EndianBinaryReader reader)
    {
        int probeOcclusionLightIndex = reader.ReadS32();
        int occlusionMaskChannel = reader.ReadS32();
        LightmapBakeMode lightmapBakeMode = LightmapBakeMode.Read(reader);
        bool isBaked = reader.ReadBool();
        
        return new(probeOcclusionLightIndex,
            occlusionMaskChannel,
            lightmapBakeMode,
            isBaked);
    }
}

/* $EnlightenRendererInformation (4 fields) (None) */
public record class EnlightenRendererInformation(
    PPtr<Object> renderer,
    Vector4f dynamicLightmapSTInSystem,
    int systemId,
    Hash128 instanceHash)
{
    public static EnlightenRendererInformation Read(EndianBinaryReader reader)
    {
        PPtr<Object> renderer = PPtr<Object>.Read(reader);
        Vector4f dynamicLightmapSTInSystem = Vector4f.Read(reader);
        int systemId = reader.ReadS32();
        Hash128 instanceHash = Hash128.Read(reader);
        
        return new(renderer,
            dynamicLightmapSTInSystem,
            systemId,
            instanceHash);
    }
}

/* $EnlightenSystemInformation (7 fields) (None) */
public record class EnlightenSystemInformation(
    uint rendererIndex,
    uint rendererSize,
    int atlasIndex,
    int atlasOffsetX,
    int atlasOffsetY,
    Hash128 inputSystemHash,
    Hash128 radiositySystemHash)
{
    public static EnlightenSystemInformation Read(EndianBinaryReader reader)
    {
        uint rendererIndex = reader.ReadU32();
        uint rendererSize = reader.ReadU32();
        int atlasIndex = reader.ReadS32();
        int atlasOffsetX = reader.ReadS32();
        int atlasOffsetY = reader.ReadS32();
        Hash128 inputSystemHash = Hash128.Read(reader);
        Hash128 radiositySystemHash = Hash128.Read(reader);
        
        return new(rendererIndex,
            rendererSize,
            atlasIndex,
            atlasOffsetX,
            atlasOffsetY,
            inputSystemHash,
            radiositySystemHash);
    }
}

/* $EnlightenSystemAtlasInformation (3 fields) (None) */
public record class EnlightenSystemAtlasInformation(
    int atlasSize,
    Hash128 atlasHash,
    int firstSystemId)
{
    public static EnlightenSystemAtlasInformation Read(EndianBinaryReader reader)
    {
        int atlasSize = reader.ReadS32();
        Hash128 atlasHash = Hash128.Read(reader);
        int firstSystemId = reader.ReadS32();
        
        return new(atlasSize,
            atlasHash,
            firstSystemId);
    }
}

/* $EnlightenTerrainChunksInformation (3 fields) (None) */
public readonly record struct EnlightenTerrainChunksInformation(
    int firstSystemId,
    int numChunksInX,
    int numChunksInY)
{
    public static EnlightenTerrainChunksInformation Read(EndianBinaryReader reader)
    {
        int firstSystemId = reader.ReadS32();
        int numChunksInX = reader.ReadS32();
        int numChunksInY = reader.ReadS32();
        
        return new(firstSystemId,
            numChunksInX,
            numChunksInY);
    }
}

/* $EnlightenSceneMapping (5 fields) (None) */
public record class EnlightenSceneMapping(
    EnlightenRendererInformation[] m_Renderers,
    EnlightenSystemInformation[] m_Systems,
    Hash128[] m_Probesets,
    EnlightenSystemAtlasInformation[] m_SystemAtlases,
    EnlightenTerrainChunksInformation[] m_TerrainChunks)
{
    public static EnlightenSceneMapping Read(EndianBinaryReader reader)
    {
        EnlightenRendererInformation[] m_Renderers = Array<EnlightenRendererInformation>.Read(reader);
        EnlightenSystemInformation[] m_Systems = Array<EnlightenSystemInformation>.Read(reader);
        Hash128[] m_Probesets = Array<Hash128>.Read(reader);
        EnlightenSystemAtlasInformation[] m_SystemAtlases = Array<EnlightenSystemAtlasInformation>.Read(reader);
        EnlightenTerrainChunksInformation[] m_TerrainChunks = Array<EnlightenTerrainChunksInformation>.Read(reader);
        
        return new(m_Renderers,
            m_Systems,
            m_Probesets,
            m_SystemAtlases,
            m_TerrainChunks);
    }
}

/* $LightmapData (3 fields) (None) */
public record class LightmapData(
    PPtr<Texture2D> m_Lightmap,
    PPtr<Texture2D> m_DirLightmap,
    PPtr<Texture2D> m_ShadowMask)
{
    public static LightmapData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> m_Lightmap = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_DirLightmap = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_ShadowMask = PPtr<Texture2D>.Read(reader);
        
        return new(m_Lightmap,
            m_DirLightmap,
            m_ShadowMask);
    }
}

/* $GISettings (6 fields) (None) */
public readonly record struct GISettings(
    float m_BounceScale,
    float m_IndirectOutputScale,
    float m_AlbedoBoost,
    uint m_EnvironmentLightingMode,
    bool m_EnableBakedLightmaps,
    bool m_EnableRealtimeLightmaps)
{
    public static GISettings Read(EndianBinaryReader reader)
    {
        float m_BounceScale = reader.ReadF32();
        float m_IndirectOutputScale = reader.ReadF32();
        float m_AlbedoBoost = reader.ReadF32();
        uint m_EnvironmentLightingMode = reader.ReadU32();
        bool m_EnableBakedLightmaps = reader.ReadBool();
        bool m_EnableRealtimeLightmaps = reader.ReadBool();
        
        return new(m_BounceScale,
            m_IndirectOutputScale,
            m_AlbedoBoost,
            m_EnvironmentLightingMode,
            m_EnableBakedLightmaps,
            m_EnableRealtimeLightmaps);
    }
}

/* $MinMaxCurve (5 fields) (None) */
public record class MinMaxCurve(
    ushort minMaxState,
    float scalar,
    float minScalar,
    AnimationCurve maxCurve,
    AnimationCurve minCurve)
{
    public static MinMaxCurve Read(EndianBinaryReader reader)
    {
        ushort minMaxState = reader.ReadU16();
        float scalar = reader.ReadF32();
        float minScalar = reader.ReadF32();
        AnimationCurve maxCurve = AnimationCurve.Read(reader);
        AnimationCurve minCurve = AnimationCurve.Read(reader);
        
        return new(minMaxState,
            scalar,
            minScalar,
            maxCurve,
            minCurve);
    }
}

/* $Gradient (28 fields) (None) */
public record class Gradient(
    ColorRGBA key0,
    ColorRGBA key1,
    ColorRGBA key2,
    ColorRGBA key3,
    ColorRGBA key4,
    ColorRGBA key5,
    ColorRGBA key6,
    ColorRGBA key7,
    ushort ctime0,
    ushort ctime1,
    ushort ctime2,
    ushort ctime3,
    ushort ctime4,
    ushort ctime5,
    ushort ctime6,
    ushort ctime7,
    ushort atime0,
    ushort atime1,
    ushort atime2,
    ushort atime3,
    ushort atime4,
    ushort atime5,
    ushort atime6,
    ushort atime7,
    byte m_Mode,
    sbyte m_ColorSpace,
    byte m_NumColorKeys,
    byte m_NumAlphaKeys)
{
    public static Gradient Read(EndianBinaryReader reader)
    {
        ColorRGBA key0 = ColorRGBA.Read(reader);
        ColorRGBA key1 = ColorRGBA.Read(reader);
        ColorRGBA key2 = ColorRGBA.Read(reader);
        ColorRGBA key3 = ColorRGBA.Read(reader);
        ColorRGBA key4 = ColorRGBA.Read(reader);
        ColorRGBA key5 = ColorRGBA.Read(reader);
        ColorRGBA key6 = ColorRGBA.Read(reader);
        ColorRGBA key7 = ColorRGBA.Read(reader);
        ushort ctime0 = reader.ReadU16();
        ushort ctime1 = reader.ReadU16();
        ushort ctime2 = reader.ReadU16();
        ushort ctime3 = reader.ReadU16();
        ushort ctime4 = reader.ReadU16();
        ushort ctime5 = reader.ReadU16();
        ushort ctime6 = reader.ReadU16();
        ushort ctime7 = reader.ReadU16();
        ushort atime0 = reader.ReadU16();
        ushort atime1 = reader.ReadU16();
        ushort atime2 = reader.ReadU16();
        ushort atime3 = reader.ReadU16();
        ushort atime4 = reader.ReadU16();
        ushort atime5 = reader.ReadU16();
        ushort atime6 = reader.ReadU16();
        ushort atime7 = reader.ReadU16();
        byte m_Mode = reader.ReadU8();
        sbyte m_ColorSpace = reader.ReadS8();
        byte m_NumColorKeys = reader.ReadU8();
        byte m_NumAlphaKeys = reader.ReadU8();
        
        return new(key0,
            key1,
            key2,
            key3,
            key4,
            key5,
            key6,
            key7,
            ctime0,
            ctime1,
            ctime2,
            ctime3,
            ctime4,
            ctime5,
            ctime6,
            ctime7,
            atime0,
            atime1,
            atime2,
            atime3,
            atime4,
            atime5,
            atime6,
            atime7,
            m_Mode,
            m_ColorSpace,
            m_NumColorKeys,
            m_NumAlphaKeys);
    }
}

/* $MinMaxGradient (5 fields) (None) */
public record class MinMaxGradient(
    ushort minMaxState,
    ColorRGBA minColor,
    ColorRGBA maxColor,
    Gradient maxGradient,
    Gradient minGradient)
{
    public static MinMaxGradient Read(EndianBinaryReader reader)
    {
        ushort minMaxState = reader.ReadU16();
        ColorRGBA minColor = ColorRGBA.Read(reader);
        ColorRGBA maxColor = ColorRGBA.Read(reader);
        Gradient maxGradient = Gradient.Read(reader);
        Gradient minGradient = Gradient.Read(reader);
        
        return new(minMaxState,
            minColor,
            maxColor,
            maxGradient,
            minGradient);
    }
}

/* $InitialModule (17 fields) (None) */
public record class InitialModule(
    bool enabled,
    MinMaxCurve startLifetime,
    MinMaxCurve startSpeed,
    MinMaxGradient startColor,
    MinMaxCurve startSize,
    MinMaxCurve startSizeY,
    MinMaxCurve startSizeZ,
    MinMaxCurve startRotationX,
    MinMaxCurve startRotationY,
    MinMaxCurve startRotation,
    float randomizeRotationDirection,
    int gravitySource,
    int maxNumParticles,
    Vector3f customEmitterVelocity,
    bool size3D,
    bool rotation3D,
    MinMaxCurve gravityModifier)
{
    public static InitialModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve startLifetime = MinMaxCurve.Read(reader);
        MinMaxCurve startSpeed = MinMaxCurve.Read(reader);
        MinMaxGradient startColor = MinMaxGradient.Read(reader);
        MinMaxCurve startSize = MinMaxCurve.Read(reader);
        MinMaxCurve startSizeY = MinMaxCurve.Read(reader);
        MinMaxCurve startSizeZ = MinMaxCurve.Read(reader);
        MinMaxCurve startRotationX = MinMaxCurve.Read(reader);
        MinMaxCurve startRotationY = MinMaxCurve.Read(reader);
        MinMaxCurve startRotation = MinMaxCurve.Read(reader);
        float randomizeRotationDirection = reader.ReadF32();
        int gravitySource = reader.ReadS32();
        int maxNumParticles = reader.ReadS32();
        Vector3f customEmitterVelocity = Vector3f.Read(reader);
        bool size3D = reader.ReadBool();
        bool rotation3D = reader.ReadBool();
        MinMaxCurve gravityModifier = MinMaxCurve.Read(reader);
        
        return new(enabled,
            startLifetime,
            startSpeed,
            startColor,
            startSize,
            startSizeY,
            startSizeZ,
            startRotationX,
            startRotationY,
            startRotation,
            randomizeRotationDirection,
            gravitySource,
            maxNumParticles,
            customEmitterVelocity,
            size3D,
            rotation3D,
            gravityModifier);
    }
}

/* $MultiModeParameter (3 fields) (None) */
public record class MultiModeParameter(
    int mode,
    float spread,
    MinMaxCurve speed)
{
    public static MultiModeParameter Read(EndianBinaryReader reader)
    {
        int mode = reader.ReadS32();
        float spread = reader.ReadF32();
        MinMaxCurve speed = MinMaxCurve.Read(reader);
        
        return new(mode,
            spread,
            speed);
    }
}

/* $ShapeModule (34 fields) (None) */
public record class ShapeModule(
    bool enabled,
    int type,
    float angle,
    float length,
    Vector3f boxThickness,
    float radiusThickness,
    float donutRadius,
    Vector3f m_Position,
    Vector3f m_Rotation,
    Vector3f m_Scale,
    int placementMode,
    int m_MeshMaterialIndex,
    float m_MeshNormalOffset,
    MultiModeParameter m_MeshSpawn,
    PPtr<Mesh> m_Mesh,
    PPtr<MeshRenderer> m_MeshRenderer,
    PPtr<SkinnedMeshRenderer> m_SkinnedMeshRenderer,
    PPtr<Sprite> m_Sprite,
    PPtr<SpriteRenderer> m_SpriteRenderer,
    bool m_UseMeshMaterialIndex,
    bool m_UseMeshColors,
    bool alignToDirection,
    PPtr<Texture2D> m_Texture,
    int m_TextureClipChannel,
    float m_TextureClipThreshold,
    int m_TextureUVChannel,
    bool m_TextureColorAffectsParticles,
    bool m_TextureAlphaAffectsParticles,
    bool m_TextureBilinearFiltering,
    float randomDirectionAmount,
    float sphericalDirectionAmount,
    float randomPositionAmount,
    MultiModeParameter radius,
    MultiModeParameter arc)
{
    public static ShapeModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int type = reader.ReadS32();
        float angle = reader.ReadF32();
        float length = reader.ReadF32();
        Vector3f boxThickness = Vector3f.Read(reader);
        float radiusThickness = reader.ReadF32();
        float donutRadius = reader.ReadF32();
        Vector3f m_Position = Vector3f.Read(reader);
        Vector3f m_Rotation = Vector3f.Read(reader);
        Vector3f m_Scale = Vector3f.Read(reader);
        int placementMode = reader.ReadS32();
        int m_MeshMaterialIndex = reader.ReadS32();
        float m_MeshNormalOffset = reader.ReadF32();
        MultiModeParameter m_MeshSpawn = MultiModeParameter.Read(reader);
        PPtr<Mesh> m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<MeshRenderer> m_MeshRenderer = PPtr<MeshRenderer>.Read(reader);
        PPtr<SkinnedMeshRenderer> m_SkinnedMeshRenderer = PPtr<SkinnedMeshRenderer>.Read(reader);
        PPtr<Sprite> m_Sprite = PPtr<Sprite>.Read(reader);
        PPtr<SpriteRenderer> m_SpriteRenderer = PPtr<SpriteRenderer>.Read(reader);
        bool m_UseMeshMaterialIndex = reader.ReadBool();
        bool m_UseMeshColors = reader.ReadBool();
        bool alignToDirection = reader.ReadBool();
        PPtr<Texture2D> m_Texture = PPtr<Texture2D>.Read(reader);
        int m_TextureClipChannel = reader.ReadS32();
        float m_TextureClipThreshold = reader.ReadF32();
        int m_TextureUVChannel = reader.ReadS32();
        bool m_TextureColorAffectsParticles = reader.ReadBool();
        bool m_TextureAlphaAffectsParticles = reader.ReadBool();
        bool m_TextureBilinearFiltering = reader.ReadBool();
        float randomDirectionAmount = reader.ReadF32();
        float sphericalDirectionAmount = reader.ReadF32();
        float randomPositionAmount = reader.ReadF32();
        MultiModeParameter radius = MultiModeParameter.Read(reader);
        MultiModeParameter arc = MultiModeParameter.Read(reader);
        
        return new(enabled,
            type,
            angle,
            length,
            boxThickness,
            radiusThickness,
            donutRadius,
            m_Position,
            m_Rotation,
            m_Scale,
            placementMode,
            m_MeshMaterialIndex,
            m_MeshNormalOffset,
            m_MeshSpawn,
            m_Mesh,
            m_MeshRenderer,
            m_SkinnedMeshRenderer,
            m_Sprite,
            m_SpriteRenderer,
            m_UseMeshMaterialIndex,
            m_UseMeshColors,
            alignToDirection,
            m_Texture,
            m_TextureClipChannel,
            m_TextureClipThreshold,
            m_TextureUVChannel,
            m_TextureColorAffectsParticles,
            m_TextureAlphaAffectsParticles,
            m_TextureBilinearFiltering,
            randomDirectionAmount,
            sphericalDirectionAmount,
            randomPositionAmount,
            radius,
            arc);
    }
}

/* $ParticleSystemEmissionBurst (5 fields) (None) */
public record class ParticleSystemEmissionBurst(
    float time,
    MinMaxCurve countCurve,
    int cycleCount,
    float repeatInterval,
    float probability)
{
    public static ParticleSystemEmissionBurst Read(EndianBinaryReader reader)
    {
        float time = reader.ReadF32();
        MinMaxCurve countCurve = MinMaxCurve.Read(reader);
        int cycleCount = reader.ReadS32();
        float repeatInterval = reader.ReadF32();
        float probability = reader.ReadF32();
        
        return new(time,
            countCurve,
            cycleCount,
            repeatInterval,
            probability);
    }
}

/* $EmissionModule (5 fields) (None) */
public record class EmissionModule(
    bool enabled,
    MinMaxCurve rateOverTime,
    MinMaxCurve rateOverDistance,
    int m_BurstCount,
    ParticleSystemEmissionBurst[] m_Bursts)
{
    public static EmissionModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve rateOverTime = MinMaxCurve.Read(reader);
        MinMaxCurve rateOverDistance = MinMaxCurve.Read(reader);
        int m_BurstCount = reader.ReadS32();
        ParticleSystemEmissionBurst[] m_Bursts = Array<ParticleSystemEmissionBurst>.Read(reader);
        
        return new(enabled,
            rateOverTime,
            rateOverDistance,
            m_BurstCount,
            m_Bursts);
    }
}

/* $SizeModule (5 fields) (None) */
public record class SizeModule(
    bool enabled,
    MinMaxCurve curve,
    MinMaxCurve y,
    MinMaxCurve z,
    bool separateAxes)
{
    public static SizeModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve curve = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve z = MinMaxCurve.Read(reader);
        bool separateAxes = reader.ReadBool();
        
        return new(enabled,
            curve,
            y,
            z,
            separateAxes);
    }
}

/* $RotationModule (5 fields) (None) */
public record class RotationModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve curve,
    bool separateAxes)
{
    public static RotationModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve x = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve curve = MinMaxCurve.Read(reader);
        bool separateAxes = reader.ReadBool();
        
        return new(enabled,
            x,
            y,
            curve,
            separateAxes);
    }
}

/* $ColorModule (2 fields) (None) */
public record class ColorModule(
    bool enabled,
    MinMaxGradient gradient)
{
    public static ColorModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxGradient gradient = MinMaxGradient.Read(reader);
        
        return new(enabled,
            gradient);
    }
}

/* $SpriteData (1 fields) (None) */
public record class SpriteData(
    PPtr<Object> sprite)
{
    public static SpriteData Read(EndianBinaryReader reader)
    {
        PPtr<Object> sprite = PPtr<Object>.Read(reader);
        
        return new(sprite);
    }
}

/* $UVModule (17 fields) (None) */
public record class UVModule(
    bool enabled,
    int mode,
    int timeMode,
    float fps,
    MinMaxCurve frameOverTime,
    MinMaxCurve startFrame,
    Vector2f speedRange,
    int tilesX,
    int tilesY,
    int animationType,
    int rowIndex,
    float cycles,
    int uvChannelMask,
    int rowMode,
    SpriteData[] sprites,
    float flipU,
    float flipV)
{
    public static UVModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int mode = reader.ReadS32();
        int timeMode = reader.ReadS32();
        float fps = reader.ReadF32();
        MinMaxCurve frameOverTime = MinMaxCurve.Read(reader);
        MinMaxCurve startFrame = MinMaxCurve.Read(reader);
        Vector2f speedRange = Vector2f.Read(reader);
        int tilesX = reader.ReadS32();
        int tilesY = reader.ReadS32();
        int animationType = reader.ReadS32();
        int rowIndex = reader.ReadS32();
        float cycles = reader.ReadF32();
        int uvChannelMask = reader.ReadS32();
        int rowMode = reader.ReadS32();
        SpriteData[] sprites = Array<SpriteData>.Read(reader);
        float flipU = reader.ReadF32();
        float flipV = reader.ReadF32();
        
        return new(enabled,
            mode,
            timeMode,
            fps,
            frameOverTime,
            startFrame,
            speedRange,
            tilesX,
            tilesY,
            animationType,
            rowIndex,
            cycles,
            uvChannelMask,
            rowMode,
            sprites,
            flipU,
            flipV);
    }
}

/* $VelocityModule (13 fields) (None) */
public record class VelocityModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    MinMaxCurve orbitalX,
    MinMaxCurve orbitalY,
    MinMaxCurve orbitalZ,
    MinMaxCurve orbitalOffsetX,
    MinMaxCurve orbitalOffsetY,
    MinMaxCurve orbitalOffsetZ,
    MinMaxCurve radial,
    MinMaxCurve speedModifier,
    bool inWorldSpace)
{
    public static VelocityModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve x = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve z = MinMaxCurve.Read(reader);
        MinMaxCurve orbitalX = MinMaxCurve.Read(reader);
        MinMaxCurve orbitalY = MinMaxCurve.Read(reader);
        MinMaxCurve orbitalZ = MinMaxCurve.Read(reader);
        MinMaxCurve orbitalOffsetX = MinMaxCurve.Read(reader);
        MinMaxCurve orbitalOffsetY = MinMaxCurve.Read(reader);
        MinMaxCurve orbitalOffsetZ = MinMaxCurve.Read(reader);
        MinMaxCurve radial = MinMaxCurve.Read(reader);
        MinMaxCurve speedModifier = MinMaxCurve.Read(reader);
        bool inWorldSpace = reader.ReadBool();
        
        return new(enabled,
            x,
            y,
            z,
            orbitalX,
            orbitalY,
            orbitalZ,
            orbitalOffsetX,
            orbitalOffsetY,
            orbitalOffsetZ,
            radial,
            speedModifier,
            inWorldSpace);
    }
}

/* $InheritVelocityModule (3 fields) (None) */
public record class InheritVelocityModule(
    bool enabled,
    int m_Mode,
    MinMaxCurve m_Curve)
{
    public static InheritVelocityModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int m_Mode = reader.ReadS32();
        MinMaxCurve m_Curve = MinMaxCurve.Read(reader);
        
        return new(enabled,
            m_Mode,
            m_Curve);
    }
}

/* $LifetimeByEmitterSpeedModule (3 fields) (None) */
public record class LifetimeByEmitterSpeedModule(
    bool enabled,
    MinMaxCurve m_Curve,
    Vector2f m_Range)
{
    public static LifetimeByEmitterSpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve m_Curve = MinMaxCurve.Read(reader);
        Vector2f m_Range = Vector2f.Read(reader);
        
        return new(enabled,
            m_Curve,
            m_Range);
    }
}

/* $ForceModule (6 fields) (None) */
public record class ForceModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    bool inWorldSpace,
    bool randomizePerFrame)
{
    public static ForceModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve x = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve z = MinMaxCurve.Read(reader);
        bool inWorldSpace = reader.ReadBool();
        bool randomizePerFrame = reader.ReadBool();
        
        return new(enabled,
            x,
            y,
            z,
            inWorldSpace,
            randomizePerFrame);
    }
}

/* $ExternalForcesModule (5 fields) (None) */
public record class ExternalForcesModule(
    bool enabled,
    MinMaxCurve multiplierCurve,
    int influenceFilter,
    BitField influenceMask,
    PPtr<ParticleSystemForceField>[] influenceList)
{
    public static ExternalForcesModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve multiplierCurve = MinMaxCurve.Read(reader);
        int influenceFilter = reader.ReadS32();
        BitField influenceMask = BitField.Read(reader);
        PPtr<ParticleSystemForceField>[] influenceList = Array<PPtr<ParticleSystemForceField>>.Read(reader);
        
        return new(enabled,
            multiplierCurve,
            influenceFilter,
            influenceMask,
            influenceList);
    }
}

/* $ClampVelocityModule (11 fields) (None) */
public record class ClampVelocityModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve z,
    MinMaxCurve magnitude,
    bool separateAxis,
    bool inWorldSpace,
    bool multiplyDragByParticleSize,
    bool multiplyDragByParticleVelocity,
    float dampen,
    MinMaxCurve drag)
{
    public static ClampVelocityModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve x = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve z = MinMaxCurve.Read(reader);
        MinMaxCurve magnitude = MinMaxCurve.Read(reader);
        bool separateAxis = reader.ReadBool();
        bool inWorldSpace = reader.ReadBool();
        bool multiplyDragByParticleSize = reader.ReadBool();
        bool multiplyDragByParticleVelocity = reader.ReadBool();
        float dampen = reader.ReadF32();
        MinMaxCurve drag = MinMaxCurve.Read(reader);
        
        return new(enabled,
            x,
            y,
            z,
            magnitude,
            separateAxis,
            inWorldSpace,
            multiplyDragByParticleSize,
            multiplyDragByParticleVelocity,
            dampen,
            drag);
    }
}

/* $NoiseModule (19 fields) (None) */
public record class NoiseModule(
    bool enabled,
    MinMaxCurve strength,
    MinMaxCurve strengthY,
    MinMaxCurve strengthZ,
    bool separateAxes,
    float frequency,
    bool damping,
    int octaves,
    float octaveMultiplier,
    float octaveScale,
    int quality,
    MinMaxCurve scrollSpeed,
    MinMaxCurve remap,
    MinMaxCurve remapY,
    MinMaxCurve remapZ,
    bool remapEnabled,
    MinMaxCurve positionAmount,
    MinMaxCurve rotationAmount,
    MinMaxCurve sizeAmount)
{
    public static NoiseModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve strength = MinMaxCurve.Read(reader);
        MinMaxCurve strengthY = MinMaxCurve.Read(reader);
        MinMaxCurve strengthZ = MinMaxCurve.Read(reader);
        bool separateAxes = reader.ReadBool();
        float frequency = reader.ReadF32();
        bool damping = reader.ReadBool();
        int octaves = reader.ReadS32();
        float octaveMultiplier = reader.ReadF32();
        float octaveScale = reader.ReadF32();
        int quality = reader.ReadS32();
        MinMaxCurve scrollSpeed = MinMaxCurve.Read(reader);
        MinMaxCurve remap = MinMaxCurve.Read(reader);
        MinMaxCurve remapY = MinMaxCurve.Read(reader);
        MinMaxCurve remapZ = MinMaxCurve.Read(reader);
        bool remapEnabled = reader.ReadBool();
        MinMaxCurve positionAmount = MinMaxCurve.Read(reader);
        MinMaxCurve rotationAmount = MinMaxCurve.Read(reader);
        MinMaxCurve sizeAmount = MinMaxCurve.Read(reader);
        
        return new(enabled,
            strength,
            strengthY,
            strengthZ,
            separateAxes,
            frequency,
            damping,
            octaves,
            octaveMultiplier,
            octaveScale,
            quality,
            scrollSpeed,
            remap,
            remapY,
            remapZ,
            remapEnabled,
            positionAmount,
            rotationAmount,
            sizeAmount);
    }
}

/* $SizeBySpeedModule (6 fields) (None) */
public record class SizeBySpeedModule(
    bool enabled,
    MinMaxCurve curve,
    MinMaxCurve y,
    MinMaxCurve z,
    Vector2f range,
    bool separateAxes)
{
    public static SizeBySpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve curve = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve z = MinMaxCurve.Read(reader);
        Vector2f range = Vector2f.Read(reader);
        bool separateAxes = reader.ReadBool();
        
        return new(enabled,
            curve,
            y,
            z,
            range,
            separateAxes);
    }
}

/* $RotationBySpeedModule (6 fields) (None) */
public record class RotationBySpeedModule(
    bool enabled,
    MinMaxCurve x,
    MinMaxCurve y,
    MinMaxCurve curve,
    bool separateAxes,
    Vector2f range)
{
    public static RotationBySpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxCurve x = MinMaxCurve.Read(reader);
        MinMaxCurve y = MinMaxCurve.Read(reader);
        MinMaxCurve curve = MinMaxCurve.Read(reader);
        bool separateAxes = reader.ReadBool();
        Vector2f range = Vector2f.Read(reader);
        
        return new(enabled,
            x,
            y,
            curve,
            separateAxes,
            range);
    }
}

/* $ColorBySpeedModule (3 fields) (None) */
public record class ColorBySpeedModule(
    bool enabled,
    MinMaxGradient gradient,
    Vector2f range)
{
    public static ColorBySpeedModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        MinMaxGradient gradient = MinMaxGradient.Read(reader);
        Vector2f range = Vector2f.Read(reader);
        
        return new(enabled,
            gradient,
            range);
    }
}

/* $CollisionModule (21 fields) (None) */
public record class CollisionModule(
    bool enabled,
    int type,
    int collisionMode,
    float colliderForce,
    bool multiplyColliderForceByParticleSize,
    bool multiplyColliderForceByParticleSpeed,
    bool multiplyColliderForceByCollisionAngle,
    PPtr<Transform>[] m_Planes,
    MinMaxCurve m_Dampen,
    MinMaxCurve m_Bounce,
    MinMaxCurve m_EnergyLossOnCollision,
    float minKillSpeed,
    float maxKillSpeed,
    float radiusScale,
    BitField collidesWith,
    int maxCollisionShapes,
    int quality,
    float voxelSize,
    bool collisionMessages,
    bool collidesWithDynamic,
    bool interiorCollisions)
{
    public static CollisionModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int type = reader.ReadS32();
        int collisionMode = reader.ReadS32();
        float colliderForce = reader.ReadF32();
        bool multiplyColliderForceByParticleSize = reader.ReadBool();
        bool multiplyColliderForceByParticleSpeed = reader.ReadBool();
        bool multiplyColliderForceByCollisionAngle = reader.ReadBool();
        PPtr<Transform>[] m_Planes = Array<PPtr<Transform>>.Read(reader);
        MinMaxCurve m_Dampen = MinMaxCurve.Read(reader);
        MinMaxCurve m_Bounce = MinMaxCurve.Read(reader);
        MinMaxCurve m_EnergyLossOnCollision = MinMaxCurve.Read(reader);
        float minKillSpeed = reader.ReadF32();
        float maxKillSpeed = reader.ReadF32();
        float radiusScale = reader.ReadF32();
        BitField collidesWith = BitField.Read(reader);
        int maxCollisionShapes = reader.ReadS32();
        int quality = reader.ReadS32();
        float voxelSize = reader.ReadF32();
        bool collisionMessages = reader.ReadBool();
        bool collidesWithDynamic = reader.ReadBool();
        bool interiorCollisions = reader.ReadBool();
        
        return new(enabled,
            type,
            collisionMode,
            colliderForce,
            multiplyColliderForceByParticleSize,
            multiplyColliderForceByParticleSpeed,
            multiplyColliderForceByCollisionAngle,
            m_Planes,
            m_Dampen,
            m_Bounce,
            m_EnergyLossOnCollision,
            minKillSpeed,
            maxKillSpeed,
            radiusScale,
            collidesWith,
            maxCollisionShapes,
            quality,
            voxelSize,
            collisionMessages,
            collidesWithDynamic,
            interiorCollisions);
    }
}

/* $TriggerModule (8 fields) (None) */
public record class TriggerModule(
    bool enabled,
    int inside,
    int outside,
    int enter,
    int exit,
    int colliderQueryMode,
    float radiusScale,
    PPtr<Component>[] primitives)
{
    public static TriggerModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int inside = reader.ReadS32();
        int outside = reader.ReadS32();
        int enter = reader.ReadS32();
        int exit = reader.ReadS32();
        int colliderQueryMode = reader.ReadS32();
        float radiusScale = reader.ReadF32();
        PPtr<Component>[] primitives = Array<PPtr<Component>>.Read(reader);
        
        return new(enabled,
            inside,
            outside,
            enter,
            exit,
            colliderQueryMode,
            radiusScale,
            primitives);
    }
}

/* $SubEmitterData (4 fields) (None) */
public record class SubEmitterData(
    PPtr<ParticleSystem> emitter,
    int type,
    int properties,
    float emitProbability)
{
    public static SubEmitterData Read(EndianBinaryReader reader)
    {
        PPtr<ParticleSystem> emitter = PPtr<ParticleSystem>.Read(reader);
        int type = reader.ReadS32();
        int properties = reader.ReadS32();
        float emitProbability = reader.ReadF32();
        
        return new(emitter,
            type,
            properties,
            emitProbability);
    }
}

/* $SubModule (2 fields) (None) */
public record class SubModule(
    bool enabled,
    SubEmitterData[] subEmitters)
{
    public static SubModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        SubEmitterData[] subEmitters = Array<SubEmitterData>.Read(reader);
        
        return new(enabled,
            subEmitters);
    }
}

/* $LightsModule (10 fields) (None) */
public record class LightsModule(
    bool enabled,
    float ratio,
    PPtr<Light> light,
    bool randomDistribution,
    bool color,
    bool range,
    bool intensity,
    MinMaxCurve rangeCurve,
    MinMaxCurve intensityCurve,
    int maxLights)
{
    public static LightsModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        float ratio = reader.ReadF32();
        PPtr<Light> light = PPtr<Light>.Read(reader);
        bool randomDistribution = reader.ReadBool();
        bool color = reader.ReadBool();
        bool range = reader.ReadBool();
        bool intensity = reader.ReadBool();
        MinMaxCurve rangeCurve = MinMaxCurve.Read(reader);
        MinMaxCurve intensityCurve = MinMaxCurve.Read(reader);
        int maxLights = reader.ReadS32();
        
        return new(enabled,
            ratio,
            light,
            randomDistribution,
            color,
            range,
            intensity,
            rangeCurve,
            intensityCurve,
            maxLights);
    }
}

/* $TrailModule (20 fields) (None) */
public record class TrailModule(
    bool enabled,
    int mode,
    float ratio,
    MinMaxCurve lifetime,
    float minVertexDistance,
    int textureMode,
    Vector2f textureScale,
    int ribbonCount,
    float shadowBias,
    bool worldSpace,
    bool dieWithParticles,
    bool sizeAffectsWidth,
    bool sizeAffectsLifetime,
    bool inheritParticleColor,
    bool generateLightingData,
    bool splitSubEmitterRibbons,
    bool attachRibbonsToTransform,
    MinMaxGradient colorOverLifetime,
    MinMaxCurve widthOverTrail,
    MinMaxGradient colorOverTrail)
{
    public static TrailModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int mode = reader.ReadS32();
        float ratio = reader.ReadF32();
        MinMaxCurve lifetime = MinMaxCurve.Read(reader);
        float minVertexDistance = reader.ReadF32();
        int textureMode = reader.ReadS32();
        Vector2f textureScale = Vector2f.Read(reader);
        int ribbonCount = reader.ReadS32();
        float shadowBias = reader.ReadF32();
        bool worldSpace = reader.ReadBool();
        bool dieWithParticles = reader.ReadBool();
        bool sizeAffectsWidth = reader.ReadBool();
        bool sizeAffectsLifetime = reader.ReadBool();
        bool inheritParticleColor = reader.ReadBool();
        bool generateLightingData = reader.ReadBool();
        bool splitSubEmitterRibbons = reader.ReadBool();
        bool attachRibbonsToTransform = reader.ReadBool();
        MinMaxGradient colorOverLifetime = MinMaxGradient.Read(reader);
        MinMaxCurve widthOverTrail = MinMaxCurve.Read(reader);
        MinMaxGradient colorOverTrail = MinMaxGradient.Read(reader);
        
        return new(enabled,
            mode,
            ratio,
            lifetime,
            minVertexDistance,
            textureMode,
            textureScale,
            ribbonCount,
            shadowBias,
            worldSpace,
            dieWithParticles,
            sizeAffectsWidth,
            sizeAffectsLifetime,
            inheritParticleColor,
            generateLightingData,
            splitSubEmitterRibbons,
            attachRibbonsToTransform,
            colorOverLifetime,
            widthOverTrail,
            colorOverTrail);
    }
}

/* $CustomDataModule (15 fields) (None) */
public record class CustomDataModule(
    bool enabled,
    int mode0,
    int vectorComponentCount0,
    MinMaxGradient color0,
    MinMaxCurve vector0_0,
    MinMaxCurve vector0_1,
    MinMaxCurve vector0_2,
    MinMaxCurve vector0_3,
    int mode1,
    int vectorComponentCount1,
    MinMaxGradient color1,
    MinMaxCurve vector1_0,
    MinMaxCurve vector1_1,
    MinMaxCurve vector1_2,
    MinMaxCurve vector1_3)
{
    public static CustomDataModule Read(EndianBinaryReader reader)
    {
        bool enabled = reader.ReadBool();
        int mode0 = reader.ReadS32();
        int vectorComponentCount0 = reader.ReadS32();
        MinMaxGradient color0 = MinMaxGradient.Read(reader);
        MinMaxCurve vector0_0 = MinMaxCurve.Read(reader);
        MinMaxCurve vector0_1 = MinMaxCurve.Read(reader);
        MinMaxCurve vector0_2 = MinMaxCurve.Read(reader);
        MinMaxCurve vector0_3 = MinMaxCurve.Read(reader);
        int mode1 = reader.ReadS32();
        int vectorComponentCount1 = reader.ReadS32();
        MinMaxGradient color1 = MinMaxGradient.Read(reader);
        MinMaxCurve vector1_0 = MinMaxCurve.Read(reader);
        MinMaxCurve vector1_1 = MinMaxCurve.Read(reader);
        MinMaxCurve vector1_2 = MinMaxCurve.Read(reader);
        MinMaxCurve vector1_3 = MinMaxCurve.Read(reader);
        
        return new(enabled,
            mode0,
            vectorComponentCount0,
            color0,
            vector0_0,
            vector0_1,
            vector0_2,
            vector0_3,
            mode1,
            vectorComponentCount1,
            color1,
            vector1_0,
            vector1_1,
            vector1_2,
            vector1_3);
    }
}

/* $VFXEntryExposed (3 fields) (None) */
public record class VFXEntryExposed(
    float m_Value,
    AsciiString m_Name,
    bool m_Overridden)
{
    public static VFXEntryExposed Read(EndianBinaryReader reader)
    {
        float m_Value = reader.ReadF32();
        AsciiString m_Name = String.Read(reader);
        bool m_Overridden = reader.ReadBool();
        
        return new(m_Value,
            m_Name,
            m_Overridden);
    }
}

/* $VFXField (1 fields) (None) */
public record class VFXField(
    VFXEntryExposed[] m_Array)
{
    public static VFXField Read(EndianBinaryReader reader)
    {
        VFXEntryExposed[] m_Array = Array<VFXEntryExposed>.Read(reader);
        
        return new(m_Array);
    }
}

/* $VFXPropertySheetSerializedBase (11 fields) (None) */
public record class VFXPropertySheetSerializedBase(
    VFXField m_Float,
    VFXField m_Vector2f,
    VFXField m_Vector3f,
    VFXField m_Vector4f,
    VFXField m_Uint,
    VFXField m_Int,
    VFXField m_Matrix4x4f,
    VFXField m_AnimationCurve,
    VFXField m_Gradient,
    VFXField m_NamedObject,
    VFXField m_Bool)
{
    public static VFXPropertySheetSerializedBase Read(EndianBinaryReader reader)
    {
        VFXField m_Float = VFXField.Read(reader);
        VFXField m_Vector2f = VFXField.Read(reader);
        VFXField m_Vector3f = VFXField.Read(reader);
        VFXField m_Vector4f = VFXField.Read(reader);
        VFXField m_Uint = VFXField.Read(reader);
        VFXField m_Int = VFXField.Read(reader);
        VFXField m_Matrix4x4f = VFXField.Read(reader);
        VFXField m_AnimationCurve = VFXField.Read(reader);
        VFXField m_Gradient = VFXField.Read(reader);
        VFXField m_NamedObject = VFXField.Read(reader);
        VFXField m_Bool = VFXField.Read(reader);
        
        return new(m_Float,
            m_Vector2f,
            m_Vector3f,
            m_Vector4f,
            m_Uint,
            m_Int,
            m_Matrix4x4f,
            m_AnimationCurve,
            m_Gradient,
            m_NamedObject,
            m_Bool);
    }
}

/* $StreamedResource (3 fields) (None) */
public record class StreamedResource(
    AsciiString m_Source,
    ulong m_Offset,
    ulong m_Size)
{
    public static StreamedResource Read(EndianBinaryReader reader)
    {
        AsciiString m_Source = String.Read(reader);
        ulong m_Offset = reader.ReadU64();
        ulong m_Size = reader.ReadU64();
        
        return new(m_Source,
            m_Offset,
            m_Size);
    }
}

/* $Rectf (4 fields) (None) */
public readonly record struct Rectf(
    float x,
    float y,
    float width,
    float height)
{
    public static Rectf Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        float width = reader.ReadF32();
        float height = reader.ReadF32();
        
        return new(x,
            y,
            width,
            height);
    }
}

/* $GUID (4 fields) (None) */
public readonly record struct GUID(
    uint data_0,
    uint data_1,
    uint data_2,
    uint data_3)
{
    public static GUID Read(EndianBinaryReader reader)
    {
        uint data_0 = reader.ReadU32();
        uint data_1 = reader.ReadU32();
        uint data_2 = reader.ReadU32();
        uint data_3 = reader.ReadU32();
        
        return new(data_0,
            data_1,
            data_2,
            data_3);
    }
}

/* $pair (2 fields) (None) */
public record class pair(
    GUID first,
    long second)
{
    public static pair Read(EndianBinaryReader reader)
    {
        GUID first = GUID.Read(reader);
        long second = reader.ReadS64();
        
        return new(first,
            second);
    }
}

/* $SecondarySpriteTexture (2 fields) (None) */
public record class SecondarySpriteTexture(
    PPtr<Texture2D> texture,
    AsciiString name)
{
    public static SecondarySpriteTexture Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> texture = PPtr<Texture2D>.Read(reader);
        AsciiString name = String.Read(reader);
        
        return new(texture,
            name);
    }
}

/* $SpriteRenderData (13 fields) (None) */
public record class SpriteRenderData(
    PPtr<Texture2D> texture,
    PPtr<Texture2D> alphaTexture,
    SecondarySpriteTexture[] secondaryTextures,
    SubMesh[] m_SubMeshes,
    byte[] m_IndexBuffer,
    VertexData m_VertexData,
    Matrix4x4f[] m_Bindpose,
    Rectf textureRect,
    Vector2f textureRectOffset,
    Vector2f atlasRectOffset,
    uint settingsRaw,
    Vector4f uvTransform,
    float downscaleMultiplier)
{
    public static SpriteRenderData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> texture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> alphaTexture = PPtr<Texture2D>.Read(reader);
        SecondarySpriteTexture[] secondaryTextures = Array<SecondarySpriteTexture>.Read(reader);
        SubMesh[] m_SubMeshes = Array<SubMesh>.Read(reader);
        byte[] m_IndexBuffer = Array<byte>.Read(reader);
        VertexData m_VertexData = VertexData.Read(reader);
        Matrix4x4f[] m_Bindpose = Array<Matrix4x4f>.Read(reader);
        Rectf textureRect = Rectf.Read(reader);
        Vector2f textureRectOffset = Vector2f.Read(reader);
        Vector2f atlasRectOffset = Vector2f.Read(reader);
        uint settingsRaw = reader.ReadU32();
        Vector4f uvTransform = Vector4f.Read(reader);
        float downscaleMultiplier = reader.ReadF32();
        
        return new(texture,
            alphaTexture,
            secondaryTextures,
            m_SubMeshes,
            m_IndexBuffer,
            m_VertexData,
            m_Bindpose,
            textureRect,
            textureRectOffset,
            atlasRectOffset,
            settingsRaw,
            uvTransform,
            downscaleMultiplier);
    }
}

/* $SpriteBone (7 fields) (None) */
public record class SpriteBone(
    AsciiString name,
    AsciiString guid,
    Vector3f position,
    Quaternionf rotation,
    float length,
    int parentId,
    ColorRGBA color)
{
    public static SpriteBone Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        AsciiString guid = String.Read(reader);
        Vector3f position = Vector3f.Read(reader);
        Quaternionf rotation = Quaternionf.Read(reader);
        float length = reader.ReadF32();
        int parentId = reader.ReadS32();
        ColorRGBA color = ColorRGBA.Read(reader);
        
        return new(name,
            guid,
            position,
            rotation,
            length,
            parentId,
            color);
    }
}

/* $CharacterInfo (5 fields) (None) */
public record class CharacterInfo(
    uint index,
    Rectf uv,
    Rectf vert,
    float advance,
    bool flipped)
{
    public static CharacterInfo Read(EndianBinaryReader reader)
    {
        uint index = reader.ReadU32();
        Rectf uv = Rectf.Read(reader);
        Rectf vert = Rectf.Read(reader);
        float advance = reader.ReadF32();
        bool flipped = reader.ReadBool();
        
        return new(index,
            uv,
            vert,
            advance,
            flipped);
    }
}

/* $SpriteAtlasData (9 fields) (None) */
public record class SpriteAtlasData(
    PPtr<Texture2D> texture,
    PPtr<Texture2D> alphaTexture,
    Rectf textureRect,
    Vector2f textureRectOffset,
    Vector2f atlasRectOffset,
    Vector4f uvTransform,
    float downscaleMultiplier,
    uint settingsRaw,
    SecondarySpriteTexture[] secondaryTextures)
{
    public static SpriteAtlasData Read(EndianBinaryReader reader)
    {
        PPtr<Texture2D> texture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> alphaTexture = PPtr<Texture2D>.Read(reader);
        Rectf textureRect = Rectf.Read(reader);
        Vector2f textureRectOffset = Vector2f.Read(reader);
        Vector2f atlasRectOffset = Vector2f.Read(reader);
        Vector4f uvTransform = Vector4f.Read(reader);
        float downscaleMultiplier = reader.ReadF32();
        uint settingsRaw = reader.ReadU32();
        SecondarySpriteTexture[] secondaryTextures = Array<SecondarySpriteTexture>.Read(reader);
        
        return new(texture,
            alphaTexture,
            textureRect,
            textureRectOffset,
            atlasRectOffset,
            uvTransform,
            downscaleMultiplier,
            settingsRaw,
            secondaryTextures);
    }
}

/* $SplatDatabase (4 fields) (None) */
public record class SplatDatabase(
    PPtr<TerrainLayer>[] m_TerrainLayers,
    PPtr<Texture2D>[] m_AlphaTextures,
    int m_AlphamapResolution,
    int m_BaseMapResolution)
{
    public static SplatDatabase Read(EndianBinaryReader reader)
    {
        PPtr<TerrainLayer>[] m_TerrainLayers = Array<PPtr<TerrainLayer>>.Read(reader);
        PPtr<Texture2D>[] m_AlphaTextures = Array<PPtr<Texture2D>>.Read(reader);
        int m_AlphamapResolution = reader.ReadS32();
        int m_BaseMapResolution = reader.ReadS32();
        
        return new(m_TerrainLayers,
            m_AlphaTextures,
            m_AlphamapResolution,
            m_BaseMapResolution);
    }
}

/* $DetailPatch (2 fields) (None) */
public record class DetailPatch(
    byte[] layerIndices,
    byte[] coverage)
{
    public static DetailPatch Read(EndianBinaryReader reader)
    {
        byte[] layerIndices = Array<byte>.Read(reader);
        byte[] coverage = Array<byte>.Read(reader);
        
        return new(layerIndices,
            coverage);
    }
}

/* $DetailPrototype (19 fields) (None) */
public record class DetailPrototype(
    PPtr<GameObject> prototype,
    PPtr<Texture2D> prototypeTexture,
    float minWidth,
    float maxWidth,
    float minHeight,
    float maxHeight,
    int noiseSeed,
    float noiseSpread,
    float holeTestRadius,
    float density,
    ColorRGBA healthyColor,
    ColorRGBA dryColor,
    int renderMode,
    int usePrototypeMesh,
    int useInstancing,
    int useDensityScaling,
    float alignToGround,
    float positionJitter,
    float targetCoverage)
{
    public static DetailPrototype Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> prototype = PPtr<GameObject>.Read(reader);
        PPtr<Texture2D> prototypeTexture = PPtr<Texture2D>.Read(reader);
        float minWidth = reader.ReadF32();
        float maxWidth = reader.ReadF32();
        float minHeight = reader.ReadF32();
        float maxHeight = reader.ReadF32();
        int noiseSeed = reader.ReadS32();
        float noiseSpread = reader.ReadF32();
        float holeTestRadius = reader.ReadF32();
        float density = reader.ReadF32();
        ColorRGBA healthyColor = ColorRGBA.Read(reader);
        ColorRGBA dryColor = ColorRGBA.Read(reader);
        int renderMode = reader.ReadS32();
        int usePrototypeMesh = reader.ReadS32();
        int useInstancing = reader.ReadS32();
        int useDensityScaling = reader.ReadS32();
        float alignToGround = reader.ReadF32();
        float positionJitter = reader.ReadF32();
        float targetCoverage = reader.ReadF32();
        
        return new(prototype,
            prototypeTexture,
            minWidth,
            maxWidth,
            minHeight,
            maxHeight,
            noiseSeed,
            noiseSpread,
            holeTestRadius,
            density,
            healthyColor,
            dryColor,
            renderMode,
            usePrototypeMesh,
            useInstancing,
            useDensityScaling,
            alignToGround,
            positionJitter,
            targetCoverage);
    }
}

/* $TreeInstance (7 fields) (None) */
public record class TreeInstance(
    Vector3f position,
    float widthScale,
    float heightScale,
    float rotation,
    ColorRGBA color,
    ColorRGBA lightmapColor,
    int index)
{
    public static TreeInstance Read(EndianBinaryReader reader)
    {
        Vector3f position = Vector3f.Read(reader);
        float widthScale = reader.ReadF32();
        float heightScale = reader.ReadF32();
        float rotation = reader.ReadF32();
        ColorRGBA color = ColorRGBA.Read(reader);
        ColorRGBA lightmapColor = ColorRGBA.Read(reader);
        int index = reader.ReadS32();
        
        return new(position,
            widthScale,
            heightScale,
            rotation,
            color,
            lightmapColor,
            index);
    }
}

/* $TreePrototype (3 fields) (None) */
public record class TreePrototype(
    PPtr<GameObject> prefab,
    float bendFactor,
    int navMeshLod)
{
    public static TreePrototype Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> prefab = PPtr<GameObject>.Read(reader);
        float bendFactor = reader.ReadF32();
        int navMeshLod = reader.ReadS32();
        
        return new(prefab,
            bendFactor,
            navMeshLod);
    }
}

/* $DetailDatabase (15 fields) (None) */
public record class DetailDatabase(
    DetailPatch[] m_Patches,
    DetailPrototype[] m_DetailPrototypes,
    int m_PatchCount,
    int m_PatchSamples,
    ColorRGBA WavingGrassTint,
    float m_WavingGrassStrength,
    float m_WavingGrassAmount,
    float m_WavingGrassSpeed,
    int m_DetailScatterMode,
    TreeInstance[] m_TreeInstances,
    TreePrototype[] m_TreePrototypes,
    PPtr<Texture2D>[] m_PreloadTextureAtlasData,
    PPtr<Shader> m_DefaultShaders_0,
    PPtr<Shader> m_DefaultShaders_1,
    PPtr<Shader> m_DefaultShaders_2)
{
    public static DetailDatabase Read(EndianBinaryReader reader)
    {
        DetailPatch[] m_Patches = Array<DetailPatch>.Read(reader);
        DetailPrototype[] m_DetailPrototypes = Array<DetailPrototype>.Read(reader);
        int m_PatchCount = reader.ReadS32();
        int m_PatchSamples = reader.ReadS32();
        ColorRGBA WavingGrassTint = ColorRGBA.Read(reader);
        float m_WavingGrassStrength = reader.ReadF32();
        float m_WavingGrassAmount = reader.ReadF32();
        float m_WavingGrassSpeed = reader.ReadF32();
        int m_DetailScatterMode = reader.ReadS32();
        TreeInstance[] m_TreeInstances = Array<TreeInstance>.Read(reader);
        TreePrototype[] m_TreePrototypes = Array<TreePrototype>.Read(reader);
        PPtr<Texture2D>[] m_PreloadTextureAtlasData = Array<PPtr<Texture2D>>.Read(reader);
        PPtr<Shader> m_DefaultShaders_0 = PPtr<Shader>.Read(reader);
        PPtr<Shader> m_DefaultShaders_1 = PPtr<Shader>.Read(reader);
        PPtr<Shader> m_DefaultShaders_2 = PPtr<Shader>.Read(reader);
        
        return new(m_Patches,
            m_DetailPrototypes,
            m_PatchCount,
            m_PatchSamples,
            WavingGrassTint,
            m_WavingGrassStrength,
            m_WavingGrassAmount,
            m_WavingGrassSpeed,
            m_DetailScatterMode,
            m_TreeInstances,
            m_TreePrototypes,
            m_PreloadTextureAtlasData,
            m_DefaultShaders_0,
            m_DefaultShaders_1,
            m_DefaultShaders_2);
    }
}

/* $Heightmap (9 fields) (None) */
public record class Heightmap(
    short[] m_Heights,
    byte[] m_Holes,
    byte[] m_HolesLOD,
    bool m_EnableHolesTextureCompression,
    float[] m_PrecomputedError,
    float[] m_MinMaxPatchHeights,
    int m_Resolution,
    int m_Levels,
    Vector3f m_Scale)
{
    public static Heightmap Read(EndianBinaryReader reader)
    {
        short[] m_Heights = Array<short>.Read(reader);
        byte[] m_Holes = Array<byte>.Read(reader);
        byte[] m_HolesLOD = Array<byte>.Read(reader);
        bool m_EnableHolesTextureCompression = reader.ReadBool();
        float[] m_PrecomputedError = Array<float>.Read(reader);
        float[] m_MinMaxPatchHeights = Array<float>.Read(reader);
        int m_Resolution = reader.ReadS32();
        int m_Levels = reader.ReadS32();
        Vector3f m_Scale = Vector3f.Read(reader);
        
        return new(m_Heights,
            m_Holes,
            m_HolesLOD,
            m_EnableHolesTextureCompression,
            m_PrecomputedError,
            m_MinMaxPatchHeights,
            m_Resolution,
            m_Levels,
            m_Scale);
    }
}

/* $ComputeShaderResource (5 fields) (None) */
public record class ComputeShaderResource(
    AsciiString name,
    AsciiString generatedName,
    int bindPoint,
    int samplerBindPoint,
    int texDimension)
{
    public static ComputeShaderResource Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        AsciiString generatedName = String.Read(reader);
        int bindPoint = reader.ReadS32();
        int samplerBindPoint = reader.ReadS32();
        int texDimension = reader.ReadS32();
        
        return new(name,
            generatedName,
            bindPoint,
            samplerBindPoint,
            texDimension);
    }
}

/* $ComputeShaderBuiltinSampler (2 fields) (None) */
public readonly record struct ComputeShaderBuiltinSampler(
    uint sampler,
    int bindPoint)
{
    public static ComputeShaderBuiltinSampler Read(EndianBinaryReader reader)
    {
        uint sampler = reader.ReadU32();
        int bindPoint = reader.ReadS32();
        
        return new(sampler,
            bindPoint);
    }
}

/* $ComputeShaderKernel (9 fields) (None) */
public record class ComputeShaderKernel(
    uint[] cbVariantIndices,
    ComputeShaderResource[] cbs,
    ComputeShaderResource[] textures,
    ComputeShaderBuiltinSampler[] builtinSamplers,
    ComputeShaderResource[] inBuffers,
    ComputeShaderResource[] outBuffers,
    byte[] code,
    uint[] threadGroupSize,
    long requirements)
{
    public static ComputeShaderKernel Read(EndianBinaryReader reader)
    {
        uint[] cbVariantIndices = Array<uint>.Read(reader);
        ComputeShaderResource[] cbs = Array<ComputeShaderResource>.Read(reader);
        ComputeShaderResource[] textures = Array<ComputeShaderResource>.Read(reader);
        ComputeShaderBuiltinSampler[] builtinSamplers = Array<ComputeShaderBuiltinSampler>.Read(reader);
        ComputeShaderResource[] inBuffers = Array<ComputeShaderResource>.Read(reader);
        ComputeShaderResource[] outBuffers = Array<ComputeShaderResource>.Read(reader);
        byte[] code = Array<byte>.Read(reader);
        uint[] threadGroupSize = Array<uint>.Read(reader);
        long requirements = reader.ReadS64();
        
        return new(cbVariantIndices,
            cbs,
            textures,
            builtinSamplers,
            inBuffers,
            outBuffers,
            code,
            threadGroupSize,
            requirements);
    }
}

/* $ComputeShaderKernelParent (6 fields) (None) */
public record class ComputeShaderKernelParent(
    AsciiString name,
    ComputeShaderKernel[] uniqueVariants,
    pair[] variantIndices,
    AsciiString[] globalKeywords,
    AsciiString[] localKeywords,
    AsciiString[] dynamicKeywords)
{
    public static ComputeShaderKernelParent Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        ComputeShaderKernel[] uniqueVariants = Array<ComputeShaderKernel>.Read(reader);
        pair[] variantIndices = Array<pair>.Read(reader);
        AsciiString[] globalKeywords = Array<AsciiString>.Read(reader);
        AsciiString[] localKeywords = Array<AsciiString>.Read(reader);
        AsciiString[] dynamicKeywords = Array<AsciiString>.Read(reader);
        
        return new(name,
            uniqueVariants,
            variantIndices,
            globalKeywords,
            localKeywords,
            dynamicKeywords);
    }
}

/* $ComputeShaderParam (6 fields) (None) */
public record class ComputeShaderParam(
    AsciiString name,
    int type,
    uint offset,
    uint arraySize,
    uint rowCount,
    uint colCount)
{
    public static ComputeShaderParam Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        int type = reader.ReadS32();
        uint offset = reader.ReadU32();
        uint arraySize = reader.ReadU32();
        uint rowCount = reader.ReadU32();
        uint colCount = reader.ReadU32();
        
        return new(name,
            type,
            offset,
            arraySize,
            rowCount,
            colCount);
    }
}

/* $ComputeShaderCB (3 fields) (None) */
public record class ComputeShaderCB(
    AsciiString name,
    int byteSize,
    ComputeShaderParam[] @params)
{
    public static ComputeShaderCB Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        int byteSize = reader.ReadS32();
        ComputeShaderParam[] @params = Array<ComputeShaderParam>.Read(reader);
        
        return new(name,
            byteSize,
            @params);
    }
}

/* $ComputeShaderPlatformVariant (5 fields) (None) */
public record class ComputeShaderPlatformVariant(
    int targetRenderer,
    int targetLevel,
    ComputeShaderKernelParent[] kernels,
    ComputeShaderCB[] constantBuffers,
    bool resourcesResolved)
{
    public static ComputeShaderPlatformVariant Read(EndianBinaryReader reader)
    {
        int targetRenderer = reader.ReadS32();
        int targetLevel = reader.ReadS32();
        ComputeShaderKernelParent[] kernels = Array<ComputeShaderKernelParent>.Read(reader);
        ComputeShaderCB[] constantBuffers = Array<ComputeShaderCB>.Read(reader);
        bool resourcesResolved = reader.ReadBool();
        
        return new(targetRenderer,
            targetLevel,
            kernels,
            constantBuffers,
            resourcesResolved);
    }
}

/* $VFXRendererSettings (5 fields) (None) */
public readonly record struct VFXRendererSettings(
    int motionVectorGenerationMode,
    int shadowCastingMode,
    bool receiveShadows,
    int reflectionProbeUsage,
    int lightProbeUsage)
{
    public static VFXRendererSettings Read(EndianBinaryReader reader)
    {
        int motionVectorGenerationMode = reader.ReadS32();
        int shadowCastingMode = reader.ReadS32();
        bool receiveShadows = reader.ReadBool();
        int reflectionProbeUsage = reader.ReadS32();
        int lightProbeUsage = reader.ReadS32();
        
        return new(motionVectorGenerationMode,
            shadowCastingMode,
            receiveShadows,
            reflectionProbeUsage,
            lightProbeUsage);
    }
}

/* $Expression (6 fields) (None) */
public readonly record struct Expression(
    int op,
    int valueIndex,
    int data_0,
    int data_1,
    int data_2,
    int data_3)
{
    public static Expression Read(EndianBinaryReader reader)
    {
        int op = reader.ReadS32();
        int valueIndex = reader.ReadS32();
        int data_0 = reader.ReadS32();
        int data_1 = reader.ReadS32();
        int data_2 = reader.ReadS32();
        int data_3 = reader.ReadS32();
        
        return new(op,
            valueIndex,
            data_0,
            data_1,
            data_2,
            data_3);
    }
}

/* $VFXExpressionContainer (10 fields) (None) */
public record class VFXExpressionContainer(
    Expression[] m_Expressions,
    uint m_MaxCommonExpressionsIndex,
    uint m_ConstantBakeCurveCount,
    uint m_ConstantBakeGradientCount,
    uint m_DynamicBakeCurveCount,
    uint m_DynamicBakeGradientCount,
    bool m_NeedsLocalToWorld,
    bool m_NeedsWorldToLocal,
    bool m_NeedsMainCamera,
    int m_NeededMainCameraBuffers)
{
    public static VFXExpressionContainer Read(EndianBinaryReader reader)
    {
        Expression[] m_Expressions = Array<Expression>.Read(reader);
        uint m_MaxCommonExpressionsIndex = reader.ReadU32();
        uint m_ConstantBakeCurveCount = reader.ReadU32();
        uint m_ConstantBakeGradientCount = reader.ReadU32();
        uint m_DynamicBakeCurveCount = reader.ReadU32();
        uint m_DynamicBakeGradientCount = reader.ReadU32();
        bool m_NeedsLocalToWorld = reader.ReadBool();
        bool m_NeedsWorldToLocal = reader.ReadBool();
        bool m_NeedsMainCamera = reader.ReadBool();
        int m_NeededMainCameraBuffers = reader.ReadS32();
        
        return new(m_Expressions,
            m_MaxCommonExpressionsIndex,
            m_ConstantBakeCurveCount,
            m_ConstantBakeGradientCount,
            m_DynamicBakeCurveCount,
            m_DynamicBakeGradientCount,
            m_NeedsLocalToWorld,
            m_NeedsWorldToLocal,
            m_NeedsMainCamera,
            m_NeededMainCameraBuffers);
    }
}

/* $VFXMapping (2 fields) (None) */
public record class VFXMapping(
    AsciiString nameId,
    int index)
{
    public static VFXMapping Read(EndianBinaryReader reader)
    {
        AsciiString nameId = String.Read(reader);
        int index = reader.ReadS32();
        
        return new(nameId,
            index);
    }
}

/* $VFXLayoutOffset (3 fields) (None) */
public readonly record struct VFXLayoutOffset(
    uint bucket,
    uint structure,
    uint element)
{
    public static VFXLayoutOffset Read(EndianBinaryReader reader)
    {
        uint bucket = reader.ReadU32();
        uint structure = reader.ReadU32();
        uint element = reader.ReadU32();
        
        return new(bucket,
            structure,
            element);
    }
}

/* $VFXLayoutElementDesc (3 fields) (None) */
public record class VFXLayoutElementDesc(
    AsciiString name,
    int type,
    VFXLayoutOffset offset)
{
    public static VFXLayoutElementDesc Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        int type = reader.ReadS32();
        VFXLayoutOffset offset = VFXLayoutOffset.Read(reader);
        
        return new(name,
            type,
            offset);
    }
}

/* $VFXGPUBufferDesc (5 fields) (None) */
public record class VFXGPUBufferDesc(
    int type,
    uint size,
    VFXLayoutElementDesc[] layout,
    uint capacity,
    uint stride)
{
    public static VFXGPUBufferDesc Read(EndianBinaryReader reader)
    {
        int type = reader.ReadS32();
        uint size = reader.ReadU32();
        VFXLayoutElementDesc[] layout = Array<VFXLayoutElementDesc>.Read(reader);
        uint capacity = reader.ReadU32();
        uint stride = reader.ReadU32();
        
        return new(type,
            size,
            layout,
            capacity,
            stride);
    }
}

/* $VFXTemporaryGPUBufferDesc (2 fields) (None) */
public record class VFXTemporaryGPUBufferDesc(
    VFXGPUBufferDesc desc,
    uint frameCount)
{
    public static VFXTemporaryGPUBufferDesc Read(EndianBinaryReader reader)
    {
        VFXGPUBufferDesc desc = VFXGPUBufferDesc.Read(reader);
        uint frameCount = reader.ReadU32();
        
        return new(desc,
            frameCount);
    }
}

/* $VFXCPUBufferData (1 fields) (None) */
public record class VFXCPUBufferData(
    uint[] data)
{
    public static VFXCPUBufferData Read(EndianBinaryReader reader)
    {
        uint[] data = Array<uint>.Read(reader);
        
        return new(data);
    }
}

/* $VFXCPUBufferDesc (4 fields) (None) */
public record class VFXCPUBufferDesc(
    uint capacity,
    uint stride,
    VFXLayoutElementDesc[] layout,
    VFXCPUBufferData initialData)
{
    public static VFXCPUBufferDesc Read(EndianBinaryReader reader)
    {
        uint capacity = reader.ReadU32();
        uint stride = reader.ReadU32();
        VFXLayoutElementDesc[] layout = Array<VFXLayoutElementDesc>.Read(reader);
        VFXCPUBufferData initialData = VFXCPUBufferData.Read(reader);
        
        return new(capacity,
            stride,
            layout,
            initialData);
    }
}

/* $VFXEventDesc (4 fields) (None) */
public record class VFXEventDesc(
    AsciiString name,
    uint[] playSystems,
    uint[] stopSystems,
    uint[] initSystems)
{
    public static VFXEventDesc Read(EndianBinaryReader reader)
    {
        AsciiString name = String.Read(reader);
        uint[] playSystems = Array<uint>.Read(reader);
        uint[] stopSystems = Array<uint>.Read(reader);
        uint[] initSystems = Array<uint>.Read(reader);
        
        return new(name,
            playSystems,
            stopSystems,
            initSystems);
    }
}

/* $VisualEffectInfo (18 fields) (None) */
public record class VisualEffectInfo(
    VFXRendererSettings m_RendererSettings,
    int m_CullingFlags,
    int m_UpdateMode,
    float m_PreWarmDeltaTime,
    uint m_PreWarmStepCount,
    AsciiString m_InitialEventName,
    int m_InstancingMode,
    uint m_InstancingCapacity,
    VFXExpressionContainer m_Expressions,
    VFXPropertySheetSerializedBase m_PropertySheet,
    VFXMapping[] m_ExposedExpressions,
    VFXGPUBufferDesc[] m_Buffers,
    VFXTemporaryGPUBufferDesc[] m_TemporaryBuffers,
    VFXCPUBufferDesc[] m_CPUBuffers,
    VFXEventDesc[] m_Events,
    int m_InstancingDisabledReason,
    uint m_RuntimeVersion,
    uint m_CompilationVersion)
{
    public static VisualEffectInfo Read(EndianBinaryReader reader)
    {
        VFXRendererSettings m_RendererSettings = VFXRendererSettings.Read(reader);
        int m_CullingFlags = reader.ReadS32();
        int m_UpdateMode = reader.ReadS32();
        float m_PreWarmDeltaTime = reader.ReadF32();
        uint m_PreWarmStepCount = reader.ReadU32();
        AsciiString m_InitialEventName = String.Read(reader);
        int m_InstancingMode = reader.ReadS32();
        uint m_InstancingCapacity = reader.ReadU32();
        VFXExpressionContainer m_Expressions = VFXExpressionContainer.Read(reader);
        VFXPropertySheetSerializedBase m_PropertySheet = VFXPropertySheetSerializedBase.Read(reader);
        VFXMapping[] m_ExposedExpressions = Array<VFXMapping>.Read(reader);
        VFXGPUBufferDesc[] m_Buffers = Array<VFXGPUBufferDesc>.Read(reader);
        VFXTemporaryGPUBufferDesc[] m_TemporaryBuffers = Array<VFXTemporaryGPUBufferDesc>.Read(reader);
        VFXCPUBufferDesc[] m_CPUBuffers = Array<VFXCPUBufferDesc>.Read(reader);
        VFXEventDesc[] m_Events = Array<VFXEventDesc>.Read(reader);
        int m_InstancingDisabledReason = reader.ReadS32();
        uint m_RuntimeVersion = reader.ReadU32();
        uint m_CompilationVersion = reader.ReadU32();
        
        return new(m_RendererSettings,
            m_CullingFlags,
            m_UpdateMode,
            m_PreWarmDeltaTime,
            m_PreWarmStepCount,
            m_InitialEventName,
            m_InstancingMode,
            m_InstancingCapacity,
            m_Expressions,
            m_PropertySheet,
            m_ExposedExpressions,
            m_Buffers,
            m_TemporaryBuffers,
            m_CPUBuffers,
            m_Events,
            m_InstancingDisabledReason,
            m_RuntimeVersion,
            m_CompilationVersion);
    }
}

/* $VFXMappingTemporary (3 fields) (None) */
public record class VFXMappingTemporary(
    VFXMapping mapping,
    uint pastFrameIndex,
    bool perCameraBuffer)
{
    public static VFXMappingTemporary Read(EndianBinaryReader reader)
    {
        VFXMapping mapping = VFXMapping.Read(reader);
        uint pastFrameIndex = reader.ReadU32();
        bool perCameraBuffer = reader.ReadBool();
        
        return new(mapping,
            pastFrameIndex,
            perCameraBuffer);
    }
}

/* $VFXTaskDesc (7 fields) (None) */
public record class VFXTaskDesc(
    int type,
    VFXMapping[] buffers,
    VFXMappingTemporary[] temporaryBuffers,
    VFXMapping[] values,
    VFXMapping[] @params,
    PPtr<NamedObject> processor,
    uint instanceSplitIndex)
{
    public static VFXTaskDesc Read(EndianBinaryReader reader)
    {
        int type = reader.ReadS32();
        VFXMapping[] buffers = Array<VFXMapping>.Read(reader);
        VFXMappingTemporary[] temporaryBuffers = Array<VFXMappingTemporary>.Read(reader);
        VFXMapping[] values = Array<VFXMapping>.Read(reader);
        VFXMapping[] @params = Array<VFXMapping>.Read(reader);
        PPtr<NamedObject> processor = PPtr<NamedObject>.Read(reader);
        uint instanceSplitIndex = reader.ReadU32();
        
        return new(type,
            buffers,
            temporaryBuffers,
            values,
            @params,
            processor,
            instanceSplitIndex);
    }
}

/* $VFXInstanceSplitDesc (1 fields) (None) */
public record class VFXInstanceSplitDesc(
    uint[] values)
{
    public static VFXInstanceSplitDesc Read(EndianBinaryReader reader)
    {
        uint[] values = Array<uint>.Read(reader);
        
        return new(values);
    }
}

/* $VFXSystemDesc (9 fields) (None) */
public record class VFXSystemDesc(
    int type,
    int flags,
    uint capacity,
    uint layer,
    AsciiString name,
    VFXMapping[] buffers,
    VFXMapping[] values,
    VFXTaskDesc[] tasks,
    VFXInstanceSplitDesc[] instanceSplitDescs)
{
    public static VFXSystemDesc Read(EndianBinaryReader reader)
    {
        int type = reader.ReadS32();
        int flags = reader.ReadS32();
        uint capacity = reader.ReadU32();
        uint layer = reader.ReadU32();
        AsciiString name = String.Read(reader);
        VFXMapping[] buffers = Array<VFXMapping>.Read(reader);
        VFXMapping[] values = Array<VFXMapping>.Read(reader);
        VFXTaskDesc[] tasks = Array<VFXTaskDesc>.Read(reader);
        VFXInstanceSplitDesc[] instanceSplitDescs = Array<VFXInstanceSplitDesc>.Read(reader);
        
        return new(type,
            flags,
            capacity,
            layer,
            name,
            buffers,
            values,
            tasks,
            instanceSplitDescs);
    }
}

/* $AvatarConstant (12 fields) (None) */
public record class AvatarConstant(
    OffsetPtr m_AvatarSkeleton,
    OffsetPtr m_AvatarSkeletonPose,
    OffsetPtr m_DefaultPose,
    uint[] m_SkeletonNameIDArray,
    OffsetPtr m_Human,
    int[] m_HumanSkeletonIndexArray,
    int[] m_HumanSkeletonReverseIndexArray,
    int m_RootMotionBoneIndex,
    xform m_RootMotionBoneX,
    OffsetPtr m_RootMotionSkeleton,
    OffsetPtr m_RootMotionSkeletonPose,
    int[] m_RootMotionSkeletonIndexArray)
{
    public static AvatarConstant Read(EndianBinaryReader reader)
    {
        OffsetPtr m_AvatarSkeleton = OffsetPtr.Read(reader);
        OffsetPtr m_AvatarSkeletonPose = OffsetPtr.Read(reader);
        OffsetPtr m_DefaultPose = OffsetPtr.Read(reader);
        uint[] m_SkeletonNameIDArray = Array<uint>.Read(reader);
        OffsetPtr m_Human = OffsetPtr.Read(reader);
        int[] m_HumanSkeletonIndexArray = Array<int>.Read(reader);
        int[] m_HumanSkeletonReverseIndexArray = Array<int>.Read(reader);
        int m_RootMotionBoneIndex = reader.ReadS32();
        xform m_RootMotionBoneX = xform.Read(reader);
        OffsetPtr m_RootMotionSkeleton = OffsetPtr.Read(reader);
        OffsetPtr m_RootMotionSkeletonPose = OffsetPtr.Read(reader);
        int[] m_RootMotionSkeletonIndexArray = Array<int>.Read(reader);
        
        return new(m_AvatarSkeleton,
            m_AvatarSkeletonPose,
            m_DefaultPose,
            m_SkeletonNameIDArray,
            m_Human,
            m_HumanSkeletonIndexArray,
            m_HumanSkeletonReverseIndexArray,
            m_RootMotionBoneIndex,
            m_RootMotionBoneX,
            m_RootMotionSkeleton,
            m_RootMotionSkeletonPose,
            m_RootMotionSkeletonIndexArray);
    }
}

/* $SkeletonBoneLimit (5 fields) (None) */
public record class SkeletonBoneLimit(
    Vector3f m_Min,
    Vector3f m_Max,
    Vector3f m_Value,
    float m_Length,
    bool m_Modified)
{
    public static SkeletonBoneLimit Read(EndianBinaryReader reader)
    {
        Vector3f m_Min = Vector3f.Read(reader);
        Vector3f m_Max = Vector3f.Read(reader);
        Vector3f m_Value = Vector3f.Read(reader);
        float m_Length = reader.ReadF32();
        bool m_Modified = reader.ReadBool();
        
        return new(m_Min,
            m_Max,
            m_Value,
            m_Length,
            m_Modified);
    }
}

/* $HumanBone (3 fields) (None) */
public record class HumanBone(
    AsciiString m_BoneName,
    AsciiString m_HumanName,
    SkeletonBoneLimit m_Limit)
{
    public static HumanBone Read(EndianBinaryReader reader)
    {
        AsciiString m_BoneName = String.Read(reader);
        AsciiString m_HumanName = String.Read(reader);
        SkeletonBoneLimit m_Limit = SkeletonBoneLimit.Read(reader);
        
        return new(m_BoneName,
            m_HumanName,
            m_Limit);
    }
}

/* $SkeletonBone (5 fields) (None) */
public record class SkeletonBone(
    AsciiString m_Name,
    AsciiString m_ParentName,
    Vector3f m_Position,
    Quaternionf m_Rotation,
    Vector3f m_Scale)
{
    public static SkeletonBone Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        AsciiString m_ParentName = String.Read(reader);
        Vector3f m_Position = Vector3f.Read(reader);
        Quaternionf m_Rotation = Quaternionf.Read(reader);
        Vector3f m_Scale = Vector3f.Read(reader);
        
        return new(m_Name,
            m_ParentName,
            m_Position,
            m_Rotation,
            m_Scale);
    }
}

/* $HumanDescription (14 fields) (None) */
public record class HumanDescription(
    HumanBone[] m_Human,
    SkeletonBone[] m_Skeleton,
    float m_ArmTwist,
    float m_ForeArmTwist,
    float m_UpperLegTwist,
    float m_LegTwist,
    float m_ArmStretch,
    float m_LegStretch,
    float m_FeetSpacing,
    float m_GlobalScale,
    AsciiString m_RootMotionBoneName,
    bool m_HasTranslationDoF,
    bool m_HasExtraRoot,
    bool m_SkeletonHasParents)
{
    public static HumanDescription Read(EndianBinaryReader reader)
    {
        HumanBone[] m_Human = Array<HumanBone>.Read(reader);
        SkeletonBone[] m_Skeleton = Array<SkeletonBone>.Read(reader);
        float m_ArmTwist = reader.ReadF32();
        float m_ForeArmTwist = reader.ReadF32();
        float m_UpperLegTwist = reader.ReadF32();
        float m_LegTwist = reader.ReadF32();
        float m_ArmStretch = reader.ReadF32();
        float m_LegStretch = reader.ReadF32();
        float m_FeetSpacing = reader.ReadF32();
        float m_GlobalScale = reader.ReadF32();
        AsciiString m_RootMotionBoneName = String.Read(reader);
        bool m_HasTranslationDoF = reader.ReadBool();
        bool m_HasExtraRoot = reader.ReadBool();
        bool m_SkeletonHasParents = reader.ReadBool();
        
        return new(m_Human,
            m_Skeleton,
            m_ArmTwist,
            m_ForeArmTwist,
            m_UpperLegTwist,
            m_LegTwist,
            m_ArmStretch,
            m_LegStretch,
            m_FeetSpacing,
            m_GlobalScale,
            m_RootMotionBoneName,
            m_HasTranslationDoF,
            m_HasExtraRoot,
            m_SkeletonHasParents);
    }
}

/* $LineParameters (10 fields) (None) */
public record class LineParameters(
    float widthMultiplier,
    AnimationCurve widthCurve,
    Gradient colorGradient,
    int numCornerVertices,
    int numCapVertices,
    int alignment,
    int textureMode,
    Vector2f textureScale,
    float shadowBias,
    bool generateLightingData)
{
    public static LineParameters Read(EndianBinaryReader reader)
    {
        float widthMultiplier = reader.ReadF32();
        AnimationCurve widthCurve = AnimationCurve.Read(reader);
        Gradient colorGradient = Gradient.Read(reader);
        int numCornerVertices = reader.ReadS32();
        int numCapVertices = reader.ReadS32();
        int alignment = reader.ReadS32();
        int textureMode = reader.ReadS32();
        Vector2f textureScale = Vector2f.Read(reader);
        float shadowBias = reader.ReadF32();
        bool generateLightingData = reader.ReadBool();
        
        return new(widthMultiplier,
            widthCurve,
            colorGradient,
            numCornerVertices,
            numCapVertices,
            alignment,
            textureMode,
            textureScale,
            shadowBias,
            generateLightingData);
    }
}

/* $DirectorGenericBinding (2 fields) (None) */
public record class DirectorGenericBinding(
    PPtr<Object> key,
    PPtr<Object> @value)
{
    public static DirectorGenericBinding Read(EndianBinaryReader reader)
    {
        PPtr<Object> key = PPtr<Object>.Read(reader);
        PPtr<Object> @value = PPtr<Object>.Read(reader);
        
        return new(key,
            @value);
    }
}

/* $ExposedReferenceTable (1 fields) (None) */
public record class ExposedReferenceTable(
    Dictionary<AsciiString, PPtr<Object>> m_References)
{
    public static ExposedReferenceTable Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, PPtr<Object>> m_References = Map<AsciiString, PPtr<Object>>.Read(reader);
        
        return new(m_References);
    }
}

/* $AnimationClipOverride (2 fields) (None) */
public record class AnimationClipOverride(
    PPtr<AnimationClip> m_OriginalClip,
    PPtr<AnimationClip> m_OverrideClip)
{
    public static AnimationClipOverride Read(EndianBinaryReader reader)
    {
        PPtr<AnimationClip> m_OriginalClip = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClip> m_OverrideClip = PPtr<AnimationClip>.Read(reader);
        
        return new(m_OriginalClip,
            m_OverrideClip);
    }
}

/* $LODRenderer (1 fields) (None) */
public record class LODRenderer(
    PPtr<Renderer> renderer)
{
    public static LODRenderer Read(EndianBinaryReader reader)
    {
        PPtr<Renderer> renderer = PPtr<Renderer>.Read(reader);
        
        return new(renderer);
    }
}

/* $LOD (3 fields) (None) */
public record class LOD(
    float screenRelativeHeight,
    float fadeTransitionWidth,
    LODRenderer[] renderers)
{
    public static LOD Read(EndianBinaryReader reader)
    {
        float screenRelativeHeight = reader.ReadF32();
        float fadeTransitionWidth = reader.ReadF32();
        LODRenderer[] renderers = Array<LODRenderer>.Read(reader);
        
        return new(screenRelativeHeight,
            fadeTransitionWidth,
            renderers);
    }
}

/* forward decl ?RuntimeAnimatorController (no type info) */
public record struct RuntimeAnimatorController;
/* forward decl ?Object (no type info) */
public record struct Object;
/* forward decl ?ArticulationBody (no type info) */
public record struct ArticulationBody;
/* forward decl ?Texture (no type info) */
public record struct Texture;
/* forward decl ?Flare (no type info) */
public record struct Flare;
/* forward decl ?NavMeshData (no type info) */
public record struct NavMeshData;
/* forward decl ?Renderer (no type info) */
public record struct Renderer;
/* forward decl ?AudioSource (no type info) */
public record struct AudioSource;
/* forward decl ?Component (no type info) */
public record struct Component;
/* forward decl ?ParticleSystemForceField (no type info) */
public record struct ParticleSystemForceField;
/* forward decl ?NamedObject (no type info) */
public record struct NamedObject;
