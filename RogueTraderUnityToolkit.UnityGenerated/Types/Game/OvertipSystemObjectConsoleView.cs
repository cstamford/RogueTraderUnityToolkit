namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipSystemObjectConsoleView (13 fields) 93CD0AB32C1DC2369D47F00F8CD6DBFA/3806F18C10886E5FA2C4814A30B215EB */
public record class OvertipSystemObjectConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_SystemObjectButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_SystemObjectName /* None */,
    PPtr<RectTransform> m_StateIconCanvas /* None */,
    PPtr<Image> m_PoiStateIcon /* None */,
    PPtr<RectTransform> m_CanvasRectTransform /* None */,
    PPtr<Image> m_NoiseAroundImage /* None */,
    PPtr<Sprite>[] m_RandomNoises /* None */,
    PPtr<TextMeshProUGUI> m_TopInformation /* None */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */)
{
    public static OvertipSystemObjectConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemObjectButton */
        PPtr<OwlcatButton> _m_SystemObjectButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SystemObjectName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_StateIconCanvas = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_PoiStateIcon = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_CanvasRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_NoiseAroundImage = PPtr<Image>.Read(reader);
        PPtr<Sprite>[] _m_RandomNoises = BuiltInArray<PPtr<Sprite>>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TopInformation = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemObjectButton,
            _m_SystemObjectName,
            _m_StateIconCanvas,
            _m_PoiStateIcon,
            _m_CanvasRectTransform,
            _m_NoiseAroundImage,
            _m_RandomNoises,
            _m_TopInformation,
            _m_TargetPingEntity);
    }
}

