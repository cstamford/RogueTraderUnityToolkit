namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxDecal (13 fields) 39AA3808C6D2D4B2CD5BF5702192A63D/89CED26D9D6ED9C0CCBDFF943D9A8036 */
public record class FxDecal(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> m_Material /* NeedsAlign */,
    int m_Layer /* None */,
    byte m_ValidateHeight /* None */,
    BitField m_RaycastMask /* NeedsAlign */,
    Ramp m_ColorRamp /* None */,
    float Delay /* NeedsAlign */,
    byte IsInvisibleWhileDelay /* None */,
    FxDecalAnimationSettings[] Animations /* NeedsAlign */,
    byte UseScaleAnimation /* NeedsAlign */)
{
    public static FxDecal Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Material */
        PPtr<Material> _m_Material = PPtr<Material>.Read(reader);
        int _m_Layer = reader.ReadS32();
        byte _m_ValidateHeight = reader.ReadU8();
        reader.AlignTo(4); /* m_RaycastMask */
        BitField _m_RaycastMask = BitField.Read(reader);
        Ramp _m_ColorRamp = Ramp.Read(reader);
        reader.AlignTo(4); /* Delay */
        float _Delay = reader.ReadF32();
        byte _IsInvisibleWhileDelay = reader.ReadU8();
        reader.AlignTo(4); /* Animations */
        FxDecalAnimationSettings[] _Animations = BuiltInArray<FxDecalAnimationSettings>.Read(reader);
        reader.AlignTo(4); /* UseScaleAnimation */
        byte _UseScaleAnimation = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Material,
            _m_Layer,
            _m_ValidateHeight,
            _m_RaycastMask,
            _m_ColorRamp,
            _Delay,
            _IsInvisibleWhileDelay,
            _Animations,
            _UseScaleAnimation);
    }
}

