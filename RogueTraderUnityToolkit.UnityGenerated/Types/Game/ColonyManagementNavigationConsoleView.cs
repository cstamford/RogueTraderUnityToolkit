namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyManagementNavigationConsoleView (5 fields) E420DE3716399B58AC982B073B265366/61E3C1A925B2B792E4C09EECAD7DA8B8 */
public record class ColonyManagementNavigationConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ColonyManagementNavigationElementConsoleView>[] m_ColoniesTabs /* NeedsAlign */)
{
    public static ColonyManagementNavigationConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColoniesTabs */
        PPtr<ColonyManagementNavigationElementConsoleView>[] _m_ColoniesTabs = BuiltInArray<PPtr<ColonyManagementNavigationElementConsoleView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColoniesTabs);
    }
}

