namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelectionActionsViewData (6 fields) C279185181DFEA95B355B2BA37855836/EE9197DEB1066193E3B36B8FBD68A181 */
public record class ObjectSelectionActionsViewData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _selectionAssignmentLayer /* NeedsAlign */,
    AsciiString _destObjectGroupName /* None */)
{
    public static ObjectSelectionActionsViewData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _selectionAssignmentLayer */
        int __selectionAssignmentLayer = reader.ReadS32();
        AsciiString __destObjectGroupName = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __selectionAssignmentLayer,
            __destObjectGroupName);
    }
}

