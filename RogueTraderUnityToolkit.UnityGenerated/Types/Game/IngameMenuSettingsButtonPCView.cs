namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $IngameMenuSettingsButtonPCView (8 fields) 422F3FD4C0C4DC9C1A2633A088392151/911B74CE714D1BA9D0E235CE0168F389 */
public record class IngameMenuSettingsButtonPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_Settings /* None */,
    PPtr<OwlcatMultiButton> m_NetRoles /* None */,
    PPtr<Image> m_NetRolesAttentionMark /* None */)
{
    public static IngameMenuSettingsButtonPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Settings = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_NetRoles = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_NetRolesAttentionMark = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_Settings,
            _m_NetRoles,
            _m_NetRolesAttentionMark);
    }
}

