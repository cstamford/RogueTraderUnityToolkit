namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ContentSizeFitter (6 fields) 3F93490270C9DC35E0AA1EB3F9EB9A15/3FD174B4077A5951ADD61B25569F2F52 */
public record class ContentSizeFitter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_HorizontalFit /* NeedsAlign */,
    int m_VerticalFit /* None */)
{
    public static ContentSizeFitter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HorizontalFit */
        int _m_HorizontalFit = reader.ReadS32();
        int _m_VerticalFit = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HorizontalFit,
            _m_VerticalFit);
    }
}

