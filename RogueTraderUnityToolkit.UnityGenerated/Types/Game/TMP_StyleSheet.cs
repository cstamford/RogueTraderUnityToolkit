namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_StyleSheet (5 fields) 0855816332CFD6DF3A595C9D8868E7C8/5659738774C15BA27400139E0B5B6B67 */
public record class TMP_StyleSheet(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    TMP_Style[] m_StyleList /* NeedsAlign */)
{
    public static TMP_StyleSheet Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StyleList */
        TMP_Style[] _m_StyleList = BuiltInArray<TMP_Style>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StyleList);
    }
}

