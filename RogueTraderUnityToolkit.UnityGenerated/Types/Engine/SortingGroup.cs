namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $SortingGroup (6 fields) 0A004E96695F1E76758D74B19732785D */
public record class SortingGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    int m_SortingLayerID /* NeedsAlign */,
    short m_SortingLayer /* None */,
    short m_SortingOrder /* None */,
    bool m_SortAtRoot /* None */) : IUnityObject
{
    public static Hash128 Hash => new(167792278, 1767841398, 1972204721, 2536667229);
    public static SortingGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_SortingLayerID */
        int _m_SortingLayerID = reader.ReadS32();
        short _m_SortingLayer = reader.ReadS16();
        short _m_SortingOrder = reader.ReadS16();
        bool _m_SortAtRoot = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_SortingLayerID,
            _m_SortingLayer,
            _m_SortingOrder,
            _m_SortAtRoot);
    }
}

