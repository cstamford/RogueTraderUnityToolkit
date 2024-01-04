namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapSpaceResourceView (14 fields) C3459DDCA70670D330462AD59BFE6040/72CD37DE5D32CDCA07DB9B625E40F623 */
public record class SystemMapSpaceResourceView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Count /* None */,
    PPtr<TextMeshProUGUI> m_CountAdditional /* None */,
    PPtr<Image> m_CountAdditionalArrowUp /* None */,
    PPtr<Image> m_CountAdditionalArrowDown /* None */,
    PPtr<Image> m_BackgroundImage /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */,
    NegativeEffects m_NegativeEffects /* None */,
    PPtr<GameObject>[] m_SeparatorPins /* None */,
    PPtr<OwlcatSelectable> m_Selectable /* None */)
{
    public static SystemMapSpaceResourceView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Count = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CountAdditional = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CountAdditionalArrowUp = PPtr<Image>.Read(reader);
        PPtr<Image> _m_CountAdditionalArrowDown = PPtr<Image>.Read(reader);
        PPtr<Image> _m_BackgroundImage = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        NegativeEffects _m_NegativeEffects = NegativeEffects.Read(reader);
        PPtr<GameObject>[] _m_SeparatorPins = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<OwlcatSelectable> _m_Selectable = PPtr<OwlcatSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Count,
            _m_CountAdditional,
            _m_CountAdditionalArrowUp,
            _m_CountAdditionalArrowDown,
            _m_BackgroundImage,
            _m_TooltipPlace,
            _m_NegativeEffects,
            _m_SeparatorPins,
            _m_Selectable);
    }
}

