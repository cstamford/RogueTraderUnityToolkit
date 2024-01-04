namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuAnimationsController (5 fields) F0838248BDC06D2A7EAACA71293C2D84/72BDB44B5A175043BD370EF644437D1C */
public record class MainMenuAnimationsController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Animator> FadeOutAnimator /* NeedsAlign */)
{
    public static MainMenuAnimationsController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* FadeOutAnimator */
        PPtr<Animator> _FadeOutAnimator = PPtr<Animator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _FadeOutAnimator);
    }
}

