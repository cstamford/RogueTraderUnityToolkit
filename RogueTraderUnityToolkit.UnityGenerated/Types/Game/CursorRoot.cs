namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CursorRoot (5 fields) AE880EFAE111C0D51A5061FFF5FE9D0F/87BF87511B2D5D72DBCBC2B087F6A3CE */
public record class CursorRoot(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    CursorEntry[] m_CursorEntries /* NeedsAlign */)
{
    public static CursorRoot Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CursorEntries */
        CursorEntry[] _m_CursorEntries = BuiltInArray<CursorEntry>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CursorEntries);
    }
}

