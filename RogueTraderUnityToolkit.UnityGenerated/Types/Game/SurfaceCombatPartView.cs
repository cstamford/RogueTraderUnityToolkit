namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceCombatPartView (6 fields) 3E32C595BB2107FABE50955F00F996F1/E76AE5BCACEED16FEF0B8C6629D03288 */
public record class SurfaceCombatPartView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityView /* NeedsAlign */,
    PPtr<LineOfSightControllerView> m_SightControllerPCView /* None */)
{
    public static SurfaceCombatPartView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityView */
        PPtr<UIVisibilityView> _m_UIVisibilityView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<LineOfSightControllerView> _m_SightControllerPCView = PPtr<LineOfSightControllerView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityView,
            _m_SightControllerPCView);
    }
}

