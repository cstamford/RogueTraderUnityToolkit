namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $GameObject (5 fields) B84EE386B04276EEC998FB89B0D91DD8 */
public record class GameObject(
    ComponentPair[] m_Component /* None */,
    uint m_Layer /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ushort m_Tag /* NeedsAlign */,
    bool m_IsActive /* None */) : IUnityObject
{
    public static Hash128 Hash => new(3092177798, 2957145838, 3382246281, 2967018968);
    public static GameObject Read(EndianBinaryReader reader)
    {
        ComponentPair[] _m_Component = BuiltInArray<ComponentPair>.Read(reader);
        reader.AlignTo(4); /* m_Layer */
        uint _m_Layer = reader.ReadU32();
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Tag */
        ushort _m_Tag = reader.ReadU16();
        bool _m_IsActive = reader.ReadBool();
        
        return new(_m_Component,
            _m_Layer,
            _m_Name,
            _m_Tag,
            _m_IsActive);
    }
}

