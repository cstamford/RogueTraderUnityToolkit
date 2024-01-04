namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipNameView (6 fields) 3A02517249C04226443EFB5507D68C38/7B7F8CF92F7B60746BFDEE0E2F8BC171 */
public record class OvertipNameView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_CharacterName /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_MultiSelectable /* None */)
{
    public static OvertipNameView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharacterName */
        PPtr<TextMeshProUGUI> _m_CharacterName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_MultiSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharacterName,
            _m_MultiSelectable);
    }
}

