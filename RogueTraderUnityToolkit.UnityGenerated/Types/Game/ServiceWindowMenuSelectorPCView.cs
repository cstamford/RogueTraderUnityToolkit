namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ServiceWindowMenuSelectorPCView (5 fields) 128C134079D1BFCDB8C5BF10B1090684/747B414EA26551C845C5F1FB73EAF834 */
public record class ServiceWindowMenuSelectorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ServiceWindowsMenuEntityPCView>[] m_MenuEntities /* NeedsAlign */)
{
    public static ServiceWindowMenuSelectorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MenuEntities */
        PPtr<ServiceWindowsMenuEntityPCView>[] _m_MenuEntities = BuiltInArray<PPtr<ServiceWindowsMenuEntityPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MenuEntities);
    }
}

