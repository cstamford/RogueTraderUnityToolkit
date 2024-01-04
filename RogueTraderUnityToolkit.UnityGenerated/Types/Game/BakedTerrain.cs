namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BakedTerrain (8 fields) A665F6AD907943ABA2FED68B786704A4/C80E3F61A27A7A29F017C1329B644F2C */
public record class BakedTerrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Terrain> Terrain /* NeedsAlign */,
    PPtr<MeshRenderer>[] Meshes /* None */,
    long BakeTime /* None */,
    int TerrainNamePrefix /* None */)
{
    public static BakedTerrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Terrain */
        PPtr<Terrain> _Terrain = PPtr<Terrain>.Read(reader);
        PPtr<MeshRenderer>[] _Meshes = BuiltInArray<PPtr<MeshRenderer>>.Read(reader);
        long _BakeTime = reader.ReadS64();
        int _TerrainNamePrefix = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Terrain,
            _Meshes,
            _BakeTime,
            _TerrainNamePrefix);
    }
}

