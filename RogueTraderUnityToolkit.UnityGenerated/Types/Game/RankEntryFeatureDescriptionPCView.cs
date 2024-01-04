namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryFeatureDescriptionPCView (9 fields) A114442F4AD6B28F1CB107461A0C422C/32E07AFFFEFD752E1D108DEB588650ED */
public record class RankEntryFeatureDescriptionPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_HeaderBlock /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    byte m_ButtonsSetFromParent /* None */,
    PPtr<CareerButtonsBlock> m_ButtonsBlock /* NeedsAlign */,
    PPtr<InfoSectionView> m_InfoView /* None */)
{
    public static RankEntryFeatureDescriptionPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderBlock */
        PPtr<GameObject> _m_HeaderBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        byte _m_ButtonsSetFromParent = reader.ReadU8();
        reader.AlignTo(4); /* m_ButtonsBlock */
        PPtr<CareerButtonsBlock> _m_ButtonsBlock = PPtr<CareerButtonsBlock>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderBlock,
            _m_HeaderLabel,
            _m_ButtonsSetFromParent,
            _m_ButtonsBlock,
            _m_InfoView);
    }
}

