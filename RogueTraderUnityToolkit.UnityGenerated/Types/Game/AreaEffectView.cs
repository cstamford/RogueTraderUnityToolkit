namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AreaEffectView (8 fields) 05D1B3DE8DEB395CB23447B9F5A6D09E/4AF102BA21786F073376B8467B5AA0AA */
public record class AreaEffectView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    BlueprintAbilityAreaEffectReference m_Blueprint /* NeedsAlign */,
    BlueprintUnitReference m_Caster /* NeedsAlign */)
{
    public static AreaEffectView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Blueprint */
        BlueprintAbilityAreaEffectReference _m_Blueprint = BlueprintAbilityAreaEffectReference.Read(reader);
        reader.AlignTo(4); /* m_Caster */
        BlueprintUnitReference _m_Caster = BlueprintUnitReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_Blueprint,
            _m_Caster);
    }
}

