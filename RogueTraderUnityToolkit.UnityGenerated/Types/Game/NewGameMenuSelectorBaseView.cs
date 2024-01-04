namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewGameMenuSelectorBaseView (8 fields) 0BAA39D8EB7C0E1212771029E7173342/B3F3BA11C89E7AF4E3954EA5B941B243 */
public record class NewGameMenuSelectorBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<NewGameMenuEntityBaseView> m_GameModeButton /* NeedsAlign */,
    PPtr<NewGameMenuEntityBaseView> m_DifficultyButton /* None */,
    PPtr<GameObject> m_Selector /* None */,
    float m_LensSwitchAnimationDuration /* None */)
{
    public static NewGameMenuSelectorBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GameModeButton */
        PPtr<NewGameMenuEntityBaseView> _m_GameModeButton = PPtr<NewGameMenuEntityBaseView>.Read(reader);
        PPtr<NewGameMenuEntityBaseView> _m_DifficultyButton = PPtr<NewGameMenuEntityBaseView>.Read(reader);
        PPtr<GameObject> _m_Selector = PPtr<GameObject>.Read(reader);
        float _m_LensSwitchAnimationDuration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_GameModeButton,
            _m_DifficultyButton,
            _m_Selector,
            _m_LensSwitchAnimationDuration);
    }
}

