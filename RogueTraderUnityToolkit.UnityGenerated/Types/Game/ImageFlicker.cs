namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ImageFlicker (8 fields) D0D198EC0C3A1D0C03C224E057D92FA0/8BA8C547627B77E332FB82D112471E5A */
public record class ImageFlicker(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Image /* NeedsAlign */,
    float minAlpha /* None */,
    float maxAlpha /* None */,
    float delay /* None */)
{
    public static ImageFlicker Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Image */
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        float _minAlpha = reader.ReadF32();
        float _maxAlpha = reader.ReadF32();
        float _delay = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Image,
            _minAlpha,
            _maxAlpha,
            _delay);
    }
}

