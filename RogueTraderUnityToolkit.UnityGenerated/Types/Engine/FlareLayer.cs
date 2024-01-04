namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $FlareLayer (2 fields) 8914DAE0941BD801D7679C24C69CE55D */
public record class FlareLayer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2299845344, 2484852737, 3613891620, 3332171101);
    public static FlareLayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled);
    }
}

