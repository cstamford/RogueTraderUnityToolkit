namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RenderingManager (8 fields) D385D5073CF50ECFE93936FF94E04C24/04166A26EE4842CDA2E60B83CB3B2329 */
public record class RenderingManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> BackgroundCamera /* NeedsAlign */,
    PPtr<GameObject> Background /* None */,
    RimLightingSettings RimLighting /* None */,
    byte HDR /* None */)
{
    public static RenderingManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BackgroundCamera */
        PPtr<GameObject> _BackgroundCamera = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _Background = PPtr<GameObject>.Read(reader);
        RimLightingSettings _RimLighting = RimLightingSettings.Read(reader);
        byte _HDR = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BackgroundCamera,
            _Background,
            _RimLighting,
            _HDR);
    }
}

