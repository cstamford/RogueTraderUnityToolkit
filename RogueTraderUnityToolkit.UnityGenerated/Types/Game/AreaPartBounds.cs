namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AreaPartBounds (21 fields) A7B41C3DAF45E566D59EC8B3DBFFF2B4/E768235E07317D6F52B19BE38F68B8F0 */
public record class AreaPartBounds(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AABB m_DefaultBounds /* NeedsAlign */,
    byte m_OverrideMechanicBounds /* None */,
    AABB m_MechanicBounds /* NeedsAlign */,
    byte m_OverrideFogOfWarBounds /* None */,
    AABB m_FogOfWarBounds /* NeedsAlign */,
    byte m_OverrideLocalMapBounds /* None */,
    AABB m_LocalMapBounds /* NeedsAlign */,
    byte m_OverrideCameraBounds /* None */,
    byte m_UseCameraCollidersAsBounds /* NeedsAlign */,
    AABB m_CameraBounds /* NeedsAlign */,
    byte m_OverrideLocationWeatherDataBounds /* None */,
    AABB m_LocationWeatherDataBounds /* NeedsAlign */,
    float m_ShadowFalloff /* None */,
    byte m_IsBlurEnabled /* None */,
    Texture2DLink m_StaticMaskLink /* NeedsAlign */,
    BorderSettings m_FogOfWarBorderSettings /* NeedsAlign */,
    int m_FogOfWarStartOptions /* NeedsAlign */)
{
    public static AreaPartBounds Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DefaultBounds */
        AABB _m_DefaultBounds = AABB.Read(reader);
        byte _m_OverrideMechanicBounds = reader.ReadU8();
        reader.AlignTo(4); /* m_MechanicBounds */
        AABB _m_MechanicBounds = AABB.Read(reader);
        byte _m_OverrideFogOfWarBounds = reader.ReadU8();
        reader.AlignTo(4); /* m_FogOfWarBounds */
        AABB _m_FogOfWarBounds = AABB.Read(reader);
        byte _m_OverrideLocalMapBounds = reader.ReadU8();
        reader.AlignTo(4); /* m_LocalMapBounds */
        AABB _m_LocalMapBounds = AABB.Read(reader);
        byte _m_OverrideCameraBounds = reader.ReadU8();
        reader.AlignTo(4); /* m_UseCameraCollidersAsBounds */
        byte _m_UseCameraCollidersAsBounds = reader.ReadU8();
        reader.AlignTo(4); /* m_CameraBounds */
        AABB _m_CameraBounds = AABB.Read(reader);
        byte _m_OverrideLocationWeatherDataBounds = reader.ReadU8();
        reader.AlignTo(4); /* m_LocationWeatherDataBounds */
        AABB _m_LocationWeatherDataBounds = AABB.Read(reader);
        float _m_ShadowFalloff = reader.ReadF32();
        byte _m_IsBlurEnabled = reader.ReadU8();
        reader.AlignTo(4); /* m_StaticMaskLink */
        Texture2DLink _m_StaticMaskLink = Texture2DLink.Read(reader);
        reader.AlignTo(4); /* m_FogOfWarBorderSettings */
        BorderSettings _m_FogOfWarBorderSettings = BorderSettings.Read(reader);
        reader.AlignTo(4); /* m_FogOfWarStartOptions */
        int _m_FogOfWarStartOptions = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DefaultBounds,
            _m_OverrideMechanicBounds,
            _m_MechanicBounds,
            _m_OverrideFogOfWarBounds,
            _m_FogOfWarBounds,
            _m_OverrideLocalMapBounds,
            _m_LocalMapBounds,
            _m_OverrideCameraBounds,
            _m_UseCameraCollidersAsBounds,
            _m_CameraBounds,
            _m_OverrideLocationWeatherDataBounds,
            _m_LocationWeatherDataBounds,
            _m_ShadowFalloff,
            _m_IsBlurEnabled,
            _m_StaticMaskLink,
            _m_FogOfWarBorderSettings,
            _m_FogOfWarStartOptions);
    }
}

