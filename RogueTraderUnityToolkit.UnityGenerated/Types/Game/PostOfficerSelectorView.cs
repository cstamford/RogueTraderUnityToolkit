namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostOfficerSelectorView (5 fields) AF6B9CC32D2631D14B98C5BD813D2A5A/276AB96D203B863AEF2E3876379828EE */
public record class PostOfficerSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PostOfficerSelectionGroup> m_PostOfficerSelectionGroup /* NeedsAlign */)
{
    public static PostOfficerSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PostOfficerSelectionGroup */
        PPtr<PostOfficerSelectionGroup> _m_PostOfficerSelectionGroup = PPtr<PostOfficerSelectionGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PostOfficerSelectionGroup);
    }
}
