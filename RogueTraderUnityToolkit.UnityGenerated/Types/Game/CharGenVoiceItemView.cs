namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenVoiceItemView (7 fields) 4353630C1F0E12C4D9E35378A4BB83CD/99544DDC90E9C396F738B83C79F099DB */
public record class CharGenVoiceItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_VoiceName /* None */,
    PPtr<Animation>[] m_AudioAnimations /* None */)
{
    public static CharGenVoiceItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VoiceName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Animation>[] _m_AudioAnimations = BuiltInArray<PPtr<Animation>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_VoiceName,
            _m_AudioAnimations);
    }
}

