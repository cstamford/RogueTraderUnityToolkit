namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceCombatUnitPortraitZone (6 fields) C4F08E99EF672EA978401F70CB91D7E3/BCE3E8CC7F125860B40F0FDC1EB68C59 */
public record class SurfaceCombatUnitPortraitZone(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Picture /* NeedsAlign */,
    int m_Size /* None */)
{
    public static SurfaceCombatUnitPortraitZone Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Picture */
        PPtr<Image> _m_Picture = PPtr<Image>.Read(reader);
        int _m_Size = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Picture,
            _m_Size);
    }
}

