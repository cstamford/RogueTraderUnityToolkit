namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DestructionStagesViewManager (6 fields) 54311770F5E082F98D63FBADA52F8EED/86A46416033FF9528801C63D95018D5C */
public record class DestructionStagesViewManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float SwitchPrefabsDelaySeconds /* NeedsAlign */,
    StageSettings[] m_Stages /* None */)
{
    public static DestructionStagesViewManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SwitchPrefabsDelaySeconds */
        float _SwitchPrefabsDelaySeconds = reader.ReadF32();
        StageSettings[] _m_Stages = BuiltInArray<StageSettings>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SwitchPrefabsDelaySeconds,
            _m_Stages);
    }
}

