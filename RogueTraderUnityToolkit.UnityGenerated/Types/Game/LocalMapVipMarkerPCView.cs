namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapVipMarkerPCView (9 fields) DEA0FE2820B806F1C47F96379CD31468/385C2831B1C3AC7B9850E0C127123C0D */
public record class LocalMapVipMarkerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Arrow /* NeedsAlign */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */,
    PPtr<Image> m_Mark /* None */,
    PPtr<Sprite> m_MapObjectSprite /* None */,
    PPtr<Sprite> m_NpcSprite /* None */)
{
    public static LocalMapVipMarkerPCView Read(EndianBinaryReader reader)
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
        PPtr<Sprite> _m_MapObjectSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_NpcSprite = PPtr<Sprite>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Arrow,
            _m_TargetPingEntity,
            _m_Mark,
            _m_MapObjectSprite,
            _m_NpcSprite);
    }
}

