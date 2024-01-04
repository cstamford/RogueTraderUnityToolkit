namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DescriptorTypeStrings (35 fields) 43A295EBC4D58795C791C26256C5B800/CB6113939C26E067B87C38347887756D */
public record class DescriptorTypeStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString None /* NeedsAlign */,
    LocalizedString Racial /* NeedsAlign */,
    LocalizedString Difficulty /* NeedsAlign */,
    LocalizedString BaseStatBonus /* NeedsAlign */,
    LocalizedString Polymorph /* NeedsAlign */,
    LocalizedString UniqueItem /* NeedsAlign */,
    LocalizedString RighteousFury /* NeedsAlign */,
    LocalizedString ArmorAbsorption /* NeedsAlign */,
    LocalizedString ArmorDeflection /* NeedsAlign */,
    LocalizedString AreaOfEffectAbilityMiss /* NeedsAlign */,
    LocalizedString DegreeOfSuccess /* NeedsAlign */,
    LocalizedString ScatterShot /* NeedsAlign */,
    LocalizedString ArmorPenalty /* NeedsAlign */,
    LocalizedString AttackerPerception /* NeedsAlign */,
    LocalizedString WeaponSkillDifference /* NeedsAlign */,
    LocalizedString BurstFirePenalty /* NeedsAlign */,
    LocalizedString Weapon /* NeedsAlign */,
    LocalizedString AttackerWeaponSkill /* NeedsAlign */,
    LocalizedString OriginAdvancement /* NeedsAlign */,
    LocalizedString CareerAdvancement /* NeedsAlign */,
    LocalizedString OtherAdvancement /* NeedsAlign */,
    LocalizedString Immunity /* NeedsAlign */,
    LocalizedString HitChanceOverkill /* NeedsAlign */,
    LocalizedString DistanceToTarget /* NeedsAlign */,
    LocalizedString BaseValue /* NeedsAlign */,
    LocalizedString UntypedStackable /* NeedsAlign */,
    LocalizedString UntypedUnstackable /* NeedsAlign */,
    LocalizedString Wounds /* NeedsAlign */,
    LocalizedString Trauma /* NeedsAlign */,
    LocalizedString AttackerAgility /* NeedsAlign */,
    LocalizedString ShipSystemComponent /* NeedsAlign */)
{
    public static DescriptorTypeStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* None */
        LocalizedString _None = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Racial */
        LocalizedString _Racial = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Difficulty */
        LocalizedString _Difficulty = LocalizedString.Read(reader);
        reader.AlignTo(4); /* BaseStatBonus */
        LocalizedString _BaseStatBonus = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Polymorph */
        LocalizedString _Polymorph = LocalizedString.Read(reader);
        reader.AlignTo(4); /* UniqueItem */
        LocalizedString _UniqueItem = LocalizedString.Read(reader);
        reader.AlignTo(4); /* RighteousFury */
        LocalizedString _RighteousFury = LocalizedString.Read(reader);
        reader.AlignTo(4); /* ArmorAbsorption */
        LocalizedString _ArmorAbsorption = LocalizedString.Read(reader);
        reader.AlignTo(4); /* ArmorDeflection */
        LocalizedString _ArmorDeflection = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AreaOfEffectAbilityMiss */
        LocalizedString _AreaOfEffectAbilityMiss = LocalizedString.Read(reader);
        reader.AlignTo(4); /* DegreeOfSuccess */
        LocalizedString _DegreeOfSuccess = LocalizedString.Read(reader);
        reader.AlignTo(4); /* ScatterShot */
        LocalizedString _ScatterShot = LocalizedString.Read(reader);
        reader.AlignTo(4); /* ArmorPenalty */
        LocalizedString _ArmorPenalty = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AttackerPerception */
        LocalizedString _AttackerPerception = LocalizedString.Read(reader);
        reader.AlignTo(4); /* WeaponSkillDifference */
        LocalizedString _WeaponSkillDifference = LocalizedString.Read(reader);
        reader.AlignTo(4); /* BurstFirePenalty */
        LocalizedString _BurstFirePenalty = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Weapon */
        LocalizedString _Weapon = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AttackerWeaponSkill */
        LocalizedString _AttackerWeaponSkill = LocalizedString.Read(reader);
        reader.AlignTo(4); /* OriginAdvancement */
        LocalizedString _OriginAdvancement = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CareerAdvancement */
        LocalizedString _CareerAdvancement = LocalizedString.Read(reader);
        reader.AlignTo(4); /* OtherAdvancement */
        LocalizedString _OtherAdvancement = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Immunity */
        LocalizedString _Immunity = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HitChanceOverkill */
        LocalizedString _HitChanceOverkill = LocalizedString.Read(reader);
        reader.AlignTo(4); /* DistanceToTarget */
        LocalizedString _DistanceToTarget = LocalizedString.Read(reader);
        reader.AlignTo(4); /* BaseValue */
        LocalizedString _BaseValue = LocalizedString.Read(reader);
        reader.AlignTo(4); /* UntypedStackable */
        LocalizedString _UntypedStackable = LocalizedString.Read(reader);
        reader.AlignTo(4); /* UntypedUnstackable */
        LocalizedString _UntypedUnstackable = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Wounds */
        LocalizedString _Wounds = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Trauma */
        LocalizedString _Trauma = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AttackerAgility */
        LocalizedString _AttackerAgility = LocalizedString.Read(reader);
        reader.AlignTo(4); /* ShipSystemComponent */
        LocalizedString _ShipSystemComponent = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _None,
            _Racial,
            _Difficulty,
            _BaseStatBonus,
            _Polymorph,
            _UniqueItem,
            _RighteousFury,
            _ArmorAbsorption,
            _ArmorDeflection,
            _AreaOfEffectAbilityMiss,
            _DegreeOfSuccess,
            _ScatterShot,
            _ArmorPenalty,
            _AttackerPerception,
            _WeaponSkillDifference,
            _BurstFirePenalty,
            _Weapon,
            _AttackerWeaponSkill,
            _OriginAdvancement,
            _CareerAdvancement,
            _OtherAdvancement,
            _Immunity,
            _HitChanceOverkill,
            _DistanceToTarget,
            _BaseValue,
            _UntypedStackable,
            _UntypedUnstackable,
            _Wounds,
            _Trauma,
            _AttackerAgility,
            _ShipSystemComponent);
    }
}

