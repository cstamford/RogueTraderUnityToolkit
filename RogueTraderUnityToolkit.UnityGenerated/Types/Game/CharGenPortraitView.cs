namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPortraitView (8 fields) 9D7424FEB6A196EC0214CF68D3A38BEC/65E90E40AA524A60294869331D4614B6 */
public record class CharGenPortraitView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharBPortraitChanger> m_Portrait /* NeedsAlign */,
    PPtr<FadeAnimator> m_Animator /* None */,
    int m_Size /* None */,
    PPtr<OwlcatButton> m_HoverButton /* None */)
{
    public static CharGenPortraitView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<CharBPortraitChanger> _m_Portrait = PPtr<CharBPortraitChanger>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        int _m_Size = reader.ReadS32();
        PPtr<OwlcatButton> _m_HoverButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_Animator,
            _m_Size,
            _m_HoverButton);
    }
}

