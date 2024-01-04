namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationPointOfInterestListPCView (5 fields) 1B2D35806D68595BB309204A5A985D47/C92DC1F03591634BE0B815BBE27907E5 */
public record class ExplorationPointOfInterestListPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PointsVariant[] m_ExplorationPointsVariants /* NeedsAlign */)
{
    public static ExplorationPointOfInterestListPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExplorationPointsVariants */
        PointsVariant[] _m_ExplorationPointsVariants = BuiltInArray<PointsVariant>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExplorationPointsVariants);
    }
}

