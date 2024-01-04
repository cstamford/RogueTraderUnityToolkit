namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostEntityView (14 fields) 265278BAF7B85D86E69B327A3A7D7C50/85DCB025F0392BCA2DF7540085208B21 */
public record class PostEntityView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<Image> m_Portrait /* None */,
    PPtr<GameObject> m_EmptyPortrait /* None */,
    PPtr<Image> m_PostSprite /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<CanvasGroup> m_PostBlock /* None */,
    int m_EmptyAlpha /* None */,
    int m_NotEmptyAlpha /* None */,
    PPtr<GameObject> m_AbilitiesBlock /* None */,
    PPtr<PostAbilitiesGroupBaseView> PostAbilitiesGroupPCView /* None */)
{
    public static PostEntityView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_EmptyPortrait = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_PostSprite = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_PostBlock = PPtr<CanvasGroup>.Read(reader);
        int _m_EmptyAlpha = reader.ReadS32();
        int _m_NotEmptyAlpha = reader.ReadS32();
        PPtr<GameObject> _m_AbilitiesBlock = PPtr<GameObject>.Read(reader);
        PPtr<PostAbilitiesGroupBaseView> _PostAbilitiesGroupPCView = PPtr<PostAbilitiesGroupBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Portrait,
            _m_EmptyPortrait,
            _m_PostSprite,
            _m_Title,
            _m_PostBlock,
            _m_EmptyAlpha,
            _m_NotEmptyAlpha,
            _m_AbilitiesBlock,
            _PostAbilitiesGroupPCView);
    }
}

