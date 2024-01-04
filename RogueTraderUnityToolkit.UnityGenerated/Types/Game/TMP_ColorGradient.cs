namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_ColorGradient (9 fields) EB8500F602F021A65445A83E4453E2FA/B3134EE3C1545257C7A564C011BDD117 */
public record class TMP_ColorGradient(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int colorMode /* NeedsAlign */,
    ColorRGBA topLeft /* None */,
    ColorRGBA topRight /* None */,
    ColorRGBA bottomLeft /* None */,
    ColorRGBA bottomRight /* None */)
{
    public static TMP_ColorGradient Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* colorMode */
        int _colorMode = reader.ReadS32();
        ColorRGBA _topLeft = ColorRGBA.Read(reader);
        ColorRGBA _topRight = ColorRGBA.Read(reader);
        ColorRGBA _bottomLeft = ColorRGBA.Read(reader);
        ColorRGBA _bottomRight = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _colorMode,
            _topLeft,
            _topRight,
            _bottomLeft,
            _bottomRight);
    }
}

