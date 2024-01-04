namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipSystemResourceBlockView (7 fields) E0254C70DD0AC25DDBC0CD9110E4D343/B55246596280792BED47B0DE2646BFE8 */
public record class OvertipSystemResourceBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_ResourcesGroup /* NeedsAlign */,
    PPtr<RectTransform> m_NeedsGroup /* None */,
    PPtr<SystemResourceItem> m_ResourceItemPrefab /* None */)
{
    public static OvertipSystemResourceBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ResourcesGroup */
        PPtr<RectTransform> _m_ResourcesGroup = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_NeedsGroup = PPtr<RectTransform>.Read(reader);
        PPtr<SystemResourceItem> _m_ResourceItemPrefab = PPtr<SystemResourceItem>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ResourcesGroup,
            _m_NeedsGroup,
            _m_ResourceItemPrefab);
    }
}

