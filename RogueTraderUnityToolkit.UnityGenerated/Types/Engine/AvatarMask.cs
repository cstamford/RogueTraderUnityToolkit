namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $AvatarMask (3 fields) 9215D1126AA8279C97CEA97F18DAEFDA */
public record class AvatarMask(
    AsciiString m_Name /* None */,
    uint[] m_Mask /* NeedsAlign */,
    TransformMaskElement[] m_Elements /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2450903314, 1789405084, 2546903423, 417001434);
    public static AvatarMask Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Mask */
        uint[] _m_Mask = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_Elements */
        TransformMaskElement[] _m_Elements = BuiltInArray<TransformMaskElement>.Read(reader);
        
        return new(_m_Name,
            _m_Mask,
            _m_Elements);
    }
}

