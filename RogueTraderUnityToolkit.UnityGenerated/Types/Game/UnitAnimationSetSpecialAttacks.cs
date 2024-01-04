namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationSetSpecialAttacks (5 fields) FE584CE57EDEAB34FE818DAA3F79A118/75B70AF168625727E7805CC1BE640264 */
public record class UnitAnimationSetSpecialAttacks(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UnitAnimationActionSpecialAttack>[] m_Actions /* NeedsAlign */)
{
    public static UnitAnimationSetSpecialAttacks Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Actions */
        PPtr<UnitAnimationActionSpecialAttack>[] _m_Actions = BuiltInArray<PPtr<UnitAnimationActionSpecialAttack>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Actions);
    }
}

