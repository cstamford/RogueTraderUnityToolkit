namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SelectionManagerConsole (6 fields) 4E1FD7EEB1D74DC962C79BB0222A43F2/6605D13DF2FEA572ED48BF669A887E14 */
public record class SelectionManagerConsole(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BaseUnitMark> m_SelectionMarkPrefab /* NeedsAlign */,
    byte StopMoveFlag /* None */)
{
    public static SelectionManagerConsole Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SelectionMarkPrefab */
        PPtr<BaseUnitMark> _m_SelectionMarkPrefab = PPtr<BaseUnitMark>.Read(reader);
        byte _StopMoveFlag = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SelectionMarkPrefab,
            _StopMoveFlag);
    }
}

