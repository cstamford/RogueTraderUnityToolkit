namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BakedOcclusionGeometry (5 fields) 80A733357BFF1B6872D0D7F19B6202B8/4D3843FFC2EC0F5DA8A4A6858D1C5637 */
public record class BakedOcclusionGeometry(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    OcclusionGeometry m_OcclusionGeometry /* NeedsAlign */)
{
    public static BakedOcclusionGeometry Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OcclusionGeometry */
        OcclusionGeometry _m_OcclusionGeometry = OcclusionGeometry.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_OcclusionGeometry);
    }
}

