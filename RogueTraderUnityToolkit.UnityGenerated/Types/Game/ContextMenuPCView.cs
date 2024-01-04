namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ContextMenuPCView (6 fields) 73AC8B0BA4C8BDE2E67AD9FDD78827D8/449CE02E4A5586B17F3A1B7769681F62 */
public record class ContextMenuPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ContextMenuEntitiesView> m_Config /* NeedsAlign */,
    PPtr<RectTransform> m_Container /* None */)
{
    public static ContextMenuPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Config */
        PPtr<ContextMenuEntitiesView> _m_Config = PPtr<ContextMenuEntitiesView>.Read(reader);
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Config,
            _m_Container);
    }
}

