namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ForcedCullingRadius (6 fields) 23B995D72D5F00B34DDF9D954D849B6C/BB6DD3BAF311D33FB80569F4492ADBCB */
public record class ForcedCullingRadius(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float Radius /* NeedsAlign */,
    byte m_Static /* None */)
{
    public static ForcedCullingRadius Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Radius */
        float _Radius = reader.ReadF32();
        byte _m_Static = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Radius,
            _m_Static);
    }
}

