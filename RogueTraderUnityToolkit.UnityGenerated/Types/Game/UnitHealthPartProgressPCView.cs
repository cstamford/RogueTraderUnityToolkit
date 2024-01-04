namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitHealthPartProgressPCView (9 fields) 009FFF06879F8EE424337982C860B0D7/8FC496AD291C85B3C96D06B55AFC30A6 */
public record class UnitHealthPartProgressPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Slider> m_Health /* NeedsAlign */,
    PPtr<Slider> m_TempHealth /* None */,
    DamageColorSet m_Party /* None */,
    DamageColorSet m_Ally /* None */,
    DamageColorSet m_Enemy /* None */)
{
    public static UnitHealthPartProgressPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Health */
        PPtr<Slider> _m_Health = PPtr<Slider>.Read(reader);
        PPtr<Slider> _m_TempHealth = PPtr<Slider>.Read(reader);
        DamageColorSet _m_Party = DamageColorSet.Read(reader);
        DamageColorSet _m_Ally = DamageColorSet.Read(reader);
        DamageColorSet _m_Enemy = DamageColorSet.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Health,
            _m_TempHealth,
            _m_Party,
            _m_Ally,
            _m_Enemy);
    }
}

