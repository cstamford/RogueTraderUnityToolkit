namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAttributesPhasePantographItemRankWidget (5 fields) B5C304F29828B3BB429A7B04682E5DD6/CA5AB8062465C0AAEE2C31654C681B2B */
public record class CharGenAttributesPhasePantographItemRankWidget(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */)
{
    public static CharGenAttributesPhasePantographItemRankWidget Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable);
    }
}

