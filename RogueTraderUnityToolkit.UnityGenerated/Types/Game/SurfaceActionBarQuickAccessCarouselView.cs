namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarQuickAccessCarouselView (10 fields) 1097EAD7C915D17DF1534F1E69A081D3/37A6825C19BCCAB1D853BAEE2ACF9FFE */
public record class SurfaceActionBarQuickAccessCarouselView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_ActiveButton /* NeedsAlign */,
    PPtr<ActionBarBaseSlotView> m_MainSlotView /* None */,
    PPtr<ActionBarBaseSlotView> m_NextSlotView /* None */,
    PPtr<ActionBarBaseSlotView> m_PreviousSlotView /* None */,
    BoolReactiveProperty IsActive /* None */,
    BoolReactiveProperty HasSlots /* NeedsAlign */)
{
    public static SurfaceActionBarQuickAccessCarouselView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ActiveButton */
        PPtr<OwlcatMultiSelectable> _m_ActiveButton = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<ActionBarBaseSlotView> _m_MainSlotView = PPtr<ActionBarBaseSlotView>.Read(reader);
        PPtr<ActionBarBaseSlotView> _m_NextSlotView = PPtr<ActionBarBaseSlotView>.Read(reader);
        PPtr<ActionBarBaseSlotView> _m_PreviousSlotView = PPtr<ActionBarBaseSlotView>.Read(reader);
        BoolReactiveProperty _IsActive = BoolReactiveProperty.Read(reader);
        reader.AlignTo(4); /* HasSlots */
        BoolReactiveProperty _HasSlots = BoolReactiveProperty.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ActiveButton,
            _m_MainSlotView,
            _m_NextSlotView,
            _m_PreviousSlotView,
            _IsActive,
            _HasSlots);
    }
}

