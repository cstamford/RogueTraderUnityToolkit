namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OccludedObjectDepthClipper (6 fields) 16414731E76C97865C3AA0BAB0809B7E/9FD3008B574B037CC5FEF818C6882667 */
public record class OccludedObjectDepthClipper(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_Radius /* NeedsAlign */,
    float m_OffsetToCamera /* None */)
{
    public static OccludedObjectDepthClipper Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Radius */
        float _m_Radius = reader.ReadF32();
        float _m_OffsetToCamera = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Radius,
            _m_OffsetToCamera);
    }
}

