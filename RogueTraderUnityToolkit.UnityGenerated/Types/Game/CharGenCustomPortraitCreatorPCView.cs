namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenCustomPortraitCreatorPCView (16 fields) B9A371024B427F8195E900CC78F1FA5A/ABD8DCF23E8FE66FE3AB50A648B8A283 */
public record class CharGenCustomPortraitCreatorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DescriptionLabel /* None */,
    PPtr<TextMeshProUGUI> m_OpenFolderLabel /* None */,
    PPtr<TextMeshProUGUI> m_RefreshPortraitLabel /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    PPtr<CharGenPortraitView> m_PortraitHalf /* None */,
    PPtr<CharGenPortraitView> m_PortraitSmall /* None */,
    PPtr<CharGenPortraitView> m_PortraitView /* None */,
    PPtr<OwlcatButton> m_OpenFolderButton /* None */,
    PPtr<OwlcatButton> m_RefreshPortraitButton /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<TextMeshProUGUI> m_CloseButtonLabel /* None */)
{
    public static CharGenCustomPortraitCreatorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DescriptionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OpenFolderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RefreshPortraitLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharGenPortraitView> _m_PortraitHalf = PPtr<CharGenPortraitView>.Read(reader);
        PPtr<CharGenPortraitView> _m_PortraitSmall = PPtr<CharGenPortraitView>.Read(reader);
        PPtr<CharGenPortraitView> _m_PortraitView = PPtr<CharGenPortraitView>.Read(reader);
        PPtr<OwlcatButton> _m_OpenFolderButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_RefreshPortraitButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CloseButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_DescriptionLabel,
            _m_OpenFolderLabel,
            _m_RefreshPortraitLabel,
            _m_HeaderLabel,
            _m_PortraitHalf,
            _m_PortraitSmall,
            _m_PortraitView,
            _m_OpenFolderButton,
            _m_RefreshPortraitButton,
            _m_CloseButton,
            _m_CloseButtonLabel);
    }
}

