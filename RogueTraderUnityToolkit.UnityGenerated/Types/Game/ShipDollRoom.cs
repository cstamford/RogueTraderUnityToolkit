namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipDollRoom (19 fields) 42A74B72BB484AE6052300E15373AAC5/31E34058F3CF1359FF5CEA909D53EF7C */
public record class ShipDollRoom(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> m_TargetPlaceholder /* NeedsAlign */,
    PPtr<DollRoomTargetController> m_TargetController /* None */,
    PPtr<Volume> m_DollRoomPostProcessVolume /* None */,
    PPtr<Volume> m_DollRoomCharGenPostProcessVolume /* None */,
    float m_DollAppearStep /* None */,
    float m_DollAppearStepInterval /* None */,
    PPtr<DollCamera> m_Camera /* None */,
    PPtr<Light>[] m_DisabledLights /* None */,
    PPtr<DollRoomBackground> m_Background /* None */,
    float m_ShipPlaceholderDefaultRotationY /* None */,
    ColorRGBA m_BackgroundColor /* None */,
    PPtr<GameObject> m_Skydome /* None */,
    MaterialLink m_DefaultSkydomeMaterial /* None */,
    PPtr<GameObject> m_DefaultPlanet /* NeedsAlign */,
    PPtr<GameObject> m_PlanetRoot /* None */)
{
    public static ShipDollRoom Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TargetPlaceholder */
        PPtr<Transform> _m_TargetPlaceholder = PPtr<Transform>.Read(reader);
        PPtr<DollRoomTargetController> _m_TargetController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<Volume> _m_DollRoomPostProcessVolume = PPtr<Volume>.Read(reader);
        PPtr<Volume> _m_DollRoomCharGenPostProcessVolume = PPtr<Volume>.Read(reader);
        float _m_DollAppearStep = reader.ReadF32();
        float _m_DollAppearStepInterval = reader.ReadF32();
        PPtr<DollCamera> _m_Camera = PPtr<DollCamera>.Read(reader);
        PPtr<Light>[] _m_DisabledLights = BuiltInArray<PPtr<Light>>.Read(reader);
        PPtr<DollRoomBackground> _m_Background = PPtr<DollRoomBackground>.Read(reader);
        float _m_ShipPlaceholderDefaultRotationY = reader.ReadF32();
        ColorRGBA _m_BackgroundColor = ColorRGBA.Read(reader);
        PPtr<GameObject> _m_Skydome = PPtr<GameObject>.Read(reader);
        MaterialLink _m_DefaultSkydomeMaterial = MaterialLink.Read(reader);
        reader.AlignTo(4); /* m_DefaultPlanet */
        PPtr<GameObject> _m_DefaultPlanet = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PlanetRoot = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TargetPlaceholder,
            _m_TargetController,
            _m_DollRoomPostProcessVolume,
            _m_DollRoomCharGenPostProcessVolume,
            _m_DollAppearStep,
            _m_DollAppearStepInterval,
            _m_Camera,
            _m_DisabledLights,
            _m_Background,
            _m_ShipPlaceholderDefaultRotationY,
            _m_BackgroundColor,
            _m_Skydome,
            _m_DefaultSkydomeMaterial,
            _m_DefaultPlanet,
            _m_PlanetRoot);
    }
}

