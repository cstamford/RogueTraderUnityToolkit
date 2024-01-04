namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $XZGrid (8 fields) ACB3A8BF4B3C3253634148A665EA2B9A/2186EA9BB92F1D02E54CB99FE8A7E3EF */
public record class XZGrid(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<XZGridRenderSettings> _renderSettings /* NeedsAlign */,
    PPtr<XZGridCellSizeSettings> _cellSizeSettings /* None */,
    XZGridDimensionSettings _dimensionSettings /* None */,
    RenderableCoordinateSystem _renderableCoordinateSystem /* None */)
{
    public static XZGrid Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _renderSettings */
        PPtr<XZGridRenderSettings> __renderSettings = PPtr<XZGridRenderSettings>.Read(reader);
        PPtr<XZGridCellSizeSettings> __cellSizeSettings = PPtr<XZGridCellSizeSettings>.Read(reader);
        XZGridDimensionSettings __dimensionSettings = XZGridDimensionSettings.Read(reader);
        RenderableCoordinateSystem __renderableCoordinateSystem = RenderableCoordinateSystem.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __renderSettings,
            __cellSizeSettings,
            __dimensionSettings,
            __renderableCoordinateSystem);
    }
}

