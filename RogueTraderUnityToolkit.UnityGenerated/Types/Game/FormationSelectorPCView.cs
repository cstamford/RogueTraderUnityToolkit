namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FormationSelectorPCView (10 fields) 8A413975CEDB2B3562D2797CFC528B1B/B4ECFC16B3D56A1706081AB8C5198055 */
public record class FormationSelectorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FormationSelectionItemPCView> m_Item0 /* NeedsAlign */,
    PPtr<FormationSelectionItemPCView> m_Item1 /* None */,
    PPtr<FormationSelectionItemPCView> m_Item2 /* None */,
    PPtr<FormationSelectionItemPCView> m_Item3 /* None */,
    PPtr<FormationSelectionItemPCView> m_Item4 /* None */,
    PPtr<FormationSelectionItemPCView> m_Item5 /* None */)
{
    public static FormationSelectorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Item0 */
        PPtr<FormationSelectionItemPCView> _m_Item0 = PPtr<FormationSelectionItemPCView>.Read(reader);
        PPtr<FormationSelectionItemPCView> _m_Item1 = PPtr<FormationSelectionItemPCView>.Read(reader);
        PPtr<FormationSelectionItemPCView> _m_Item2 = PPtr<FormationSelectionItemPCView>.Read(reader);
        PPtr<FormationSelectionItemPCView> _m_Item3 = PPtr<FormationSelectionItemPCView>.Read(reader);
        PPtr<FormationSelectionItemPCView> _m_Item4 = PPtr<FormationSelectionItemPCView>.Read(reader);
        PPtr<FormationSelectionItemPCView> _m_Item5 = PPtr<FormationSelectionItemPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Item0,
            _m_Item1,
            _m_Item2,
            _m_Item3,
            _m_Item4,
            _m_Item5);
    }
}

