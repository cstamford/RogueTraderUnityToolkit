namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TechUseRestriction (5 fields) 83FC29DF71D159F1F715B71C54C3FCF7/389F07369B529DF9BADB9025E27C22D6 */
public record class TechUseRestriction(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    TechUseRestrictionSettings Settings /* NeedsAlign */)
{
    public static TechUseRestriction Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Settings */
        TechUseRestrictionSettings _Settings = TechUseRestrictionSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Settings);
    }
}

