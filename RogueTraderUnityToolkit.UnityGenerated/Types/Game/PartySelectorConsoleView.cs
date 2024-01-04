namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PartySelectorConsoleView (14 fields) 35F60DDDFE37F5F9C3C4E980BCA49949/7FB0525BEC3FA26AEE431E2BDF134F42 */
public record class PartySelectorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PartySelectorItemConsoleView> m_ItemPrefab /* NeedsAlign */,
    PPtr<GridLayoutGroup> m_Content /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<CanvasSortingComponent> m_CanvasSortingComponent /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<ConsoleHint> m_LinkAllHint /* None */,
    PPtr<ConsoleHint> m_LinkHint /* None */,
    PPtr<ConsoleHint> m_LevelUpHint /* None */,
    PPtr<ConsoleHint> m_MoveToNextHint /* None */,
    PPtr<ConsoleHint> m_MoveToPreviousHint /* None */)
{
    public static PartySelectorConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ItemPrefab */
        PPtr<PartySelectorItemConsoleView> _m_ItemPrefab = PPtr<PartySelectorItemConsoleView>.Read(reader);
        PPtr<GridLayoutGroup> _m_Content = PPtr<GridLayoutGroup>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CanvasSortingComponent> _m_CanvasSortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_LinkAllHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_LinkHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_LevelUpHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_MoveToNextHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_MoveToPreviousHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ItemPrefab,
            _m_Content,
            _m_FadeAnimator,
            _m_CanvasSortingComponent,
            _m_HintsWidget,
            _m_LinkAllHint,
            _m_LinkHint,
            _m_LevelUpHint,
            _m_MoveToNextHint,
            _m_MoveToPreviousHint);
    }
}

