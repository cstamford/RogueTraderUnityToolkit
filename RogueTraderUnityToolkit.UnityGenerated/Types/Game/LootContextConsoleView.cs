namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootContextConsoleView (6 fields) 850C8ED0FDD8C3DFA71C05607C9D1AB6/45CB8310D635FC1D9BCF8CAA04DFB192 */
public record class LootContextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LootConsoleView> m_LootConsoleView /* NeedsAlign */,
    PPtr<CargoRewardsConsoleView> m_CargoConsoleView /* None */)
{
    public static LootContextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LootConsoleView */
        PPtr<LootConsoleView> _m_LootConsoleView = PPtr<LootConsoleView>.Read(reader);
        PPtr<CargoRewardsConsoleView> _m_CargoConsoleView = PPtr<CargoRewardsConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LootConsoleView,
            _m_CargoConsoleView);
    }
}

