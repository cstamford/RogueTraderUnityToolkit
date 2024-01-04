namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LabelRenderSettings (7 fields) A9D82009C2D0E738E42D74CCBD5EECE3/619EAB6E61881DCA1F31532C7978D4D2 */
public record class LabelRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorRGBA _textColor /* NeedsAlign */,
    byte _bold /* None */,
    int _fontSize /* NeedsAlign */)
{
    public static LabelRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _textColor */
        ColorRGBA __textColor = ColorRGBA.Read(reader);
        byte __bold = reader.ReadU8();
        reader.AlignTo(4); /* _fontSize */
        int __fontSize = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __textColor,
            __bold,
            __fontSize);
    }
}

