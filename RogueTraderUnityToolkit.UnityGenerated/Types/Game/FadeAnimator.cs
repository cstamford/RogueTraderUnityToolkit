namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FadeAnimator (9 fields) A83F152637AFC02200BB327A1CF2A8C9/F54565322188E88B986E9CA0FED830BE */
public record class FadeAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_AppearTime /* NeedsAlign */,
    int m_AppearAnimCurve /* None */,
    float m_DisappearTime /* None */,
    int m_DisappearAnimCurve /* None */,
    byte m_GameObjectAlwaysActive /* None */)
{
    public static FadeAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AppearTime */
        float _m_AppearTime = reader.ReadF32();
        int _m_AppearAnimCurve = reader.ReadS32();
        float _m_DisappearTime = reader.ReadF32();
        int _m_DisappearAnimCurve = reader.ReadS32();
        byte _m_GameObjectAlwaysActive = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AppearTime,
            _m_AppearAnimCurve,
            _m_DisappearTime,
            _m_DisappearAnimCurve,
            _m_GameObjectAlwaysActive);
    }
}

