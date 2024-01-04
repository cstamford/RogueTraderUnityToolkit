namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatBackgroundComposer (6 fields) 73A0B1B3237246736516C18F60203E05/86DFC26C95D3E9B23ABF9E75B1D9F28F */
public record class SpaceCombatBackgroundComposer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> BackgroundCameraPrefab /* NeedsAlign */,
    PPtr<SpaceCombatBackgroundComposerConfigs> DefaultBackGroundComposerConfig /* None */)
{
    public static SpaceCombatBackgroundComposer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BackgroundCameraPrefab */
        PPtr<GameObject> _BackgroundCameraPrefab = PPtr<GameObject>.Read(reader);
        PPtr<SpaceCombatBackgroundComposerConfigs> _DefaultBackGroundComposerConfig = PPtr<SpaceCombatBackgroundComposerConfigs>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BackgroundCameraPrefab,
            _DefaultBackGroundComposerConfig);
    }
}

