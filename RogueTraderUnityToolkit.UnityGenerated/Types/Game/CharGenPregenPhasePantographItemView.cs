namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPregenPhasePantographItemView (7 fields) CEB84C687C854833A56EF9EA7972CD5E/DC1DCD98474E8BC0AEEC1272BD91D73F */
public record class CharGenPregenPhasePantographItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<Image> m_Portrait /* None */,
    PPtr<ScrambledTMP> m_DisplayName /* None */)
{
    public static CharGenPregenPhasePantographItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<ScrambledTMP> _m_DisplayName = PPtr<ScrambledTMP>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Portrait,
            _m_DisplayName);
    }
}

