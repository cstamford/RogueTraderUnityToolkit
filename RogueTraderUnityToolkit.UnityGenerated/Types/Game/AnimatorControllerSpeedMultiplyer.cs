namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimatorControllerSpeedMultiplyer (8 fields) 8483A4B3ADF4722532405CC92AD15804/AF82BE1AB8A8C23AE7F8467359D8F848 */
public record class AnimatorControllerSpeedMultiplyer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float AnimatorSpeedMultiplyer /* NeedsAlign */,
    float AnimatorDeelay /* None */,
    float RandomStart /* None */,
    byte _realtime /* None */)
{
    public static AnimatorControllerSpeedMultiplyer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AnimatorSpeedMultiplyer */
        float _AnimatorSpeedMultiplyer = reader.ReadF32();
        float _AnimatorDeelay = reader.ReadF32();
        float _RandomStart = reader.ReadF32();
        byte __realtime = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AnimatorSpeedMultiplyer,
            _AnimatorDeelay,
            _RandomStart,
            __realtime);
    }
}

