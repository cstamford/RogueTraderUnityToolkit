namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TransitionEntryBaseView (6 fields) 4751660E490FEB17B8DE37F83CFE015F/A65C57ADE437CFD8D8F56D196EE56747 */
public record class TransitionEntryBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Reference m_EntranceEntry /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MapButton /* NeedsAlign */)
{
    public static TransitionEntryBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EntranceEntry */
        Reference _m_EntranceEntry = Reference.Read(reader);
        reader.AlignTo(4); /* m_MapButton */
        PPtr<OwlcatMultiButton> _m_MapButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EntranceEntry,
            _m_MapButton);
    }
}

