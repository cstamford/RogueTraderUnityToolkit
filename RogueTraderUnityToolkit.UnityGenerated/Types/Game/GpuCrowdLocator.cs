namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GpuCrowdLocator (7 fields) 59CC6FF1290B80AD7BF65A9145CFD67F/7F129AA42459BA8A774D45DEEFA36C3E */
public record class GpuCrowdLocator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GpuCrowd> gpuCrowd /* NeedsAlign */,
    byte DrawGizmos /* None */,
    Vector3f InitPosition /* NeedsAlign */)
{
    public static GpuCrowdLocator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* gpuCrowd */
        PPtr<GpuCrowd> _gpuCrowd = PPtr<GpuCrowd>.Read(reader);
        byte _DrawGizmos = reader.ReadU8();
        reader.AlignTo(4); /* InitPosition */
        Vector3f _InitPosition = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _gpuCrowd,
            _DrawGizmos,
            _InitPosition);
    }
}

