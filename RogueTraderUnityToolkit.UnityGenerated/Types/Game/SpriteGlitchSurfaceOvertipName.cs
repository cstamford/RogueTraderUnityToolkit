namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpriteGlitchSurfaceOvertipName (5 fields) 69D71C3EFFD7ABFCAA684D7824A121D4/423E6DEC8F09B6F7579A06315CFCF303 */
public record class SpriteGlitchSurfaceOvertipName(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image>[] m_ImagesForGlitching /* NeedsAlign */)
{
    public static SpriteGlitchSurfaceOvertipName Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ImagesForGlitching */
        PPtr<Image>[] _m_ImagesForGlitching = BuiltInArray<PPtr<Image>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ImagesForGlitching);
    }
}

