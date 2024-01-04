namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TutorialPCView (6 fields) 3EE41D176CA871C82627B31BAA654206/B9D55E11DB3702B9C2503B884C908D50 */
public record class TutorialPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TutorialModalWindowPCView> m_BigWindowView /* NeedsAlign */,
    PPtr<TutorialHintWindowPCView> m_SmallWindowView /* None */)
{
    public static TutorialPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BigWindowView */
        PPtr<TutorialModalWindowPCView> _m_BigWindowView = PPtr<TutorialModalWindowPCView>.Read(reader);
        PPtr<TutorialHintWindowPCView> _m_SmallWindowView = PPtr<TutorialHintWindowPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BigWindowView,
            _m_SmallWindowView);
    }
}

