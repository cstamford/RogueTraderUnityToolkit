namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapUnitMarkerPCView (9 fields) 26A14E5F1DAE4B73E700047466AB9858/1FB39B08E911D0CD042BD891E1CF88FE */
public record class LocalMapUnitMarkerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Arrow /* NeedsAlign */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */,
    PPtr<Image> m_Mark /* None */,
    PPtr<Sprite> m_EnemySprite /* None */,
    PPtr<Sprite> m_NpcSprite /* None */)
{
    public static LocalMapUnitMarkerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Arrow */
        PPtr<CanvasGroup> _m_Arrow = PPtr<CanvasGroup>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        PPtr<Image> _m_Mark = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_EnemySprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NpcSprite = PPtr<Sprite>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Arrow,
            _m_TargetPingEntity,
            _m_Mark,
            _m_EnemySprite,
            _m_NpcSprite);
    }
}

