namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaPCView (8 fields) 7350086B05EC85D0D363B14018E4668F/7907DDAF07898CD29B5CD5D11CF6FAA6 */
public record class EncyclopediaPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<EncyclopediaNavigationBaseView> m_Navigation /* None */,
    PPtr<EncyclopediaPageBaseView> m_Page /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */)
{
    public static EncyclopediaPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<EncyclopediaNavigationBaseView> _m_Navigation = PPtr<EncyclopediaNavigationBaseView>.Read(reader);
        PPtr<EncyclopediaPageBaseView> _m_Page = PPtr<EncyclopediaPageBaseView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PantographView,
            _m_Navigation,
            _m_Page,
            _m_Title);
    }
}

