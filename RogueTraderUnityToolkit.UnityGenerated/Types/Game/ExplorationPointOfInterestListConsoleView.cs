namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationPointOfInterestListConsoleView (5 fields) BD07BB35EFAE2ECC65913414CC876574/81D9A82CE187DF5D4DD1D7C5A3005138 */
public record class ExplorationPointOfInterestListConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PointsVariant m_ExplorationPointsVariants /* NeedsAlign */)
{
    public static ExplorationPointOfInterestListConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExplorationPointsVariants */
        PointsVariant _m_ExplorationPointsVariants = PointsVariant.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExplorationPointsVariants);
    }
}

