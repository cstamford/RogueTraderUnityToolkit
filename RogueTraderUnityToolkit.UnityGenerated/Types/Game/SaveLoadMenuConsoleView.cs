namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveLoadMenuConsoleView (5 fields) DCEBE5EA7ADE19765BB3191A03088481/00AA0B77B4778126A25F7FB02C699356 */
public record class SaveLoadMenuConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SaveLoadMenuSelectorBaseView> m_Selector /* NeedsAlign */)
{
    public static SaveLoadMenuConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selector */
        PPtr<SaveLoadMenuSelectorBaseView> _m_Selector = PPtr<SaveLoadMenuSelectorBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selector);
    }
}

