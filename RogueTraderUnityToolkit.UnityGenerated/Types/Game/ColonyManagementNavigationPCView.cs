namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyManagementNavigationPCView (5 fields) BDE1C4A4F219AED59BA0FEAD2D63156B/BCFBD9B0D0585E68DCE8C2165C88CBA5 */
public record class ColonyManagementNavigationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ColonyManagementNavigationElementPCView>[] m_ColoniesTabs /* NeedsAlign */)
{
    public static ColonyManagementNavigationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColoniesTabs */
        PPtr<ColonyManagementNavigationElementPCView>[] _m_ColoniesTabs = BuiltInArray<PPtr<ColonyManagementNavigationElementPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColoniesTabs);
    }
}

