namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitHealthPartTextPCView (7 fields) 7E24AC2CE6E31C86AE86A7FDC30845D2/B295A445C54310C29E1DA6943E481257 */
public record class UnitHealthPartTextPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    ColorRGBA m_DeathColor /* None */,
    ColorRGBA m_NormalColor /* None */)
{
    public static UnitHealthPartTextPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_DeathColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_DeathColor,
            _m_NormalColor);
    }
}

