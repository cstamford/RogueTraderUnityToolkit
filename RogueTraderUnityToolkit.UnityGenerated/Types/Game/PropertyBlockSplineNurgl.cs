namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PropertyBlockSplineNurgl (11 fields) AE881DEAF6F75AAA30F10C56DC151F18/6EE52BA8AD519D59774B1451CDDC6562 */
public record class PropertyBlockSplineNurgl(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float bulgeWidth /* NeedsAlign */,
    float BuldgePower /* None */,
    float TimeOffset /* None */,
    float TileX /* None */,
    float TileY /* None */,
    float Speed /* None */,
    byte InvertBool /* None */)
{
    public static PropertyBlockSplineNurgl Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* bulgeWidth */
        float _bulgeWidth = reader.ReadF32();
        float _BuldgePower = reader.ReadF32();
        float _TimeOffset = reader.ReadF32();
        float _TileX = reader.ReadF32();
        float _TileY = reader.ReadF32();
        float _Speed = reader.ReadF32();
        byte _InvertBool = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _bulgeWidth,
            _BuldgePower,
            _TimeOffset,
            _TileX,
            _TileY,
            _Speed,
            _InvertBool);
    }
}

