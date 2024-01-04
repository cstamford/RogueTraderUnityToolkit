namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InfoBodyView (9 fields) BDF5091CDAE723ED8A4A51B5A4441813/94DF646380E8A61A62D5D648CC16CE66 */
public record class InfoBodyView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_HeaderContainer /* NeedsAlign */,
    PPtr<RectTransform> m_BodyContainer /* None */,
    PPtr<RectTransform> m_FooterContainer /* None */,
    PPtr<RectTransform> m_HintContainer /* None */,
    PPtr<TooltipBricksView> m_BricksConfig /* None */)
{
    public static InfoBodyView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderContainer */
        PPtr<RectTransform> _m_HeaderContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_BodyContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_FooterContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_HintContainer = PPtr<RectTransform>.Read(reader);
        PPtr<TooltipBricksView> _m_BricksConfig = PPtr<TooltipBricksView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderContainer,
            _m_BodyContainer,
            _m_FooterContainer,
            _m_HintContainer,
            _m_BricksConfig);
    }
}

