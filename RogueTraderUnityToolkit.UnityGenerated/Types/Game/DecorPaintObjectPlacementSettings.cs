namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DecorPaintObjectPlacementSettings (10 fields) 24ABFE036E3ABD23AB938C83E55EAC9C/8A292E63B709CAE3721A62CEAC2F8990 */
public record class DecorPaintObjectPlacementSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _decorPaintMode /* NeedsAlign */,
    byte _ignoreGrid /* None */,
    float _strokeDistance /* NeedsAlign */,
    PPtr<SingleDecorPaintModeObjectPlacementSettings> _singleDecorPaintModeSettings /* None */,
    PPtr<BrushDecorPaintModeObjectPlacementSettings> _brushDecorPaintModeSettings /* None */,
    DecorPaintObjectPlacementSettingsView _view /* None */)
{
    public static DecorPaintObjectPlacementSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _decorPaintMode */
        int __decorPaintMode = reader.ReadS32();
        byte __ignoreGrid = reader.ReadU8();
        reader.AlignTo(4); /* _strokeDistance */
        float __strokeDistance = reader.ReadF32();
        PPtr<SingleDecorPaintModeObjectPlacementSettings> __singleDecorPaintModeSettings = PPtr<SingleDecorPaintModeObjectPlacementSettings>.Read(reader);
        PPtr<BrushDecorPaintModeObjectPlacementSettings> __brushDecorPaintModeSettings = PPtr<BrushDecorPaintModeObjectPlacementSettings>.Read(reader);
        DecorPaintObjectPlacementSettingsView __view = DecorPaintObjectPlacementSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __decorPaintMode,
            __ignoreGrid,
            __strokeDistance,
            __singleDecorPaintModeSettings,
            __brushDecorPaintModeSettings,
            __view);
    }
}

