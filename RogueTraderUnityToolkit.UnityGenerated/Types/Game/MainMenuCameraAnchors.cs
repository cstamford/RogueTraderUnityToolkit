namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuCameraAnchors (6 fields) E42E958FC92252A9AA39820083802174/29071B08588003CE5754DF20DD49423A */
public record class MainMenuCameraAnchors(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> MainPosition /* NeedsAlign */,
    AspectRatioPreset[] AspectRatioPresets /* None */)
{
    public static MainMenuCameraAnchors Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MainPosition */
        PPtr<Transform> _MainPosition = PPtr<Transform>.Read(reader);
        AspectRatioPreset[] _AspectRatioPresets = BuiltInArray<AspectRatioPreset>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MainPosition,
            _AspectRatioPresets);
    }
}

