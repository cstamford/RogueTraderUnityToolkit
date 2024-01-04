namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GameLogStrings (154 fields) 3E88EA8F2FE46A492FF497C9FE45A0D2/00F0642C2D0CDD17563852432F97A4F1 */
public record class GameLogStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA DefaultColor /* NeedsAlign */,
    ColorRGBA ColorMultiplier /* None */,
    PPtr<Sprite> LeftArrowSprite /* None */,
    PPtr<Sprite> RightArrowSprite /* None */,
    PPtr<Sprite> DiesSprite /* None */,
    PPtr<Sprite> MomentumSprite /* None */,
    PPtr<Sprite> VeilThicknessSprite /* None */,
    PPtr<Sprite> BuffSprite /* None */,
    PPtr<Sprite> TraumaSprite /* None */,
    PPtr<Sprite> FolderSprite /* None */,
    PPtr<Sprite>[] NumberShots /* None */,
    ColorTextString MomentumColorText /* None */,
    ColorTextString VeilThicknessColorText /* NeedsAlign */,
    ColorTextString PushColorText /* NeedsAlign */,
    ColorTextString OverpenetrationColorText /* NeedsAlign */,
    ColorTextString CriticalHitColorText /* NeedsAlign */,
    GameLogMessage WarhammerDealDamage /* NeedsAlign */,
    GameLogMessage WarhammerHitNoDamage /* NeedsAlign */,
    GameLogMessage WarhammerRFHit /* NeedsAlign */,
    GameLogMessage WarhammerMeleeHitSuperiority /* NeedsAlign */,
    GameLogMessage WarhammerMeleeRFHitSuperiority /* NeedsAlign */,
    GameLogMessage WarhammerCoverHit /* NeedsAlign */,
    GameLogMessage WarhammerMiss /* NeedsAlign */,
    GameLogMessage WarhammerDodge /* NeedsAlign */,
    GameLogMessage WarhammerParry /* NeedsAlign */,
    GameLogMessage WarhammerDodgeAndParry /* NeedsAlign */,
    GameLogMessage WarhammerDamageNegated /* NeedsAlign */,
    GameLogMessage WarhammerParrySuperiority /* NeedsAlign */,
    GameLogMessage WarhammerScatterHitFull /* NeedsAlign */,
    GameLogMessage WarhammerStarshipMiss /* NeedsAlign */,
    GameLogMessage WarhammerStarshipTargetDisruptionMiss /* NeedsAlign */,
    GameLogMessage WarhammerStarshipMissProximityMayFollow /* NeedsAlign */,
    GameLogMessage WarhammerStarshipHit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipShieldHit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipShieldHullHit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipCriticalHit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipCriticalShieldHullHit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipLanceMiss /* NeedsAlign */,
    GameLogMessage WarhammerStarshipLanceHit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipLanceCrit /* NeedsAlign */,
    GameLogMessage WarhammerStarshipSteadyHandActivation /* NeedsAlign */,
    GameLogMessage WarhammerStarshipAttackGroup /* NeedsAlign */,
    TooltipBrickAttackResultStrings AttackResultStrings /* NeedsAlign */,
    TooltipBrickStrings TooltipBrickStrings /* NeedsAlign */,
    GameLogMessage ItemGained /* NeedsAlign */,
    GameLogMessage ItemsGained /* NeedsAlign */,
    GameLogMessage ItemLost /* NeedsAlign */,
    GameLogMessage ItemsLost /* NeedsAlign */,
    GameLogMessage ItemEquipped /* NeedsAlign */,
    GameLogMessage ItemUnequipped /* NeedsAlign */,
    GameLogMessage ItemIdentified /* NeedsAlign */,
    GameLogMessage ItemUnidentified /* NeedsAlign */,
    GameLogMessage FactionReputationGained /* NeedsAlign */,
    GameLogMessage FactionReputationLost /* NeedsAlign */,
    GameLogMessage ItemGroup /* NeedsAlign */,
    GameLogMessage CargoCreated /* NeedsAlign */,
    GameLogMessage CargoCreatedWithCapacity /* NeedsAlign */,
    GameLogMessage CargoReplenished /* NeedsAlign */,
    GameLogMessage CargoFormed /* NeedsAlign */,
    GameLogMessage CargoRemoved /* NeedsAlign */,
    GameLogMessage ItemSendToCargo /* NeedsAlign */,
    GameLogMessage ItemSendToCargoAndCargoFormed /* NeedsAlign */,
    GameLogMessage CargoGroup /* NeedsAlign */,
    GameLogMessage ScrapGained /* NeedsAlign */,
    GameLogMessage ScrapSpend /* NeedsAlign */,
    SavingThrowMessage SavingThrowSuccess /* NeedsAlign */,
    SavingThrowMessage SavingThrowFail /* NeedsAlign */,
    GameLogMessage SavingThrowGroup /* NeedsAlign */,
    GameLogMessage UnitDeath /* NeedsAlign */,
    GameLogMessage UnitFallsUnconscious /* NeedsAlign */,
    DamageLogMessage Damage /* NeedsAlign */,
    StatDamageLogMessage StatDamage /* NeedsAlign */,
    StatDamageLogMessage StatDrain /* NeedsAlign */,
    GameLogMessage UnitMissedTurn /* NeedsAlign */,
    GameLogMessage InterruptTurn /* NeedsAlign */,
    HealLogMessage HealDamage /* NeedsAlign */,
    StatDamageLogMessage HealStatDamage /* NeedsAlign */,
    StatDamageLogMessage HealStatDrain /* NeedsAlign */,
    GameLogMessage UseAbility /* NeedsAlign */,
    GameLogMessage UseAbilityOnTarget /* NeedsAlign */,
    GameLogMessage UseItem /* NeedsAlign */,
    GameLogMessage SpellImmunity /* NeedsAlign */,
    GameLogMessage StatusEffect /* NeedsAlign */,
    GameLogMessage BuffWound /* NeedsAlign */,
    GameLogMessage BuffTrauma /* NeedsAlign */,
    GameLogMessage HealsWound /* NeedsAlign */,
    GameLogMessage HealsTrauma /* NeedsAlign */,
    GameLogMessage GroupStatusEffect /* NeedsAlign */,
    GameLogMessage PerilsOfTheWarp /* NeedsAlign */,
    GameLogMessage SkillCheckSuccess /* NeedsAlign */,
    GameLogMessage SkillCheckFail /* NeedsAlign */,
    GameLogMessage PartySkillCheckSuccess /* NeedsAlign */,
    GameLogMessage PartySkillCheckFail /* NeedsAlign */,
    GameLogMessage ThieveryMissing /* NeedsAlign */,
    GameLogMessage LockIsJammed /* NeedsAlign */,
    GameLogMessage CantDisarmTrap /* NeedsAlign */,
    GameLogMessage PickLockSuccess /* NeedsAlign */,
    GameLogMessage PickLockFail /* NeedsAlign */,
    GameLogMessage PickLockCriticalFail /* NeedsAlign */,
    GameLogMessage DisarmTrapSuccess /* NeedsAlign */,
    GameLogMessage DisarmTrapFail /* NeedsAlign */,
    GameLogMessage DisarmTrapCriticalFail /* NeedsAlign */,
    GameLogMessage TrapSpotted /* NeedsAlign */,
    GameLogMessage DoorSpotted /* NeedsAlign */,
    GameLogMessage UnitBark /* NeedsAlign */,
    GameLogMessage ObjectBark /* NeedsAlign */,
    GameLogMessage DialogStarted /* NeedsAlign */,
    GameLogMessage DialogEnded /* NeedsAlign */,
    GameLogMessage BookStarted /* NeedsAlign */,
    GameLogMessage BookEnded /* NeedsAlign */,
    GameLogMessage CombatStarted /* NeedsAlign */,
    GameLogMessage CombatEnded /* NeedsAlign */,
    GameLogMessage XpGain /* NeedsAlign */,
    GameLogMessage TimePassed /* NeedsAlign */,
    GameLogMessage UnitEncumbranceLight /* NeedsAlign */,
    GameLogMessage UnitEncumbranceMedium /* NeedsAlign */,
    GameLogMessage UnitEncumbranceHeavy /* NeedsAlign */,
    GameLogMessage UnitEncumbranceOverload /* NeedsAlign */,
    GameLogMessage PartyEncumbranceLight /* NeedsAlign */,
    GameLogMessage PartyEncumbranceMedium /* NeedsAlign */,
    GameLogMessage PartyEncumbranceHeavy /* NeedsAlign */,
    GameLogMessage PartyEncumbranceOverload /* NeedsAlign */,
    GameLogMessage AnomalyCheckSuccess /* NeedsAlign */,
    GameLogMessage AnomalyCheckFail /* NeedsAlign */,
    GameLogMessage AnomalyInteractionSuccess /* NeedsAlign */,
    GameLogMessage AnomalyInteractionFail /* NeedsAlign */,
    GameLogMessage CreateColony /* NeedsAlign */,
    GameLogMessage ProjectStarted /* NeedsAlign */,
    GameLogMessage ProjectFinished /* NeedsAlign */,
    GameLogMessage ContentmentChangedInColony /* NeedsAlign */,
    GameLogMessage ContentmentChangedInAllColonies /* NeedsAlign */,
    GameLogMessage EfficiencyChangedInColony /* NeedsAlign */,
    GameLogMessage EfficiencyChangedInAllColonies /* NeedsAlign */,
    GameLogMessage SecurityChangedInColony /* NeedsAlign */,
    GameLogMessage SecurityChangedInAllColonies /* NeedsAlign */,
    GameLogMessage ResourceGained /* NeedsAlign */,
    GameLogMessage ResourceLost /* NeedsAlign */,
    GameLogMessage ProfitFactorGained /* NeedsAlign */,
    GameLogMessage ProfitFactorLost /* NeedsAlign */,
    GameLogMessage NavigatorResourceGained /* NeedsAlign */,
    GameLogMessage NavigatorResourceLost /* NeedsAlign */,
    GameLogMessage ChronicleFinished /* NeedsAlign */,
    GameLogMessage StarshipLevelUp /* NeedsAlign */,
    GameLogMessage StarshipExpToNextLevel /* NeedsAlign */,
    GameLogMessage StarshipExperiencePerArea /* NeedsAlign */,
    GameLogMessage VeilThicknessValueChanged /* NeedsAlign */,
    GameLogMessage VeilThicknessStateChanged /* NeedsAlign */,
    GameLogMessage MomentumValueChanged /* NeedsAlign */,
    GameLogMessage SeparatorStart /* NeedsAlign */,
    GameLogMessage SeparatorFinish /* NeedsAlign */)
{
    public static GameLogStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DefaultColor */
        ColorRGBA _DefaultColor = ColorRGBA.Read(reader);
        ColorRGBA _ColorMultiplier = ColorRGBA.Read(reader);
        PPtr<Sprite> _LeftArrowSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _RightArrowSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _DiesSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _MomentumSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _VeilThicknessSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _BuffSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _TraumaSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _FolderSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite>[] _NumberShots = BuiltInArray<PPtr<Sprite>>.Read(reader);
        ColorTextString _MomentumColorText = ColorTextString.Read(reader);
        reader.AlignTo(4); /* VeilThicknessColorText */
        ColorTextString _VeilThicknessColorText = ColorTextString.Read(reader);
        reader.AlignTo(4); /* PushColorText */
        ColorTextString _PushColorText = ColorTextString.Read(reader);
        reader.AlignTo(4); /* OverpenetrationColorText */
        ColorTextString _OverpenetrationColorText = ColorTextString.Read(reader);
        reader.AlignTo(4); /* CriticalHitColorText */
        ColorTextString _CriticalHitColorText = ColorTextString.Read(reader);
        reader.AlignTo(4); /* WarhammerDealDamage */
        GameLogMessage _WarhammerDealDamage = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerHitNoDamage */
        GameLogMessage _WarhammerHitNoDamage = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerRFHit */
        GameLogMessage _WarhammerRFHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerMeleeHitSuperiority */
        GameLogMessage _WarhammerMeleeHitSuperiority = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerMeleeRFHitSuperiority */
        GameLogMessage _WarhammerMeleeRFHitSuperiority = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerCoverHit */
        GameLogMessage _WarhammerCoverHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerMiss */
        GameLogMessage _WarhammerMiss = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerDodge */
        GameLogMessage _WarhammerDodge = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerParry */
        GameLogMessage _WarhammerParry = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerDodgeAndParry */
        GameLogMessage _WarhammerDodgeAndParry = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerDamageNegated */
        GameLogMessage _WarhammerDamageNegated = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerParrySuperiority */
        GameLogMessage _WarhammerParrySuperiority = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerScatterHitFull */
        GameLogMessage _WarhammerScatterHitFull = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipMiss */
        GameLogMessage _WarhammerStarshipMiss = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipTargetDisruptionMiss */
        GameLogMessage _WarhammerStarshipTargetDisruptionMiss = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipMissProximityMayFollow */
        GameLogMessage _WarhammerStarshipMissProximityMayFollow = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipHit */
        GameLogMessage _WarhammerStarshipHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipShieldHit */
        GameLogMessage _WarhammerStarshipShieldHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipShieldHullHit */
        GameLogMessage _WarhammerStarshipShieldHullHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipCriticalHit */
        GameLogMessage _WarhammerStarshipCriticalHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipCriticalShieldHullHit */
        GameLogMessage _WarhammerStarshipCriticalShieldHullHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipLanceMiss */
        GameLogMessage _WarhammerStarshipLanceMiss = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipLanceHit */
        GameLogMessage _WarhammerStarshipLanceHit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipLanceCrit */
        GameLogMessage _WarhammerStarshipLanceCrit = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipSteadyHandActivation */
        GameLogMessage _WarhammerStarshipSteadyHandActivation = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* WarhammerStarshipAttackGroup */
        GameLogMessage _WarhammerStarshipAttackGroup = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* AttackResultStrings */
        TooltipBrickAttackResultStrings _AttackResultStrings = TooltipBrickAttackResultStrings.Read(reader);
        reader.AlignTo(4); /* TooltipBrickStrings */
        TooltipBrickStrings _TooltipBrickStrings = TooltipBrickStrings.Read(reader);
        reader.AlignTo(4); /* ItemGained */
        GameLogMessage _ItemGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemsGained */
        GameLogMessage _ItemsGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemLost */
        GameLogMessage _ItemLost = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemsLost */
        GameLogMessage _ItemsLost = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemEquipped */
        GameLogMessage _ItemEquipped = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemUnequipped */
        GameLogMessage _ItemUnequipped = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemIdentified */
        GameLogMessage _ItemIdentified = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemUnidentified */
        GameLogMessage _ItemUnidentified = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* FactionReputationGained */
        GameLogMessage _FactionReputationGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* FactionReputationLost */
        GameLogMessage _FactionReputationLost = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemGroup */
        GameLogMessage _ItemGroup = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CargoCreated */
        GameLogMessage _CargoCreated = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CargoCreatedWithCapacity */
        GameLogMessage _CargoCreatedWithCapacity = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CargoReplenished */
        GameLogMessage _CargoReplenished = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CargoFormed */
        GameLogMessage _CargoFormed = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CargoRemoved */
        GameLogMessage _CargoRemoved = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemSendToCargo */
        GameLogMessage _ItemSendToCargo = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ItemSendToCargoAndCargoFormed */
        GameLogMessage _ItemSendToCargoAndCargoFormed = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CargoGroup */
        GameLogMessage _CargoGroup = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ScrapGained */
        GameLogMessage _ScrapGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ScrapSpend */
        GameLogMessage _ScrapSpend = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SavingThrowSuccess */
        SavingThrowMessage _SavingThrowSuccess = SavingThrowMessage.Read(reader);
        reader.AlignTo(4); /* SavingThrowFail */
        SavingThrowMessage _SavingThrowFail = SavingThrowMessage.Read(reader);
        reader.AlignTo(4); /* SavingThrowGroup */
        GameLogMessage _SavingThrowGroup = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitDeath */
        GameLogMessage _UnitDeath = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitFallsUnconscious */
        GameLogMessage _UnitFallsUnconscious = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* Damage */
        DamageLogMessage _Damage = DamageLogMessage.Read(reader);
        reader.AlignTo(4); /* StatDamage */
        StatDamageLogMessage _StatDamage = StatDamageLogMessage.Read(reader);
        reader.AlignTo(4); /* StatDrain */
        StatDamageLogMessage _StatDrain = StatDamageLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitMissedTurn */
        GameLogMessage _UnitMissedTurn = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* InterruptTurn */
        GameLogMessage _InterruptTurn = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* HealDamage */
        HealLogMessage _HealDamage = HealLogMessage.Read(reader);
        reader.AlignTo(4); /* HealStatDamage */
        StatDamageLogMessage _HealStatDamage = StatDamageLogMessage.Read(reader);
        reader.AlignTo(4); /* HealStatDrain */
        StatDamageLogMessage _HealStatDrain = StatDamageLogMessage.Read(reader);
        reader.AlignTo(4); /* UseAbility */
        GameLogMessage _UseAbility = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UseAbilityOnTarget */
        GameLogMessage _UseAbilityOnTarget = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UseItem */
        GameLogMessage _UseItem = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SpellImmunity */
        GameLogMessage _SpellImmunity = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* StatusEffect */
        GameLogMessage _StatusEffect = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* BuffWound */
        GameLogMessage _BuffWound = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* BuffTrauma */
        GameLogMessage _BuffTrauma = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* HealsWound */
        GameLogMessage _HealsWound = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* HealsTrauma */
        GameLogMessage _HealsTrauma = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* GroupStatusEffect */
        GameLogMessage _GroupStatusEffect = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PerilsOfTheWarp */
        GameLogMessage _PerilsOfTheWarp = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SkillCheckSuccess */
        GameLogMessage _SkillCheckSuccess = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SkillCheckFail */
        GameLogMessage _SkillCheckFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PartySkillCheckSuccess */
        GameLogMessage _PartySkillCheckSuccess = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PartySkillCheckFail */
        GameLogMessage _PartySkillCheckFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ThieveryMissing */
        GameLogMessage _ThieveryMissing = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* LockIsJammed */
        GameLogMessage _LockIsJammed = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CantDisarmTrap */
        GameLogMessage _CantDisarmTrap = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PickLockSuccess */
        GameLogMessage _PickLockSuccess = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PickLockFail */
        GameLogMessage _PickLockFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PickLockCriticalFail */
        GameLogMessage _PickLockCriticalFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* DisarmTrapSuccess */
        GameLogMessage _DisarmTrapSuccess = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* DisarmTrapFail */
        GameLogMessage _DisarmTrapFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* DisarmTrapCriticalFail */
        GameLogMessage _DisarmTrapCriticalFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* TrapSpotted */
        GameLogMessage _TrapSpotted = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* DoorSpotted */
        GameLogMessage _DoorSpotted = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitBark */
        GameLogMessage _UnitBark = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ObjectBark */
        GameLogMessage _ObjectBark = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* DialogStarted */
        GameLogMessage _DialogStarted = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* DialogEnded */
        GameLogMessage _DialogEnded = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* BookStarted */
        GameLogMessage _BookStarted = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* BookEnded */
        GameLogMessage _BookEnded = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CombatStarted */
        GameLogMessage _CombatStarted = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CombatEnded */
        GameLogMessage _CombatEnded = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* XpGain */
        GameLogMessage _XpGain = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* TimePassed */
        GameLogMessage _TimePassed = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitEncumbranceLight */
        GameLogMessage _UnitEncumbranceLight = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitEncumbranceMedium */
        GameLogMessage _UnitEncumbranceMedium = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitEncumbranceHeavy */
        GameLogMessage _UnitEncumbranceHeavy = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* UnitEncumbranceOverload */
        GameLogMessage _UnitEncumbranceOverload = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PartyEncumbranceLight */
        GameLogMessage _PartyEncumbranceLight = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PartyEncumbranceMedium */
        GameLogMessage _PartyEncumbranceMedium = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PartyEncumbranceHeavy */
        GameLogMessage _PartyEncumbranceHeavy = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* PartyEncumbranceOverload */
        GameLogMessage _PartyEncumbranceOverload = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* AnomalyCheckSuccess */
        GameLogMessage _AnomalyCheckSuccess = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* AnomalyCheckFail */
        GameLogMessage _AnomalyCheckFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* AnomalyInteractionSuccess */
        GameLogMessage _AnomalyInteractionSuccess = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* AnomalyInteractionFail */
        GameLogMessage _AnomalyInteractionFail = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* CreateColony */
        GameLogMessage _CreateColony = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ProjectStarted */
        GameLogMessage _ProjectStarted = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ProjectFinished */
        GameLogMessage _ProjectFinished = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ContentmentChangedInColony */
        GameLogMessage _ContentmentChangedInColony = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ContentmentChangedInAllColonies */
        GameLogMessage _ContentmentChangedInAllColonies = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* EfficiencyChangedInColony */
        GameLogMessage _EfficiencyChangedInColony = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* EfficiencyChangedInAllColonies */
        GameLogMessage _EfficiencyChangedInAllColonies = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SecurityChangedInColony */
        GameLogMessage _SecurityChangedInColony = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SecurityChangedInAllColonies */
        GameLogMessage _SecurityChangedInAllColonies = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ResourceGained */
        GameLogMessage _ResourceGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ResourceLost */
        GameLogMessage _ResourceLost = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ProfitFactorGained */
        GameLogMessage _ProfitFactorGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ProfitFactorLost */
        GameLogMessage _ProfitFactorLost = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* NavigatorResourceGained */
        GameLogMessage _NavigatorResourceGained = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* NavigatorResourceLost */
        GameLogMessage _NavigatorResourceLost = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* ChronicleFinished */
        GameLogMessage _ChronicleFinished = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* StarshipLevelUp */
        GameLogMessage _StarshipLevelUp = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* StarshipExpToNextLevel */
        GameLogMessage _StarshipExpToNextLevel = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* StarshipExperiencePerArea */
        GameLogMessage _StarshipExperiencePerArea = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* VeilThicknessValueChanged */
        GameLogMessage _VeilThicknessValueChanged = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* VeilThicknessStateChanged */
        GameLogMessage _VeilThicknessStateChanged = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* MomentumValueChanged */
        GameLogMessage _MomentumValueChanged = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SeparatorStart */
        GameLogMessage _SeparatorStart = GameLogMessage.Read(reader);
        reader.AlignTo(4); /* SeparatorFinish */
        GameLogMessage _SeparatorFinish = GameLogMessage.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DefaultColor,
            _ColorMultiplier,
            _LeftArrowSprite,
            _RightArrowSprite,
            _DiesSprite,
            _MomentumSprite,
            _VeilThicknessSprite,
            _BuffSprite,
            _TraumaSprite,
            _FolderSprite,
            _NumberShots,
            _MomentumColorText,
            _VeilThicknessColorText,
            _PushColorText,
            _OverpenetrationColorText,
            _CriticalHitColorText,
            _WarhammerDealDamage,
            _WarhammerHitNoDamage,
            _WarhammerRFHit,
            _WarhammerMeleeHitSuperiority,
            _WarhammerMeleeRFHitSuperiority,
            _WarhammerCoverHit,
            _WarhammerMiss,
            _WarhammerDodge,
            _WarhammerParry,
            _WarhammerDodgeAndParry,
            _WarhammerDamageNegated,
            _WarhammerParrySuperiority,
            _WarhammerScatterHitFull,
            _WarhammerStarshipMiss,
            _WarhammerStarshipTargetDisruptionMiss,
            _WarhammerStarshipMissProximityMayFollow,
            _WarhammerStarshipHit,
            _WarhammerStarshipShieldHit,
            _WarhammerStarshipShieldHullHit,
            _WarhammerStarshipCriticalHit,
            _WarhammerStarshipCriticalShieldHullHit,
            _WarhammerStarshipLanceMiss,
            _WarhammerStarshipLanceHit,
            _WarhammerStarshipLanceCrit,
            _WarhammerStarshipSteadyHandActivation,
            _WarhammerStarshipAttackGroup,
            _AttackResultStrings,
            _TooltipBrickStrings,
            _ItemGained,
            _ItemsGained,
            _ItemLost,
            _ItemsLost,
            _ItemEquipped,
            _ItemUnequipped,
            _ItemIdentified,
            _ItemUnidentified,
            _FactionReputationGained,
            _FactionReputationLost,
            _ItemGroup,
            _CargoCreated,
            _CargoCreatedWithCapacity,
            _CargoReplenished,
            _CargoFormed,
            _CargoRemoved,
            _ItemSendToCargo,
            _ItemSendToCargoAndCargoFormed,
            _CargoGroup,
            _ScrapGained,
            _ScrapSpend,
            _SavingThrowSuccess,
            _SavingThrowFail,
            _SavingThrowGroup,
            _UnitDeath,
            _UnitFallsUnconscious,
            _Damage,
            _StatDamage,
            _StatDrain,
            _UnitMissedTurn,
            _InterruptTurn,
            _HealDamage,
            _HealStatDamage,
            _HealStatDrain,
            _UseAbility,
            _UseAbilityOnTarget,
            _UseItem,
            _SpellImmunity,
            _StatusEffect,
            _BuffWound,
            _BuffTrauma,
            _HealsWound,
            _HealsTrauma,
            _GroupStatusEffect,
            _PerilsOfTheWarp,
            _SkillCheckSuccess,
            _SkillCheckFail,
            _PartySkillCheckSuccess,
            _PartySkillCheckFail,
            _ThieveryMissing,
            _LockIsJammed,
            _CantDisarmTrap,
            _PickLockSuccess,
            _PickLockFail,
            _PickLockCriticalFail,
            _DisarmTrapSuccess,
            _DisarmTrapFail,
            _DisarmTrapCriticalFail,
            _TrapSpotted,
            _DoorSpotted,
            _UnitBark,
            _ObjectBark,
            _DialogStarted,
            _DialogEnded,
            _BookStarted,
            _BookEnded,
            _CombatStarted,
            _CombatEnded,
            _XpGain,
            _TimePassed,
            _UnitEncumbranceLight,
            _UnitEncumbranceMedium,
            _UnitEncumbranceHeavy,
            _UnitEncumbranceOverload,
            _PartyEncumbranceLight,
            _PartyEncumbranceMedium,
            _PartyEncumbranceHeavy,
            _PartyEncumbranceOverload,
            _AnomalyCheckSuccess,
            _AnomalyCheckFail,
            _AnomalyInteractionSuccess,
            _AnomalyInteractionFail,
            _CreateColony,
            _ProjectStarted,
            _ProjectFinished,
            _ContentmentChangedInColony,
            _ContentmentChangedInAllColonies,
            _EfficiencyChangedInColony,
            _EfficiencyChangedInAllColonies,
            _SecurityChangedInColony,
            _SecurityChangedInAllColonies,
            _ResourceGained,
            _ResourceLost,
            _ProfitFactorGained,
            _ProfitFactorLost,
            _NavigatorResourceGained,
            _NavigatorResourceLost,
            _ChronicleFinished,
            _StarshipLevelUp,
            _StarshipExpToNextLevel,
            _StarshipExperiencePerArea,
            _VeilThicknessValueChanged,
            _VeilThicknessStateChanged,
            _MomentumValueChanged,
            _SeparatorStart,
            _SeparatorFinish);
    }
}

