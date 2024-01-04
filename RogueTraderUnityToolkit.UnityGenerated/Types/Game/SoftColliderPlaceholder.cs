namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SoftColliderPlaceholder (7 fields) 318B967FDAF60E24787BD3816B011522/1414316E8B51CE3379376BC7ABCF8589 */
public record class SoftColliderPlaceholder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte overrideColliderParameters /* NeedsAlign */,
    float ColliderRadius /* NeedsAlign */,
    float ColliderHeight /* None */)
{
    public static SoftColliderPlaceholder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* overrideColliderParameters */
        byte _overrideColliderParameters = reader.ReadU8();
        reader.AlignTo(4); /* ColliderRadius */
        float _ColliderRadius = reader.ReadF32();
        float _ColliderHeight = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _overrideColliderParameters,
            _ColliderRadius,
            _ColliderHeight);
    }
}

