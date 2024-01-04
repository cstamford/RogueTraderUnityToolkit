namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsRewardElementConsoleView (6 fields) 3900A49A3F6462452853AA2678354C68/5584C55D7954970133783EEDA663B7EC */
public record class ColonyProjectsRewardElementConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColonyProjectsRewardElementVisual[] m_VisualVariants /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_MultiButton /* NeedsAlign */)
{
    public static ColonyProjectsRewardElementConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VisualVariants */
        ColonyProjectsRewardElementVisual[] _m_VisualVariants = BuiltInArray<ColonyProjectsRewardElementVisual>.Read(reader);
        reader.AlignTo(4); /* m_MultiButton */
        PPtr<OwlcatMultiSelectable> _m_MultiButton = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VisualVariants,
            _m_MultiButton);
    }
}

