namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WarhammerNodeLink (13 fields) 37A1AB25176AE8F68B86D3D6AA7B2CCB/DCD156E6475E274B399F9F2D3E892C5D */
public record class WarhammerNodeLink(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int version /* NeedsAlign */,
    ulong uniqueID /* None */,
    PPtr<Transform> m_Start /* None */,
    PPtr<Transform> m_End /* None */,
    byte m_OverrideCost /* None */,
    float m_Cost /* NeedsAlign */,
    int m_MaxCreatureSize /* None */,
    AABB m_Bounds /* None */,
    PPtr<WarhammerNodeLink> m_ConnectedNode /* None */)
{
    public static WarhammerNodeLink Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* version */
        int _version = reader.ReadS32();
        ulong _uniqueID = reader.ReadU64();
        PPtr<Transform> _m_Start = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_End = PPtr<Transform>.Read(reader);
        byte _m_OverrideCost = reader.ReadU8();
        reader.AlignTo(4); /* m_Cost */
        float _m_Cost = reader.ReadF32();
        int _m_MaxCreatureSize = reader.ReadS32();
        AABB _m_Bounds = AABB.Read(reader);
        PPtr<WarhammerNodeLink> _m_ConnectedNode = PPtr<WarhammerNodeLink>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _version,
            _uniqueID,
            _m_Start,
            _m_End,
            _m_OverrideCost,
            _m_Cost,
            _m_MaxCreatureSize,
            _m_Bounds,
            _m_ConnectedNode);
    }
}

