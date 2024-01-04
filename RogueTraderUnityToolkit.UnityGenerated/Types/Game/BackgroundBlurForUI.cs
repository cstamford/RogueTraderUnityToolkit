namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BackgroundBlurForUI (5 fields) 408E851A64FFB098C81E138B11415CA4/DCE5F43768DAA6655CAAEAC8802CB8B2 */
public record class BackgroundBlurForUI(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FullscreenBlurFeature> BlurFeature /* NeedsAlign */)
{
    public static BackgroundBlurForUI Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BlurFeature */
        PPtr<FullscreenBlurFeature> _BlurFeature = PPtr<FullscreenBlurFeature>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BlurFeature);
    }
}

