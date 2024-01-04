namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorCargoSlotPCView (14 fields) 915E6652F8610842509EB6E9809CDC94/01B7C36AB4FF5AB21B81E6AEB5A138B8 */
public record class VendorCargoSlotPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<Image> m_TypeIcon /* None */,
    PPtr<TextMeshProUGUI> m_TypeLabel /* None */,
    PPtr<TextMeshProUGUI> m_FillValue /* None */,
    PPtr<RectTransform> m_CubeInteractable /* None */,
    PPtr<OwlcatButton> m_CubeInteractableButton /* None */,
    PPtr<Image> m_CubeFrame /* None */,
    PPtr<Image> m_CubeIcon /* None */,
    PPtr<Image> m_NewStateIcon /* None */,
    PPtr<TextMeshProUGUI> m_SelectText /* None */)
{
    public static VendorCargoSlotPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_TypeIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TypeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_CubeInteractable = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatButton> _m_CubeInteractableButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<Image> _m_CubeFrame = PPtr<Image>.Read(reader);
        PPtr<Image> _m_CubeIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_NewStateIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SelectText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_TypeIcon,
            _m_TypeLabel,
            _m_FillValue,
            _m_CubeInteractable,
            _m_CubeInteractableButton,
            _m_CubeFrame,
            _m_CubeIcon,
            _m_NewStateIcon,
            _m_SelectText);
    }
}

