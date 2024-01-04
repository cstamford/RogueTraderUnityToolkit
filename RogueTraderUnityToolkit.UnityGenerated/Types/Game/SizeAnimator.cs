namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SizeAnimator (12 fields) AAB04380ACC2B4D8AF0DEDB43E7320A2/E8141EB0A1A71C269C64288EC89B31B2 */
public record class SizeAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte SizeByX /* NeedsAlign */,
    MovePart PartX /* NeedsAlign */,
    byte SizeByY /* None */,
    MovePart PartY /* NeedsAlign */,
    float m_AppearTime /* None */,
    int m_AppearAnimCurve /* None */,
    float m_DisappearTime /* None */,
    int m_DisappearAnimCurve /* None */)
{
    public static SizeAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SizeByX */
        byte _SizeByX = reader.ReadU8();
        reader.AlignTo(4); /* PartX */
        MovePart _PartX = MovePart.Read(reader);
        byte _SizeByY = reader.ReadU8();
        reader.AlignTo(4); /* PartY */
        MovePart _PartY = MovePart.Read(reader);
        float _m_AppearTime = reader.ReadF32();
        int _m_AppearAnimCurve = reader.ReadS32();
        float _m_DisappearTime = reader.ReadF32();
        int _m_DisappearAnimCurve = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SizeByX,
            _PartX,
            _SizeByY,
            _PartY,
            _m_AppearTime,
            _m_AppearAnimCurve,
            _m_DisappearTime,
            _m_DisappearAnimCurve);
    }
}

