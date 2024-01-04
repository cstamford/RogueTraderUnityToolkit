namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $IngameMenuNewPCView (14 fields) 985D90C82C19596A0E4F0807D9D7B864/F894F639C6D082D37D312DE6F52D2140 */
public record class IngameMenuNewPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_Inventory /* None */,
    PPtr<OwlcatMultiButton> m_Character /* None */,
    PPtr<OwlcatMultiButton> m_Journal /* None */,
    PPtr<OwlcatMultiButton> m_Map /* None */,
    PPtr<OwlcatMultiButton> m_Encyclopedia /* None */,
    PPtr<OwlcatMultiButton> m_ShipCustomization /* None */,
    PPtr<OwlcatMultiButton> m_ColonyManagement /* None */,
    PPtr<OwlcatMultiButton> m_CargoManagement /* None */,
    PPtr<UIHighlighter> m_UIHighlighter /* None */)
{
    public static IngameMenuNewPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Inventory = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Character = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Journal = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Map = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Encyclopedia = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ShipCustomization = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ColonyManagement = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CargoManagement = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<UIHighlighter> _m_UIHighlighter = PPtr<UIHighlighter>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_Inventory,
            _m_Character,
            _m_Journal,
            _m_Map,
            _m_Encyclopedia,
            _m_ShipCustomization,
            _m_ColonyManagement,
            _m_CargoManagement,
            _m_UIHighlighter);
    }
}

