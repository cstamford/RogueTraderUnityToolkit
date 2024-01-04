namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SaveLoadPortraitBaseView (7 fields) 2133475070A0BBD0127B4283B1A77650/B32AD4EE090CF8E80B999844CF5D1D9A */
public record class SaveLoadPortraitBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<GameObject> m_RankGameObject /* None */,
    PPtr<TextMeshProUGUI> m_RankLabel /* None */)
{
    public static SaveLoadPortraitBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_RankGameObject = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RankLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_RankGameObject,
            _m_RankLabel);
    }
}

