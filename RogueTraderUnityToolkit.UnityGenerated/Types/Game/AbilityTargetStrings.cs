namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AbilityTargetStrings (25 fields) B47FF2E07007C7F7C9C6C5EAF678F345/57314D1A2FC0021E39CA044C239343D8 */
public record class AbilityTargetStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString Personal /* NeedsAlign */,
    LocalizedString TargetPoint /* NeedsAlign */,
    LocalizedString OneCreature /* NeedsAlign */,
    LocalizedString OneEnemyCreature /* NeedsAlign */,
    LocalizedString OneFriendlyCreature /* NeedsAlign */,
    LocalizedString AllCreatures /* NeedsAlign */,
    LocalizedString AllEnemies /* NeedsAlign */,
    LocalizedString AllAllies /* NeedsAlign */,
    LocalizedString FirstCreature /* NeedsAlign */,
    LocalizedString FirstEnemyCreature /* NeedsAlign */,
    LocalizedString FirstFriendlyCreature /* NeedsAlign */,
    LocalizedString WithinCone /* NeedsAlign */,
    LocalizedString WithinLine /* NeedsAlign */,
    LocalizedString WithinBurstCenteredOn /* NeedsAlign */,
    LocalizedString InsideAreaOfEffect /* NeedsAlign */,
    LocalizedString Movement /* NeedsAlign */,
    LocalizedString InsideSelectedCombatArea /* NeedsAlign */,
    LocalizedString CenteredOnCaster /* NeedsAlign */,
    LocalizedString CenteredOnTargetPoint /* NeedsAlign */,
    LocalizedString CenteredOnTargetCreature /* NeedsAlign */,
    LocalizedString EveryShot /* NeedsAlign */)
{
    public static AbilityTargetStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Personal */
        LocalizedString _Personal = LocalizedString.Read(reader);
        reader.AlignTo(4); /* TargetPoint */
        LocalizedString _TargetPoint = LocalizedString.Read(reader);
        reader.AlignTo(4); /* OneCreature */
        LocalizedString _OneCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* OneEnemyCreature */
        LocalizedString _OneEnemyCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* OneFriendlyCreature */
        LocalizedString _OneFriendlyCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AllCreatures */
        LocalizedString _AllCreatures = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AllEnemies */
        LocalizedString _AllEnemies = LocalizedString.Read(reader);
        reader.AlignTo(4); /* AllAllies */
        LocalizedString _AllAllies = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FirstCreature */
        LocalizedString _FirstCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FirstEnemyCreature */
        LocalizedString _FirstEnemyCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FirstFriendlyCreature */
        LocalizedString _FirstFriendlyCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* WithinCone */
        LocalizedString _WithinCone = LocalizedString.Read(reader);
        reader.AlignTo(4); /* WithinLine */
        LocalizedString _WithinLine = LocalizedString.Read(reader);
        reader.AlignTo(4); /* WithinBurstCenteredOn */
        LocalizedString _WithinBurstCenteredOn = LocalizedString.Read(reader);
        reader.AlignTo(4); /* InsideAreaOfEffect */
        LocalizedString _InsideAreaOfEffect = LocalizedString.Read(reader);
        reader.AlignTo(4); /* Movement */
        LocalizedString _Movement = LocalizedString.Read(reader);
        reader.AlignTo(4); /* InsideSelectedCombatArea */
        LocalizedString _InsideSelectedCombatArea = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CenteredOnCaster */
        LocalizedString _CenteredOnCaster = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CenteredOnTargetPoint */
        LocalizedString _CenteredOnTargetPoint = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CenteredOnTargetCreature */
        LocalizedString _CenteredOnTargetCreature = LocalizedString.Read(reader);
        reader.AlignTo(4); /* EveryShot */
        LocalizedString _EveryShot = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Personal,
            _TargetPoint,
            _OneCreature,
            _OneEnemyCreature,
            _OneFriendlyCreature,
            _AllCreatures,
            _AllEnemies,
            _AllAllies,
            _FirstCreature,
            _FirstEnemyCreature,
            _FirstFriendlyCreature,
            _WithinCone,
            _WithinLine,
            _WithinBurstCenteredOn,
            _InsideAreaOfEffect,
            _Movement,
            _InsideSelectedCombatArea,
            _CenteredOnCaster,
            _CenteredOnTargetPoint,
            _CenteredOnTargetCreature,
            _EveryShot);
    }
}

