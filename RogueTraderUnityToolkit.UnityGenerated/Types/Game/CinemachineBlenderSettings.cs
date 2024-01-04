namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineBlenderSettings (5 fields) D0B47C96267052069B7303BEE8B25C2F/6BE52FBB8F43A8F69FA12124E34D8046 */
public record class CinemachineBlenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    CustomBlend[] m_CustomBlends /* NeedsAlign */)
{
    public static CinemachineBlenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CustomBlends */
        CustomBlend[] _m_CustomBlends = BuiltInArray<CustomBlend>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CustomBlends);
    }
}

