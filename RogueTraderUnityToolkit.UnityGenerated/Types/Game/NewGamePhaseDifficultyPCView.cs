namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewGamePhaseDifficultyPCView (7 fields) 174D7F48D60C21AA373F9BD7561A9AF4/06582E0EFB9FF580019FD5E0861D25EE */
public record class NewGamePhaseDifficultyPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InfoSectionView> m_InfoView /* NeedsAlign */,
    PPtr<VirtualListVertical> m_VirtualList /* None */,
    SettingsViews m_SettingsViews /* None */)
{
    public static NewGamePhaseDifficultyPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InfoView */
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        SettingsViews _m_SettingsViews = SettingsViews.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InfoView,
            _m_VirtualList,
            _m_SettingsViews);
    }
}

