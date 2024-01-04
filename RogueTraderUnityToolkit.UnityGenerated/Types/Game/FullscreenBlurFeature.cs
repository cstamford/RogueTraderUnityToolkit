namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FullscreenBlurFeature (12 fields) E3D7A2F8E637712A0EF832AC285F36E8/B0AD2507953E2BDB026A3C53F888359C */
public record class FullscreenBlurFeature(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_Active /* NeedsAlign */,
    ShaderResources Shaders /* NeedsAlign */,
    int Event /* None */,
    int EventOffset /* None */,
    int BlurType /* None */,
    int Downsample /* None */,
    float BlurSize /* None */,
    int BlurIterations /* None */)
{
    public static FullscreenBlurFeature Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Active */
        byte _m_Active = reader.ReadU8();
        reader.AlignTo(4); /* Shaders */
        ShaderResources _Shaders = ShaderResources.Read(reader);
        int _Event = reader.ReadS32();
        int _EventOffset = reader.ReadS32();
        int _BlurType = reader.ReadS32();
        int _Downsample = reader.ReadS32();
        float _BlurSize = reader.ReadF32();
        int _BlurIterations = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Active,
            _Shaders,
            _Event,
            _EventOffset,
            _BlurType,
            _Downsample,
            _BlurSize,
            _BlurIterations);
    }
}

