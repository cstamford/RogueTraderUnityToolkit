namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $GameObject (5 fields) B84EE386B04276EEC998FB89B0D91DD8 */
public record class GameObject(
    ComponentPair[] m_Component,
    uint m_Layer,
    AsciiString m_Name,
    ushort m_Tag,
    bool m_IsActive) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3092177798, 2957145838, 3382246281, 2967018968);

    public static GameObject Read(EndianBinaryReader reader)
    {
        ComponentPair[] _m_Component = BuiltInArray<ComponentPair>.Read(reader);
        reader.AlignTo(4); /* m_Component */
        uint _m_Layer = reader.ReadU32();
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        ushort _m_Tag = reader.ReadU16();
        bool _m_IsActive = reader.ReadBool();
        
        return new(_m_Component,
            _m_Layer,
            _m_Name,
            _m_Tag,
            _m_IsActive);
    }

    public override string ToString() => $"GameObject\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Component: ");
        sb.AppendLine(m_Component.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Layer: ");
        sb.AppendLine(m_Layer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tag: ");
        sb.AppendLine(m_Tag.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsActive: ");
        sb.AppendLine(m_IsActive.ToString());

        return sb.ToString();
    }
}

