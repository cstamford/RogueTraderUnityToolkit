namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaNavigationElementBaseView (10 fields) 132C8104A56F05F40342E27BECE7D4CA/78BB72BB44F8B89298511402C6C45CB5 */
public record class EncyclopediaNavigationElementBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */,
    PPtr<Image> m_UncommitedPlanetsBigIcon /* None */,
    PPtr<Image> m_UncommitedPlanetsLittleIcon /* None */,
    byte m_isBigImage /* None */,
    PPtr<Sprite> m_PantographUncommittedIcon /* NeedsAlign */)
{
    public static EncyclopediaNavigationElementBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_UncommitedPlanetsBigIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_UncommitedPlanetsLittleIcon = PPtr<Image>.Read(reader);
        byte _m_isBigImage = reader.ReadU8();
        reader.AlignTo(4); /* m_PantographUncommittedIcon */
        PPtr<Sprite> _m_PantographUncommittedIcon = PPtr<Sprite>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_MultiButton,
            _m_UncommitedPlanetsBigIcon,
            _m_UncommitedPlanetsLittleIcon,
            _m_isBigImage,
            _m_PantographUncommittedIcon);
    }
}

