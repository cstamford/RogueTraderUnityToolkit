namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $GameObject (5 fields) (IsEngineType) */
public record class GameObject(
    ComponentPair[] m_Component,
    uint m_Layer,
    AsciiString m_Name,
    ushort m_Tag,
    bool m_IsActive)
{
    public static GameObject Read(EndianBinaryReader reader)
    {
        ComponentPair[] m_Component = Array<ComponentPair>.Read(reader);
        uint m_Layer = reader.ReadU32();
        AsciiString m_Name = String.Read(reader);
        ushort m_Tag = reader.ReadU16();
        bool m_IsActive = reader.ReadBool();
        
        return new(m_Component,
            m_Layer,
            m_Name,
            m_Tag,
            m_IsActive);
    }
}

