namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Seeker (11 fields) 23A015B81DF0925C331C96C6D0A0B6F1/DD551D1C0CE13474EC19757C4A32AEF8 */
public record class Seeker(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int version /* NeedsAlign */,
    byte drawGizmos /* None */,
    byte detailedGizmos /* NeedsAlign */,
    StartEndModifier startEndModifier /* NeedsAlign */,
    int traversableTags /* NeedsAlign */,
    int[] tagPenalties /* None */,
    GraphMask graphMask /* NeedsAlign */)
{
    public static Seeker Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* version */
        int _version = reader.ReadS32();
        byte _drawGizmos = reader.ReadU8();
        reader.AlignTo(4); /* detailedGizmos */
        byte _detailedGizmos = reader.ReadU8();
        reader.AlignTo(4); /* startEndModifier */
        StartEndModifier _startEndModifier = StartEndModifier.Read(reader);
        reader.AlignTo(4); /* traversableTags */
        int _traversableTags = reader.ReadS32();
        int[] _tagPenalties = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* graphMask */
        GraphMask _graphMask = GraphMask.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _version,
            _drawGizmos,
            _detailedGizmos,
            _startEndModifier,
            _traversableTags,
            _tagPenalties,
            _graphMask);
    }
}

