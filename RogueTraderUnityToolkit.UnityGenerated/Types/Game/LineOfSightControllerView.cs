namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LineOfSightControllerView (5 fields) 2C8C30B1F57AE0480561D8EADF82FA77/E0D7AF4FE886BFB2D5E2F53C4F591211 */
public record class LineOfSightControllerView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LineOfSightView> m_SightPCView /* NeedsAlign */)
{
    public static LineOfSightControllerView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SightPCView */
        PPtr<LineOfSightView> _m_SightPCView = PPtr<LineOfSightView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SightPCView);
    }
}

