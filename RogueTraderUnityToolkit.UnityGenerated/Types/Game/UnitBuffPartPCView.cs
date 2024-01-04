namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitBuffPartPCView (10 fields) CC519062D8861004F7F9E9ACE4B68D17/D9439D7B83AC1ACDA2B89C95A37AAF60 */
public record class UnitBuffPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BuffPCView> m_BuffView /* NeedsAlign */,
    PPtr<RectTransform> m_MainContainer /* None */,
    PPtr<RectTransform> m_AdditionalContainer /* None */,
    PPtr<OwlcatSelectable> m_AdditionalTrigger /* None */,
    int m_BuffsLimit /* None */,
    BoolReactiveProperty IsHovered /* None */)
{
    public static UnitBuffPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BuffView */
        PPtr<BuffPCView> _m_BuffView = PPtr<BuffPCView>.Read(reader);
        PPtr<RectTransform> _m_MainContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_AdditionalContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatSelectable> _m_AdditionalTrigger = PPtr<OwlcatSelectable>.Read(reader);
        int _m_BuffsLimit = reader.ReadS32();
        BoolReactiveProperty _IsHovered = BoolReactiveProperty.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BuffView,
            _m_MainContainer,
            _m_AdditionalContainer,
            _m_AdditionalTrigger,
            _m_BuffsLimit,
            _IsHovered);
    }
}

