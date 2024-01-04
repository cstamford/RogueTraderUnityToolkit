namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsBuiltListElemConsoleView (10 fields) C66BAC2EEC5371670004763ABDDE0CAD/58772EFCDD01373D1F79015EC3B1F55B */
public record class ColonyProjectsBuiltListElemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<Slider> m_ProgressBar /* None */,
    PPtr<OwlcatButton> m_Button /* None */,
    ColorRGBA m_HeaderColor /* None */,
    ColonyProjectsBuiltListElemVisual m_BindedVisual /* None */,
    ColonyProjectsBuiltListElemVisual m_UnbindedVisual /* None */)
{
    public static ColonyProjectsBuiltListElemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Slider> _m_ProgressBar = PPtr<Slider>.Read(reader);
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        ColorRGBA _m_HeaderColor = ColorRGBA.Read(reader);
        ColonyProjectsBuiltListElemVisual _m_BindedVisual = ColonyProjectsBuiltListElemVisual.Read(reader);
        ColonyProjectsBuiltListElemVisual _m_UnbindedVisual = ColonyProjectsBuiltListElemVisual.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_ProgressBar,
            _m_Button,
            _m_HeaderColor,
            _m_BindedVisual,
            _m_UnbindedVisual);
    }
}

