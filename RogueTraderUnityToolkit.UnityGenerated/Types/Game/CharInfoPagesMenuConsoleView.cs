namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoPagesMenuConsoleView (11 fields) 901B46E9464DF37FF520186273B0A95F/4AE3B27CE4AAFC18DB61658B6D9EDDBF */
public record class CharInfoPagesMenuConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharInfoPagesMenuEntityPCView> m_MenuItemViewPrefab /* None */,
    PPtr<Transform> m_Lens /* None */,
    float m_LensInitialPositionX /* None */,
    float m_LensAnimationDuration /* None */,
    PPtr<ConsoleHint> m_PreviousFilterHint /* None */,
    PPtr<ConsoleHint> m_NextFilterHint /* None */)
{
    public static CharInfoPagesMenuConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoPagesMenuEntityPCView> _m_MenuItemViewPrefab = PPtr<CharInfoPagesMenuEntityPCView>.Read(reader);
        PPtr<Transform> _m_Lens = PPtr<Transform>.Read(reader);
        float _m_LensInitialPositionX = reader.ReadF32();
        float _m_LensAnimationDuration = reader.ReadF32();
        PPtr<ConsoleHint> _m_PreviousFilterHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextFilterHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_MenuItemViewPrefab,
            _m_Lens,
            _m_LensInitialPositionX,
            _m_LensAnimationDuration,
            _m_PreviousFilterHint,
            _m_NextFilterHint);
    }
}

