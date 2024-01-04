namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarSystemSpaceBarksHolderConsoleView (6 fields) B2C6D992501954F59423F5616FB5E9EF/78427E62A5276BA2A5C7B9B88F0EA454 */
public record class StarSystemSpaceBarksHolderConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<StarSystemSpaceBarkConsoleView> m_StarSystemSpaceBarkView /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */)
{
    public static StarSystemSpaceBarksHolderConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StarSystemSpaceBarkView */
        PPtr<StarSystemSpaceBarkConsoleView> _m_StarSystemSpaceBarkView = PPtr<StarSystemSpaceBarkConsoleView>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StarSystemSpaceBarkView,
            _m_CanvasGroup);
    }
}

