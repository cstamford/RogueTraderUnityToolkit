namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickCargoCapacityConsoleView (9 fields) BA2AD10797F9E6C4C700344F08C1C1D4/1B46F114ADAFC7740C3CC7F182847864 */
public record class TooltipBrickCargoCapacityConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TotalFillValue /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_UnusableFillValue /* None */,
    PPtr<Image> m_UsableFillBar /* None */,
    PPtr<Image> m_UnusableFillBar /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickCargoCapacityConsoleView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TotalFillValue,
            _m_UnusableFillValue,
            _m_UsableFillBar,
            _m_UnusableFillBar,
            _m_MultiButton);
    }
}

