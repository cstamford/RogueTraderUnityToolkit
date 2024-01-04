namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SetPathToTrapMechanics (10 fields) 2DDB9FD628B9B1C5DBF74AD2B9F77C47/7F039DA8306B562384F3780876AB16F0 */
public record class SetPathToTrapMechanics(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_LineHeight /* NeedsAlign */,
    PPtr<Transform> _start /* None */,
    PPtr<Transform> _end /* None */,
    BitField _raycastLayers /* None */,
    float _projectionHeightOffset /* None */,
    float _projectedLineHeight /* None */)
{
    public static SetPathToTrapMechanics Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LineHeight */
        float _m_LineHeight = reader.ReadF32();
        PPtr<Transform> __start = PPtr<Transform>.Read(reader);
        PPtr<Transform> __end = PPtr<Transform>.Read(reader);
        BitField __raycastLayers = BitField.Read(reader);
        float __projectionHeightOffset = reader.ReadF32();
        float __projectedLineHeight = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LineHeight,
            __start,
            __end,
            __raycastLayers,
            __projectionHeightOffset,
            __projectedLineHeight);
    }
}

