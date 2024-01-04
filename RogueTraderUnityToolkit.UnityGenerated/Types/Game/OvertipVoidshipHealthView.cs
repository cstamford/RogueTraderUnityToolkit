namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipVoidshipHealthView (6 fields) 4ABA16136B5CA8E13DDD293D5894CCAD/ADD3779B8A76E3370D21477388AD21BF */
public record class OvertipVoidshipHealthView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_VoidshipHealthBar /* NeedsAlign */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */)
{
    public static OvertipVoidshipHealthView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VoidshipHealthBar */
        PPtr<Image> _m_VoidshipHealthBar = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VoidshipHealthBar,
            _m_FadeAnimator);
    }
}

