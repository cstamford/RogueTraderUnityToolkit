namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipNameAndPortraitPCView (12 fields) 9C7013A98B43FC160E9B4547B679D646/E29906F6F56F557C183AE79CCF2363BE */
public record class ShipNameAndPortraitPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<ScrambledTMP> m_StarShipName /* None */,
    PPtr<Image> m_StarShipImage /* None */,
    PPtr<TextMeshProUGUI> m_InformationLabel /* None */,
    PPtr<TextMeshProUGUI> m_StarShipDescription /* None */,
    PPtr<FadeAnimator> m_ShipPartAnimator /* None */,
    PPtr<OwlcatButton> m_NextButton /* None */,
    PPtr<OwlcatButton> m_PrevButton /* None */)
{
    public static ShipNameAndPortraitPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ScrambledTMP> _m_StarShipName = PPtr<ScrambledTMP>.Read(reader);
        PPtr<Image> _m_StarShipImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InformationLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StarShipDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_ShipPartAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OwlcatButton> _m_NextButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_PrevButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_StarShipName,
            _m_StarShipImage,
            _m_InformationLabel,
            _m_StarShipDescription,
            _m_ShipPartAnimator,
            _m_NextButton,
            _m_PrevButton);
    }
}

