namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $VisualEffectAsset (3 fields) 9E4574B6881DEB162C7B7E88AD5B3242 */
public record class VisualEffectAsset(
    AsciiString m_Name /* None */,
    VisualEffectInfo m_Infos /* NeedsAlign */,
    VFXSystemDesc[] m_Systems /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2655351990, 2283662102, 746290824, 2908435010);
    public static VisualEffectAsset Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Infos */
        VisualEffectInfo _m_Infos = VisualEffectInfo.Read(reader);
        reader.AlignTo(4); /* m_Systems */
        VFXSystemDesc[] _m_Systems = BuiltInArray<VFXSystemDesc>.Read(reader);
        
        return new(_m_Name,
            _m_Infos,
            _m_Systems);
    }
}

