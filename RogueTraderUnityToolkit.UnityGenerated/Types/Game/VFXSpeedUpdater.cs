namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXSpeedUpdater (7 fields) 30D6434C5D38E2C9180721BC265BD2CC/7D29DA68DBFD5A086391944C0E430261 */
public record class VFXSpeedUpdater(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float InHandSpeed /* NeedsAlign */,
    float OutHandSpeed /* None */,
    float AttackSpeed /* None */)
{
    public static VFXSpeedUpdater Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* InHandSpeed */
        float _InHandSpeed = reader.ReadF32();
        float _OutHandSpeed = reader.ReadF32();
        float _AttackSpeed = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _InHandSpeed,
            _OutHandSpeed,
            _AttackSpeed);
    }
}

