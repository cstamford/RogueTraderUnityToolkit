namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickPlanetResourceImageView (6 fields) C32313D3AB64213AF74E6677E8383203/55F5743EB0C8AA53AEB6D6E685241EA1 */
public record class TooltipBrickPlanetResourceImageView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_ResourceImage /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ResourceName /* None */)
{
    public static TooltipBrickPlanetResourceImageView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ResourceImage */
        PPtr<Image> _m_ResourceImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResourceName = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ResourceImage,
            _m_ResourceName);
    }
}

