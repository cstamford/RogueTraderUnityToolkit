namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Billboard (7 fields) 1EF47D32E902D5F45C458B381FF9B8CE/1984E7F21D93FD0CF1EDE326E7663A92 */
public record class Billboard(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int BillboardAxis /* NeedsAlign */,
    LockAxisSettings m_LockAxis /* None */,
    byte ApplyAtFirstFrameOnly /* NeedsAlign */)
{
    public static Billboard Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BillboardAxis */
        int _BillboardAxis = reader.ReadS32();
        LockAxisSettings _m_LockAxis = LockAxisSettings.Read(reader);
        reader.AlignTo(4); /* ApplyAtFirstFrameOnly */
        byte _ApplyAtFirstFrameOnly = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BillboardAxis,
            _m_LockAxis,
            _ApplyAtFirstFrameOnly);
    }
}

