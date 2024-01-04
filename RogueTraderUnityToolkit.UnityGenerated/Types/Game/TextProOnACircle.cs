namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TextProOnACircle (11 fields) D98EAB5E0F507D54279B18E734A7F797/5530B83DDF29A12BE30310356310146C */
public record class TextProOnACircle(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_radius /* NeedsAlign */,
    float m_arcDegrees /* None */,
    float m_angularOffset /* None */,
    int m_maxDegreesPerLetter /* None */,
    byte m_mirrorCharacters /* None */,
    byte m_shrinkEmptySpace /* NeedsAlign */,
    float m_extraSpacing /* NeedsAlign */)
{
    public static TextProOnACircle Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_radius */
        float _m_radius = reader.ReadF32();
        float _m_arcDegrees = reader.ReadF32();
        float _m_angularOffset = reader.ReadF32();
        int _m_maxDegreesPerLetter = reader.ReadS32();
        byte _m_mirrorCharacters = reader.ReadU8();
        reader.AlignTo(4); /* m_shrinkEmptySpace */
        byte _m_shrinkEmptySpace = reader.ReadU8();
        reader.AlignTo(4); /* m_extraSpacing */
        float _m_extraSpacing = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_radius,
            _m_arcDegrees,
            _m_angularOffset,
            _m_maxDegreesPerLetter,
            _m_mirrorCharacters,
            _m_shrinkEmptySpace,
            _m_extraSpacing);
    }
}

