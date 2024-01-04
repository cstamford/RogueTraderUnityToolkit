namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineShot (6 fields) 3985D734DA925ECA4763C4CC028A0CF3/9E79CD1EAB06AD3019419C213C103FDD */
public record class CinemachineShot(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString DisplayName /* NeedsAlign */,
    ExposedReference_1 VirtualCamera /* NeedsAlign */)
{
    public static CinemachineShot Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DisplayName */
        AsciiString _DisplayName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* VirtualCamera */
        ExposedReference_1 _VirtualCamera = ExposedReference_1.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _DisplayName,
            _VirtualCamera);
    }
}

