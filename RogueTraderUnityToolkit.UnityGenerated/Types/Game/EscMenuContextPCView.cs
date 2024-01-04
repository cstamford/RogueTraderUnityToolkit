namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EscMenuContextPCView (5 fields) D876D379D330D55A805A4A8372A1CF80/3C296F3251B54F8167753FED6255E892 */
public record class EscMenuContextPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<EscMenuPCView> m_EscMenuPCView /* NeedsAlign */)
{
    public static EscMenuContextPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EscMenuPCView */
        PPtr<EscMenuPCView> _m_EscMenuPCView = PPtr<EscMenuPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EscMenuPCView);
    }
}

