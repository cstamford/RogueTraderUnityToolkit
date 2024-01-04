namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AbilityPatternCell (7 fields) 5D5B9D89286F1BAE7AD7DD88CA929920/9634FB9A7AF46FAC4E4D1542CD871464 */
public record class AbilityPatternCell(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_CommonView /* NeedsAlign */,
    PPtr<GameObject> m_StartView /* None */,
    PPtr<GameObject> m_CasterView /* None */)
{
    public static AbilityPatternCell Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CommonView */
        PPtr<GameObject> _m_CommonView = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_StartView = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CasterView = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CommonView,
            _m_StartView,
            _m_CasterView);
    }
}

