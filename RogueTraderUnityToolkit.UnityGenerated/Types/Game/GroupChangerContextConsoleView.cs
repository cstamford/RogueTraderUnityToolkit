namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GroupChangerContextConsoleView (5 fields) B3874B017E1A0453AB4CFB2636923BD9/280465BD9C24587E531765D108BC1437 */
public record class GroupChangerContextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GroupChangerBaseView> m_GroupChangerPCView /* NeedsAlign */)
{
    public static GroupChangerContextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GroupChangerPCView */
        PPtr<GroupChangerBaseView> _m_GroupChangerPCView = PPtr<GroupChangerBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_GroupChangerPCView);
    }
}

