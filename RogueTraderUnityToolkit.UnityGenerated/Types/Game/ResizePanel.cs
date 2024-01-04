namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ResizePanel (7 fields) 93F9575C5267FCF268C74100086BF0BB/39308443DEEFEBA8A90DCB05E6AC932F */
public record class ResizePanel(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector2f MaxSize /* NeedsAlign */,
    Vector2f MinSize /* None */,
    int Pivot /* None */)
{
    public static ResizePanel Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MaxSize */
        Vector2f _MaxSize = Vector2f.Read(reader);
        Vector2f _MinSize = Vector2f.Read(reader);
        int _Pivot = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MaxSize,
            _MinSize,
            _Pivot);
    }
}

