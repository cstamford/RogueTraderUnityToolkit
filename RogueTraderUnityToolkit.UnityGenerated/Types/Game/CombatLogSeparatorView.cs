namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatLogSeparatorView (5 fields) 970353149F7CCA3AC94708E5E16BEF01/9ED970FA1B03A8BD3363A11DA5AE6192 */
public record class CombatLogSeparatorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    VirtualListLayoutElementSettings m_LayoutElementSettings /* NeedsAlign */)
{
    public static CombatLogSeparatorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LayoutElementSettings */
        VirtualListLayoutElementSettings _m_LayoutElementSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LayoutElementSettings);
    }
}

