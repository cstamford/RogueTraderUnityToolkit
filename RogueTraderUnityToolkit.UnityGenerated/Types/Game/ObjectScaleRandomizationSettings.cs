namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectScaleRandomizationSettings (7 fields) 4402F4DC6AEF748A294BFB59B968430A/864D11898E2C4E06C6A91961A51B430C */
public record class ObjectScaleRandomizationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _randomizeScale /* NeedsAlign */,
    PPtr<ObjectUniformScaleRandomizationSettings> _uniformScaleRandomizationSettings /* NeedsAlign */,
    ObjectScaleRandomizationSettingsView _view /* None */)
{
    public static ObjectScaleRandomizationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _randomizeScale */
        byte __randomizeScale = reader.ReadU8();
        reader.AlignTo(4); /* _uniformScaleRandomizationSettings */
        PPtr<ObjectUniformScaleRandomizationSettings> __uniformScaleRandomizationSettings = PPtr<ObjectUniformScaleRandomizationSettings>.Read(reader);
        ObjectScaleRandomizationSettingsView __view = ObjectScaleRandomizationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __randomizeScale,
            __uniformScaleRandomizationSettings,
            __view);
    }
}

