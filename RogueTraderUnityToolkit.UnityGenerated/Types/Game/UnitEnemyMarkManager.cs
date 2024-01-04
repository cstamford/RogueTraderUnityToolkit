namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitEnemyMarkManager (5 fields) 11E4F4803B15A26A83E708554DAFE2C4/3BC22BC1A8E32CA944A8C90ACAACF1AC */
public record class UnitEnemyMarkManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BaseUnitMark> UnitMarkPrefab /* NeedsAlign */)
{
    public static UnitEnemyMarkManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* UnitMarkPrefab */
        PPtr<BaseUnitMark> _UnitMarkPrefab = PPtr<BaseUnitMark>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _UnitMarkPrefab);
    }
}

