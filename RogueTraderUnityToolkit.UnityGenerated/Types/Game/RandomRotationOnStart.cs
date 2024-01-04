namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RandomRotationOnStart (8 fields) 813C58BA9E2B531CAB23146B0FCE159E/883AAA0E9B80BEC2787D04051B03F2EC */
public record class RandomRotationOnStart(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int Space /* NeedsAlign */,
    Vector2f RotationX /* None */,
    Vector2f RotationY /* None */,
    Vector2f RotationZ /* None */)
{
    public static RandomRotationOnStart Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Space */
        int _Space = reader.ReadS32();
        Vector2f _RotationX = Vector2f.Read(reader);
        Vector2f _RotationY = Vector2f.Read(reader);
        Vector2f _RotationZ = Vector2f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Space,
            _RotationX,
            _RotationY,
            _RotationZ);
    }
}

