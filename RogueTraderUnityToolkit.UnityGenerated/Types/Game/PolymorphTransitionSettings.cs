namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PolymorphTransitionSettings (6 fields) 36AB5C10EFC9E1211B2F1492349CEE2D/35FB2213E7A68980CE026FF587F4D4C0 */
public record class PolymorphTransitionSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    VisualTransitionSettings EnterTransition /* NeedsAlign */,
    VisualTransitionSettings ExitTransition /* NeedsAlign */)
{
    public static PolymorphTransitionSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* EnterTransition */
        VisualTransitionSettings _EnterTransition = VisualTransitionSettings.Read(reader);
        reader.AlignTo(4); /* ExitTransition */
        VisualTransitionSettings _ExitTransition = VisualTransitionSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _EnterTransition,
            _ExitTransition);
    }
}

