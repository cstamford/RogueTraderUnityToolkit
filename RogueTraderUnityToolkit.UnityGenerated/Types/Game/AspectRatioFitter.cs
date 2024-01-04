namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AspectRatioFitter (6 fields) 9CCC89EB1D36C155EA4F2DC023C00C22/4A2CDB90B187043A6E8FEF1E6CC72D29 */
public record class AspectRatioFitter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_AspectMode /* NeedsAlign */,
    float m_AspectRatio /* None */)
{
    public static AspectRatioFitter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AspectMode */
        int _m_AspectMode = reader.ReadS32();
        float _m_AspectRatio = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AspectMode,
            _m_AspectRatio);
    }
}

