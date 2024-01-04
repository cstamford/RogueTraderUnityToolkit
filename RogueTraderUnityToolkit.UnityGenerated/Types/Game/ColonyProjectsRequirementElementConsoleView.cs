namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsRequirementElementConsoleView (8 fields) 8BDD5B7AF6340A156FDBE926C5247B2C/4B1A0CD014EB357658AB607729147B60 */
public record class ColonyProjectsRequirementElementConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColonyProjectsRequirementElementVisual[] m_VisualVariants /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_MainButton /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_BackgroundSelectable /* None */,
    PPtr<GameObject> m_CheckmarkIcon /* None */)
{
    public static ColonyProjectsRequirementElementConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VisualVariants */
        ColonyProjectsRequirementElementVisual[] _m_VisualVariants = BuiltInArray<ColonyProjectsRequirementElementVisual>.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiSelectable> _m_MainButton = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_BackgroundSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<GameObject> _m_CheckmarkIcon = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VisualVariants,
            _m_MainButton,
            _m_BackgroundSelectable,
            _m_CheckmarkIcon);
    }
}

