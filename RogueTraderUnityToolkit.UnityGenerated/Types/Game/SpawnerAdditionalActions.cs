namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerAdditionalActions (5 fields) 9B1A34EEEC2E9BCB809893992DBFB295/11955C7C6E3BE0AAAD4864D2652BC896 */
public record class SpawnerAdditionalActions(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ActionsReference SpawnActions /* NeedsAlign */)
{
    public static SpawnerAdditionalActions Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SpawnActions */
        ActionsReference _SpawnActions = ActionsReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SpawnActions);
    }
}

