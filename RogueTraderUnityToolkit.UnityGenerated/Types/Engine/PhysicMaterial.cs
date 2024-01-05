namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PhysicMaterial (6 fields) ABE3FF3FE0CC7651F45F5F867D42FAF2 */
public record class PhysicMaterial(
    AsciiString m_Name,
    float dynamicFriction,
    float staticFriction,
    float bounciness,
    int frictionCombine,
    int bounceCombine) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2883845951, 3771496017, 4099891078, 2101541618);

    public static PhysicMaterial Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        float _dynamicFriction = reader.ReadF32();
        float _staticFriction = reader.ReadF32();
        float _bounciness = reader.ReadF32();
        int _frictionCombine = reader.ReadS32();
        int _bounceCombine = reader.ReadS32();
        
        return new(_m_Name,
            _dynamicFriction,
            _staticFriction,
            _bounciness,
            _frictionCombine,
            _bounceCombine);
    }

    public override string ToString() => $"PhysicMaterial\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("dynamicFriction: ");
        sb.AppendLine(dynamicFriction.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("staticFriction: ");
        sb.AppendLine(staticFriction.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bounciness: ");
        sb.AppendLine(bounciness.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("frictionCombine: ");
        sb.AppendLine(frictionCombine.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("bounceCombine: ");
        sb.AppendLine(bounceCombine.ToString());

        return sb.ToString();
    }
}

