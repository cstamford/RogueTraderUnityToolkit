namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $PhysicMaterial (6 fields) ABE3FF3FE0CC7651F45F5F867D42FAF2 */
public record class PhysicMaterial(
    AsciiString m_Name /* None */,
    float dynamicFriction /* NeedsAlign */,
    float staticFriction /* None */,
    float bounciness /* None */,
    int frictionCombine /* None */,
    int bounceCombine /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2883845951, 3771496017, 4099891078, 2101541618);
    public static PhysicMaterial Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* dynamicFriction */
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
}

