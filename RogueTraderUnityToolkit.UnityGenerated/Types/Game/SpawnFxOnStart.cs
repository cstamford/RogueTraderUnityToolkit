namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnFxOnStart (8 fields) 8932124CDD7DFAC209E8E88DC1BCF02E/8848A0DC91955CF831B5D156CF0132FB */
public record class SpawnFxOnStart(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PrefabLink FxOnStart /* NeedsAlign */,
    PrefabLink FxOnDeath /* NeedsAlign */,
    PrefabLink FxOnDismemberment /* NeedsAlign */,
    byte RemoveOnDeath /* NeedsAlign */)
{
    public static SpawnFxOnStart Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* FxOnStart */
        PrefabLink _FxOnStart = PrefabLink.Read(reader);
        reader.AlignTo(4); /* FxOnDeath */
        PrefabLink _FxOnDeath = PrefabLink.Read(reader);
        reader.AlignTo(4); /* FxOnDismemberment */
        PrefabLink _FxOnDismemberment = PrefabLink.Read(reader);
        reader.AlignTo(4); /* RemoveOnDeath */
        byte _RemoveOnDeath = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _FxOnStart,
            _FxOnDeath,
            _FxOnDismemberment,
            _RemoveOnDeath);
    }
}

