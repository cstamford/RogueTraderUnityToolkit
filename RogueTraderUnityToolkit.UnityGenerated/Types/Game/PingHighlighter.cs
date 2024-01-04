namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PingHighlighter (8 fields) 0EBBD54059D6161BBE7EA923AAA5829A/A265B60C329F80EA35C2BB03D000ED70 */
public record class PingHighlighter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte IsActive /* NeedsAlign */,
    int Lit /* NeedsAlign */,
    AnimationCurve CurveBlink /* None */,
    PPtr<Graphic> TargetGraphic /* NeedsAlign */)
{
    public static PingHighlighter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* IsActive */
        byte _IsActive = reader.ReadU8();
        reader.AlignTo(4); /* Lit */
        int _Lit = reader.ReadS32();
        AnimationCurve _CurveBlink = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* TargetGraphic */
        PPtr<Graphic> _TargetGraphic = PPtr<Graphic>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _IsActive,
            _Lit,
            _CurveBlink,
            _TargetGraphic);
    }
}

