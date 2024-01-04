namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MoveAnimator (9 fields) EB5D7A0EAEAED2CBB6F61F970413D08E/892FEEC801CA0C56BC0C05BA07E7EFD5 */
public record class MoveAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte Relatively /* NeedsAlign */,
    byte MoveByX /* NeedsAlign */,
    MovePart MovePartX /* NeedsAlign */,
    byte MoveByY /* NeedsAlign */,
    MovePart MovePartY /* NeedsAlign */)
{
    public static MoveAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Relatively */
        byte _Relatively = reader.ReadU8();
        reader.AlignTo(4); /* MoveByX */
        byte _MoveByX = reader.ReadU8();
        reader.AlignTo(4); /* MovePartX */
        MovePart _MovePartX = MovePart.Read(reader);
        reader.AlignTo(4); /* MoveByY */
        byte _MoveByY = reader.ReadU8();
        reader.AlignTo(4); /* MovePartY */
        MovePart _MovePartY = MovePart.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Relatively,
            _MoveByX,
            _MovePartX,
            _MoveByY,
            _MovePartY);
    }
}

