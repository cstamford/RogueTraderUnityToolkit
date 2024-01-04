namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoRewardSlotView (8 fields) 25BF807B8B329289966C7BF66B839682/E7A7447354928C1AE5450ECEDA6D99B7 */
public record class CargoRewardSlotView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<Image> m_TypeIcon /* None */,
    PPtr<TextMeshProUGUI> m_FillValue /* None */,
    PPtr<TextMeshProUGUI> m_Count /* None */)
{
    public static CargoRewardSlotView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_TypeIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Count = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_TypeIcon,
            _m_FillValue,
            _m_Count);
    }
}

