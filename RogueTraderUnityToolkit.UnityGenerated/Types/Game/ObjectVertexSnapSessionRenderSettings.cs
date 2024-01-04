namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectVertexSnapSessionRenderSettings (9 fields) 3F04C4EE519E425ACE359459F174EC8F/1BA52D5F9D2C07B0DD61AD30B47868B7 */
public record class ObjectVertexSnapSessionRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _renderSourceVertex /* NeedsAlign */,
    ColorRGBA _sourceVertexFillColor /* NeedsAlign */,
    ColorRGBA _sourceVertexBorderColor /* None */,
    float _sourceVertexRadiusInPixels /* None */,
    ObjectVertexSnapSessionRenderSettingsView _view /* None */)
{
    public static ObjectVertexSnapSessionRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _renderSourceVertex */
        byte __renderSourceVertex = reader.ReadU8();
        reader.AlignTo(4); /* _sourceVertexFillColor */
        ColorRGBA __sourceVertexFillColor = ColorRGBA.Read(reader);
        ColorRGBA __sourceVertexBorderColor = ColorRGBA.Read(reader);
        float __sourceVertexRadiusInPixels = reader.ReadF32();
        ObjectVertexSnapSessionRenderSettingsView __view = ObjectVertexSnapSessionRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __renderSourceVertex,
            __sourceVertexFillColor,
            __sourceVertexBorderColor,
            __sourceVertexRadiusInPixels,
            __view);
    }
}

