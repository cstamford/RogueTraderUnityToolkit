namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerCorpseInteraction (7 fields) 9FC2DB502EB66BE3423B80DFAC3CFD5B/048C81BC4CC524814F64D26FD08ABAC7 */
public record class SpawnerCorpseInteraction(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    InteractionSkillCheckSettings m_Settings /* NeedsAlign */,
    BlueprintDynamicMapObjectReference m_ObjectReference /* NeedsAlign */,
    byte m_EnableInteractionOnDeath /* NeedsAlign */)
{
    public static SpawnerCorpseInteraction Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Settings */
        InteractionSkillCheckSettings _m_Settings = InteractionSkillCheckSettings.Read(reader);
        reader.AlignTo(4); /* m_ObjectReference */
        BlueprintDynamicMapObjectReference _m_ObjectReference = BlueprintDynamicMapObjectReference.Read(reader);
        reader.AlignTo(4); /* m_EnableInteractionOnDeath */
        byte _m_EnableInteractionOnDeath = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Settings,
            _m_ObjectReference,
            _m_EnableInteractionOnDeath);
    }
}

