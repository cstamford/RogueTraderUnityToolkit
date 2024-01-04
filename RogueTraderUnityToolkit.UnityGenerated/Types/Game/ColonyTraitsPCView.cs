namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyTraitsPCView (8 fields) 9EA4E9747899CC8E65E7ADE52C5D9046/5537363883C671C391B96EFCDBB19794 */
public record class ColonyTraitsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListTraits /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ColonyTraitPCView> m_ColonyTraitPCView /* None */)
{
    public static ColonyTraitsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderLabel */
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListTraits = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ColonyTraitPCView> _m_ColonyTraitPCView = PPtr<ColonyTraitPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_WidgetListTraits,
            _m_ScrollRect,
            _m_ColonyTraitPCView);
    }
}

