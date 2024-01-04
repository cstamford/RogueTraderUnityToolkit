namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelectionBoxRenderModeSettings (10 fields) 5B37BB9F039A455E95E429688E022C6F/510D7FFDEB86312436DAE3DC8BD65AD2 */
public record class ObjectSelectionBoxRenderModeSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _edgeRenderMode /* NeedsAlign */,
    ObjectSelectionBoxCornerEdgesRenderModeSettings _cornerEdgesRenderModeSettings /* None */,
    ColorRGBA _edgeColor /* NeedsAlign */,
    ColorRGBA _boxColor /* None */,
    float _boxScale /* None */,
    ObjectSelectionBoxRenderModeSettingsView _view /* None */)
{
    public static ObjectSelectionBoxRenderModeSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _edgeRenderMode */
        int __edgeRenderMode = reader.ReadS32();
        ObjectSelectionBoxCornerEdgesRenderModeSettings __cornerEdgesRenderModeSettings = ObjectSelectionBoxCornerEdgesRenderModeSettings.Read(reader);
        reader.AlignTo(4); /* _edgeColor */
        ColorRGBA __edgeColor = ColorRGBA.Read(reader);
        ColorRGBA __boxColor = ColorRGBA.Read(reader);
        float __boxScale = reader.ReadF32();
        ObjectSelectionBoxRenderModeSettingsView __view = ObjectSelectionBoxRenderModeSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __edgeRenderMode,
            __cornerEdgesRenderModeSettings,
            __edgeColor,
            __boxColor,
            __boxScale,
            __view);
    }
}

