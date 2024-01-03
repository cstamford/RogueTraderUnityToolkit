namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Vector3f (3 fields) (None) */
public readonly record struct Vector3f(
    float x,
    float y,
    float z)
{
    public static Vector3f Read(EndianBinaryReader reader)
    {
        float x = reader.ReadF32();
        float y = reader.ReadF32();
        float z = reader.ReadF32();
        
        return new(x,
            y,
            z);
    }
}

