namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapLegendBlockView (8 fields) 8445F1B1A334119BDAF12B64C1868FAF/ED9666102AC3DFB734616E70EC3BC4CC */
public record class LocalMapLegendBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_BlockCanvasGroup /* NeedsAlign */,
    PPtr<LocalMapLegendBlockItemView> m_LocalMapLegendBlockItemViewPrefab /* None */,
    PPtr<RectTransform>[] m_ItemsPanels /* None */,
    int m_ItemsInOnePanel /* None */)
{
    public static LocalMapLegendBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BlockCanvasGroup */
        PPtr<CanvasGroup> _m_BlockCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<LocalMapLegendBlockItemView> _m_LocalMapLegendBlockItemViewPrefab = PPtr<LocalMapLegendBlockItemView>.Read(reader);
        PPtr<RectTransform>[] _m_ItemsPanels = BuiltInArray<PPtr<RectTransform>>.Read(reader);
        int _m_ItemsInOnePanel = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BlockCanvasGroup,
            _m_LocalMapLegendBlockItemViewPrefab,
            _m_ItemsPanels,
            _m_ItemsInOnePanel);
    }
}

