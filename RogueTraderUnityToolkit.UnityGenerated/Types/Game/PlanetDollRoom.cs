namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PlanetDollRoom (13 fields) C870B7349F67C4D1D24289038D6BF5AC/7C0A8E2B249D9C6418AE190C9950C71A */
public record class PlanetDollRoom(
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
    PPtr<DollRoomBackground> m_Background /* None */)
{
    public static PlanetDollRoom Read(EndianBinaryReader reader)
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
            _m_Background);
    }
}

