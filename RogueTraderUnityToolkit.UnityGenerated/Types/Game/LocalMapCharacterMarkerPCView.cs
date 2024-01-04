namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapCharacterMarkerPCView (8 fields) 33F10603AAE6163A33924A7911257DB8/8979921081E39DCBC592C110A05E68ED */
public record class LocalMapCharacterMarkerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Arrow /* NeedsAlign */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */,
    PPtr<Image> m_Portrait /* None */,
    PPtr<GameObject> m_SelectedActiveFrame /* None */)
{
    public static LocalMapCharacterMarkerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Arrow */
        PPtr<CanvasGroup> _m_Arrow = PPtr<CanvasGroup>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_SelectedActiveFrame = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Arrow,
            _m_TargetPingEntity,
            _m_Portrait,
            _m_SelectedActiveFrame);
    }
}

