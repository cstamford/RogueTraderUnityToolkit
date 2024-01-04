namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatHealthPartProgressPCView (5 fields) 2B2C5D889079DE3C7EEA6355ED71919E/DADC1C36E8B733F67F081E27DEB59058 */
public record class SpaceCombatHealthPartProgressPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DelayedSlider> m_Health /* NeedsAlign */)
{
    public static SpaceCombatHealthPartProgressPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Health */
        PPtr<DelayedSlider> _m_Health = PPtr<DelayedSlider>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Health);
    }
}

