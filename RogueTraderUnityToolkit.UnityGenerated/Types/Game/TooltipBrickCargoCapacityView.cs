namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickCargoCapacityView (8 fields) CFE452F066C1B917EE913F48313D482D/7518868148A603F1A85B7C40D1DA4B9F */
public record class TooltipBrickCargoCapacityView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TotalFillValue /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_UnusableFillValue /* None */,
    PPtr<Image> m_UsableFillBar /* None */,
    PPtr<Image> m_UnusableFillBar /* None */)
{
    public static TooltipBrickCargoCapacityView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TotalFillValue */
        PPtr<TextMeshProUGUI> _m_TotalFillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UnusableFillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_UsableFillBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_UnusableFillBar = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TotalFillValue,
            _m_UnusableFillValue,
            _m_UsableFillBar,
            _m_UnusableFillBar);
    }
}

