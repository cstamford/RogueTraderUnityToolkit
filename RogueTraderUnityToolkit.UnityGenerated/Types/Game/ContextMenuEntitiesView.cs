namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ContextMenuEntitiesView (7 fields) 442F32B95880F35A7CA9F7E1551AB466/157653F9663F3B94E7CDAE92B9E6EA82 */
public record class ContextMenuEntitiesView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ContextMenuEntityView> ContextMenuEntityView /* NeedsAlign */,
    PPtr<ContextMenuHeaderView> ContextMenuHeaderView /* None */,
    PPtr<ContextMenuSeparatorView> ContextMenuSeparatorView /* None */)
{
    public static ContextMenuEntitiesView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ContextMenuEntityView */
        PPtr<ContextMenuEntityView> _ContextMenuEntityView = PPtr<ContextMenuEntityView>.Read(reader);
        PPtr<ContextMenuHeaderView> _ContextMenuHeaderView = PPtr<ContextMenuHeaderView>.Read(reader);
        PPtr<ContextMenuSeparatorView> _ContextMenuSeparatorView = PPtr<ContextMenuSeparatorView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ContextMenuEntityView,
            _ContextMenuHeaderView,
            _ContextMenuSeparatorView);
    }
}

