namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharBPortraitChanger (7 fields) CA5FE32C6C3FC4221B6740478459EF68/24209293330B141CF0712C70BC71DF72 */
public record class CharBPortraitChanger(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    FXedPortrait m_Portrait1 /* NeedsAlign */,
    FXedPortrait m_Portrait2 /* None */,
    float m_AnimationSpeed /* None */)
{
    public static CharBPortraitChanger Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait1 */
        FXedPortrait _m_Portrait1 = FXedPortrait.Read(reader);
        FXedPortrait _m_Portrait2 = FXedPortrait.Read(reader);
        float _m_AnimationSpeed = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait1,
            _m_Portrait2,
            _m_AnimationSpeed);
    }
}

