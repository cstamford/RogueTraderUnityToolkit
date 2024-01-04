namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LoreXenosRestriction (5 fields) 66F0A4F32839FFACF00F4B06F3E48E50/7A4F8BECCFEBFC47EBF7BC6713D47C53 */
public record class LoreXenosRestriction(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LoreXenosRestrictionSettings Settings /* NeedsAlign */)
{
    public static LoreXenosRestriction Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Settings */
        LoreXenosRestrictionSettings _Settings = LoreXenosRestrictionSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Settings);
    }
}

