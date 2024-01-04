namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GraphicsPresetsList (6 fields) CFE79BE28DE0ABE114FD6830D7DEEB68/F8A5929546A1591E0D181F56912D8328 */
public record class GraphicsPresetsList(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GraphicsPresetAsset>[] m_GraphicsPresets /* NeedsAlign */,
    PPtr<GraphicsPresetAsset> m_ConsoleGraphicsPreset /* None */)
{
    public static GraphicsPresetsList Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GraphicsPresets */
        PPtr<GraphicsPresetAsset>[] _m_GraphicsPresets = BuiltInArray<PPtr<GraphicsPresetAsset>>.Read(reader);
        PPtr<GraphicsPresetAsset> _m_ConsoleGraphicsPreset = PPtr<GraphicsPresetAsset>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_GraphicsPresets,
            _m_ConsoleGraphicsPreset);
    }
}

