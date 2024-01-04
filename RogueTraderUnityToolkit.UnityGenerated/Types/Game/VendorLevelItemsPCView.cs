namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorLevelItemsPCView (9 fields) CEFD3DAF48A43B97512F6F7BE541509C/42C835C86FC3199AFA858DF414D5B4EA */
public record class VendorLevelItemsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VendorSlotView> m_VendorSlotView /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_LockButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<TextMeshProUGUI> m_LevelValue /* None */,
    PPtr<Image> m_FillAmount /* None */)
{
    public static VendorLevelItemsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VendorSlotView */
        PPtr<VendorSlotView> _m_VendorSlotView = PPtr<VendorSlotView>.Read(reader);
        PPtr<OwlcatMultiButton> _m_LockButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LevelValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_FillAmount = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VendorSlotView,
            _m_LockButton,
            _m_WidgetList,
            _m_LevelValue,
            _m_FillAmount);
    }
}

