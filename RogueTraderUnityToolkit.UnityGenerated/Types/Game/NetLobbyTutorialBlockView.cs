namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyTutorialBlockView (8 fields) 53F03E7C8BF8EF296AA300859ED5A624/C280C6918C67B93FEF1428C0BA526AD8 */
public record class NetLobbyTutorialBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_BlockImage /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_BlockDescription /* None */,
    PPtr<FadeAnimator> m_BlockFadeAnimator /* None */,
    PPtr<RectTransform> m_RightArrowImage /* None */)
{
    public static NetLobbyTutorialBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BlockImage */
        PPtr<Image> _m_BlockImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BlockDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_BlockFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_RightArrowImage = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BlockImage,
            _m_BlockDescription,
            _m_BlockFadeAnimator,
            _m_RightArrowImage);
    }
}

