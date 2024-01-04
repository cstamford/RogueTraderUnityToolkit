namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $ComputeShader (2 fields) AB63DFBF5A4DE80CE55E762CE70FD960 */
public record class ComputeShader(
    AsciiString m_Name /* None */,
    ComputeShaderPlatformVariant[] variants /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2875449279, 1515055116, 3848173100, 3876575584);
    public static ComputeShader Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* variants */
        ComputeShaderPlatformVariant[] _variants = BuiltInArray<ComputeShaderPlatformVariant>.Read(reader);
        
        return new(_m_Name,
            _variants);
    }
}

