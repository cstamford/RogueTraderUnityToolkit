namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTripleTextView (13 fields) A1163353F571D06FDFB67F90BE2D1BF3/85F6F16886766CED67C3FA458AB4236E */
public record class TooltipBrickTripleTextView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_LeftLabel /* NeedsAlign */,
    PPtr<GameObject> m_LeftSide /* None */,
    PPtr<TextMeshProUGUI> m_RightLabel /* None */,
    PPtr<GameObject> m_RightSide /* None */,
    PPtr<TextMeshProUGUI> m_MiddleLabel /* None */,
    PPtr<GameObject> m_MiddleSide /* None */,
    PPtr<Image> m_LeftIcon /* None */,
    PPtr<Image> m_MiddleIcon /* None */,
    PPtr<Image> m_RightIcon /* None */)
{
    public static TooltipBrickTripleTextView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LeftLabel */
        PPtr<TextMeshProUGUI> _m_LeftLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LeftSide = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RightLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_RightSide = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MiddleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_MiddleSide = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_LeftIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_MiddleIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_RightIcon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LeftLabel,
            _m_LeftSide,
            _m_RightLabel,
            _m_RightSide,
            _m_MiddleLabel,
            _m_MiddleSide,
            _m_LeftIcon,
            _m_MiddleIcon,
            _m_RightIcon);
    }
}

