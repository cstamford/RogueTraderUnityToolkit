namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FlexibleLensSelectorView (11 fields) A642BE816B07199E21DC8B2689C68686/6DCB5B9A1F01D224302BE545F0608A94 */
public record class FlexibleLensSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton>[] m_Buttons /* NeedsAlign */,
    PPtr<OwlcatButton>[] m_OwlcatButtons /* None */,
    PPtr<RectTransform> m_Lens /* None */,
    float m_LensSwitchAnimationDuration /* None */,
    float m_Offset /* None */,
    PPtr<OwlcatButton> m_FakeButton /* None */,
    PPtr<OwlcatMultiButton> m_FakeSelectingButton /* None */)
{
    public static FlexibleLensSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Buttons */
        PPtr<OwlcatMultiButton>[] _m_Buttons = BuiltInArray<PPtr<OwlcatMultiButton>>.Read(reader);
        PPtr<OwlcatButton>[] _m_OwlcatButtons = BuiltInArray<PPtr<OwlcatButton>>.Read(reader);
        PPtr<RectTransform> _m_Lens = PPtr<RectTransform>.Read(reader);
        float _m_LensSwitchAnimationDuration = reader.ReadF32();
        float _m_Offset = reader.ReadF32();
        PPtr<OwlcatButton> _m_FakeButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FakeSelectingButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Buttons,
            _m_OwlcatButtons,
            _m_Lens,
            _m_LensSwitchAnimationDuration,
            _m_Offset,
            _m_FakeButton,
            _m_FakeSelectingButton);
    }
}

