namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BookEventSkillsBlockPCView (7 fields) 8A38E8BBEDD38D1F119983FA7C35120A/B76CE6BEA8ED4AE60C8F0EF2723A4EC5 */
public record class BookEventSkillsBlockPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SkillName /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<BookEventSkillPCView> m_BookEventSkillViewPrefab /* None */)
{
    public static BookEventSkillsBlockPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SkillName */
        PPtr<TextMeshProUGUI> _m_SkillName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<BookEventSkillPCView> _m_BookEventSkillViewPrefab = PPtr<BookEventSkillPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SkillName,
            _m_WidgetList,
            _m_BookEventSkillViewPrefab);
    }
}

