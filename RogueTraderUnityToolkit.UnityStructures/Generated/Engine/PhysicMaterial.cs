namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $PhysicMaterial (6 fields) (IsEngineType) */
public record class PhysicMaterial(
    AsciiString m_Name,
    float dynamicFriction,
    float staticFriction,
    float bounciness,
    int frictionCombine,
    int bounceCombine)
{
    public static PhysicMaterial Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        float dynamicFriction = reader.ReadF32();
        float staticFriction = reader.ReadF32();
        float bounciness = reader.ReadF32();
        int frictionCombine = reader.ReadS32();
        int bounceCombine = reader.ReadS32();
        
        return new(m_Name,
            dynamicFriction,
            staticFriction,
            bounciness,
            frictionCombine,
            bounceCombine);
    }
}

