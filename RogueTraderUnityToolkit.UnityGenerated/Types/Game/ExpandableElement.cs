namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExpandableElement (10 fields) 090F7C5F6474B83B552613ADFB19F82C/4964A0902470B8B5EC678389910E2E5C */
public record class ExpandableElement(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<Transform> m_ExpandArrow /* None */,
    PPtr<GameObject> m_Content /* None */,
    PPtr<FadeAnimator> m_ContentAnimator /* None */,
    AsciiString Key /* None */,
    AsciiString ParentKey /* NeedsAlign */)
{
    public static ExpandableElement Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Transform> _m_ExpandArrow = PPtr<Transform>.Read(reader);
        PPtr<GameObject> _m_Content = PPtr<GameObject>.Read(reader);
        PPtr<FadeAnimator> _m_ContentAnimator = PPtr<FadeAnimator>.Read(reader);
        AsciiString _Key = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ParentKey */
        AsciiString _ParentKey = BuiltInString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_ExpandArrow,
            _m_Content,
            _m_ContentAnimator,
            _Key,
            _ParentKey);
    }
}

