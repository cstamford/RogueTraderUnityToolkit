namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TimeManager (4 fields) TimeManager 6523D3A3355A156FCD8279F091C11238 */
public record class TimeManager (
    float Fixed_Timestep,
    float Maximum_Allowed_Timestep,
    float m_TimeScale,
    float Maximum_Particle_Timestep) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.TimeManager;
    public static Hash128 Hash => new("6523D3A3355A156FCD8279F091C11238");
    public static TimeManager Read(EndianBinaryReader reader)
    {
        float Fixed_Timestep_ = reader.ReadF32();
        float Maximum_Allowed_Timestep_ = reader.ReadF32();
        float m_TimeScale_ = reader.ReadF32();
        float Maximum_Particle_Timestep_ = reader.ReadF32();
        
        return new(Fixed_Timestep_,
            Maximum_Allowed_Timestep_,
            m_TimeScale_,
            Maximum_Particle_Timestep_);
    }

    public override string ToString() => $"TimeManager\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Fixed_Timestep: {Fixed_Timestep}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Maximum_Allowed_Timestep: {Maximum_Allowed_Timestep}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TimeScale: {m_TimeScale}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Maximum_Particle_Timestep: {Maximum_Particle_Timestep}");
    }
}

