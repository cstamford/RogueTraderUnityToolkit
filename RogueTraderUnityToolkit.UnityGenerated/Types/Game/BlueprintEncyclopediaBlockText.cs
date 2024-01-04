namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BlueprintEncyclopediaBlockText (9 fields) 974E572C742B4CB03232387088307FE5/A7411EAE07E9759F8CA95A09101585DF */
public record class BlueprintEncyclopediaBlockText(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString Text /* NeedsAlign */,
    byte HasConsoleText /* NeedsAlign */,
    LocalizedString ConsoleText /* NeedsAlign */,
    int TextAlignment /* NeedsAlign */,
    BlueprintEncyclopediaPageReference m_Resource /* None */)
{
    public static BlueprintEncyclopediaBlockText Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Text */
        LocalizedString _Text = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HasConsoleText */
        byte _HasConsoleText = reader.ReadU8();
        reader.AlignTo(4); /* ConsoleText */
        LocalizedString _ConsoleText = LocalizedString.Read(reader);
        reader.AlignTo(4); /* TextAlignment */
        int _TextAlignment = reader.ReadS32();
        BlueprintEncyclopediaPageReference _m_Resource = BlueprintEncyclopediaPageReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Text,
            _HasConsoleText,
            _ConsoleText,
            _TextAlignment,
            _m_Resource);
    }
}

