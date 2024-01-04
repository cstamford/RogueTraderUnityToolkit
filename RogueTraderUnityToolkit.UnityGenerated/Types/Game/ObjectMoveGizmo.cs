namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectMoveGizmo (6 fields) 3A1E5528CD2BC9827F68B6DCCA83F298/E1EE7B82806D102467A4AA3294F8FEE9 */
public record class ObjectMoveGizmo(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f _worldPosition /* NeedsAlign */,
    Quaternionf _worldRotation /* None */)
{
    public static ObjectMoveGizmo Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _worldPosition */
        Vector3f __worldPosition = Vector3f.Read(reader);
        Quaternionf __worldRotation = Quaternionf.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __worldPosition,
            __worldRotation);
    }
}

