namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RespecContextCommonView (5 fields) 786DD052EF565529009F67C90730EC6C/77C50F77388C18FF85055B14118D9991 */
public record class RespecContextCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RespecWindowCommonView> m_RespecWindowCommonView /* NeedsAlign */)
{
    public static RespecContextCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RespecWindowCommonView */
        PPtr<RespecWindowCommonView> _m_RespecWindowCommonView = PPtr<RespecWindowCommonView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RespecWindowCommonView);
    }
}

