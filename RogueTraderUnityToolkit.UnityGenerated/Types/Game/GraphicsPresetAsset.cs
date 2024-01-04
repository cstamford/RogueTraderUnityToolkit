namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GraphicsPresetAsset (6 fields) D5A611A76943C261DAF1F58D992D012D/E5634D50EA600C36EEFD9B5A76F71CFA */
public record class GraphicsPresetAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte IsCustomMode /* NeedsAlign */,
    GraphicsPreset Preset /* NeedsAlign */)
{
    public static GraphicsPresetAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* IsCustomMode */
        byte _IsCustomMode = reader.ReadU8();
        reader.AlignTo(4); /* Preset */
        GraphicsPreset _Preset = GraphicsPreset.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _IsCustomMode,
            _Preset);
    }
}

