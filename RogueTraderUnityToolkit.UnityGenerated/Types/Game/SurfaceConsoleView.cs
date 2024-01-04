namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceConsoleView (7 fields) 3B83945721359894C087FD2C905AB20A/1B16D9E490A75E5E2E8E27F8B4BAF2E0 */
public record class SurfaceConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceStaticPartConsoleView> m_StaticPartConsoleView /* NeedsAlign */,
    PPtr<SurfaceDynamicPartConsoleView> m_DynamicPartConsoleView /* None */,
    PPtr<SurfaceCombatPartView> m_SurfaceCombatPartView /* None */)
{
    public static SurfaceConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StaticPartConsoleView */
        PPtr<SurfaceStaticPartConsoleView> _m_StaticPartConsoleView = PPtr<SurfaceStaticPartConsoleView>.Read(reader);
        PPtr<SurfaceDynamicPartConsoleView> _m_DynamicPartConsoleView = PPtr<SurfaceDynamicPartConsoleView>.Read(reader);
        PPtr<SurfaceCombatPartView> _m_SurfaceCombatPartView = PPtr<SurfaceCombatPartView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StaticPartConsoleView,
            _m_DynamicPartConsoleView,
            _m_SurfaceCombatPartView);
    }
}

