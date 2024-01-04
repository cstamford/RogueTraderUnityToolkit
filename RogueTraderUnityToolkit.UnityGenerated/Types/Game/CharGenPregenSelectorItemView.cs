namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPregenSelectorItemView (9 fields) CE4239795793D1341954F23490D4DC0D/9D98ECB4565195137D4740A9B631BCA0 */
public record class CharGenPregenSelectorItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_PregenNameText /* None */,
    PPtr<GameObject> m_PortraitGroup /* None */,
    PPtr<Image> m_PortraitImage /* None */,
    PPtr<CharGenPregenPhasePantographItemView> m_PantographItemView /* None */)
{
    public static CharGenPregenSelectorItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PregenNameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PortraitGroup = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_PortraitImage = PPtr<Image>.Read(reader);
        PPtr<CharGenPregenPhasePantographItemView> _m_PantographItemView = PPtr<CharGenPregenPhasePantographItemView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_PregenNameText,
            _m_PortraitGroup,
            _m_PortraitImage,
            _m_PantographItemView);
    }
}

