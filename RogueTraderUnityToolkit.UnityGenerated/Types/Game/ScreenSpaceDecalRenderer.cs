namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScreenSpaceDecalRenderer (5 fields) E3128B419FA796AF22B5D54C7A53EB6B/6516DE954B0026D54EF96B18126BA69D */
public record class ScreenSpaceDecalRenderer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int NormalsReconstructionMethod /* NeedsAlign */)
{
    public static ScreenSpaceDecalRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* NormalsReconstructionMethod */
        int _NormalsReconstructionMethod = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _NormalsReconstructionMethod);
    }
}

