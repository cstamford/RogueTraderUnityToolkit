namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BakedPhysicsAnimator (7 fields) 98C57F2D8AE7BB3BFF161860393B4E6E/2D53438E382BE1205CCA37C63B41D86B */
public record class BakedPhysicsAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte PlayOnEnable /* NeedsAlign */,
    PPtr<BakedAnimationParameters> AnimParams /* NeedsAlign */,
    byte Recording /* None */)
{
    public static BakedPhysicsAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* PlayOnEnable */
        byte _PlayOnEnable = reader.ReadU8();
        reader.AlignTo(4); /* AnimParams */
        PPtr<BakedAnimationParameters> _AnimParams = PPtr<BakedAnimationParameters>.Read(reader);
        byte _Recording = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _PlayOnEnable,
            _AnimParams,
            _Recording);
    }
}

