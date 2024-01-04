namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DynamicGridObstacle (8 fields) 79BBFFB55F2096F1864CFC7B9BEC3CCB/D285D6075FC10F9F8488093B2A97E052 */
public record class DynamicGridObstacle(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int version /* NeedsAlign */,
    ulong uniqueID /* None */,
    float updateError /* None */,
    float checkTime /* None */)
{
    public static DynamicGridObstacle Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* version */
        int _version = reader.ReadS32();
        ulong _uniqueID = reader.ReadU64();
        float _updateError = reader.ReadF32();
        float _checkTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _version,
            _uniqueID,
            _updateError,
            _checkTime);
    }
}

