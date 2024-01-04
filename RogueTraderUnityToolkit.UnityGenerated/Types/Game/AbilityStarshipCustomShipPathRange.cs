namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AbilityStarshipCustomShipPathRange (5 fields) BF31AF30672390EC0B03349C220E5791/5E949CE88A2E0C93C84419F73E081952 */
public record class AbilityStarshipCustomShipPathRange(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> DefaultMarker /* NeedsAlign */)
{
    public static AbilityStarshipCustomShipPathRange Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DefaultMarker */
        PPtr<GameObject> _DefaultMarker = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DefaultMarker);
    }
}

