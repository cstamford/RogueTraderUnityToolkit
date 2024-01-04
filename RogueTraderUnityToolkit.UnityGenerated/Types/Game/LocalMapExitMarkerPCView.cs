namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapExitMarkerPCView (6 fields) 807DB683C9D35995CBE31EE5E75B9933/566402312F4169C0DAAA6AD265837444 */
public record class LocalMapExitMarkerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_Arrow /* NeedsAlign */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */)
{
    public static LocalMapExitMarkerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Arrow */
        PPtr<CanvasGroup> _m_Arrow = PPtr<CanvasGroup>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Arrow,
            _m_TargetPingEntity);
    }
}

