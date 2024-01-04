namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UIFirstLaunchFX (6 fields) E37054364C23A6BFBC32477FCC563F0F/D3172E0332A84C8CDB81342A067428ED */
public record class UIFirstLaunchFX(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<MainMenuButtonFx>[] m_FXObjects /* NeedsAlign */,
    EffectSettings m_EffectSettings /* None */)
{
    public static UIFirstLaunchFX Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FXObjects */
        PPtr<MainMenuButtonFx>[] _m_FXObjects = BuiltInArray<PPtr<MainMenuButtonFx>>.Read(reader);
        EffectSettings _m_EffectSettings = EffectSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FXObjects,
            _m_EffectSettings);
    }
}

