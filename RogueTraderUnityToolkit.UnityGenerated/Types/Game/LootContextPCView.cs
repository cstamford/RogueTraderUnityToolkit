namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootContextPCView (6 fields) 9DB346B930F7E88C48C85CCB38BE17CF/2CB601CCE507C928686451CE71C718E1 */
public record class LootContextPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LootPCView> m_LootPCView /* NeedsAlign */,
    PPtr<CargoRewardsPCView> m_CargoPCView /* None */)
{
    public static LootContextPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LootPCView */
        PPtr<LootPCView> _m_LootPCView = PPtr<LootPCView>.Read(reader);
        PPtr<CargoRewardsPCView> _m_CargoPCView = PPtr<CargoRewardsPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LootPCView,
            _m_CargoPCView);
    }
}

