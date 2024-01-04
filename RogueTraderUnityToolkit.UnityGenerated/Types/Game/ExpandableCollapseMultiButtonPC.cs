namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExpandableCollapseMultiButtonPC (11 fields) 3F47CA069A909B2EB7D9E39E1F707437/816B8162FADC945B4D30EFD43F10BC56 */
public record class ExpandableCollapseMultiButtonPC(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* NeedsAlign */,
    PPtr<Transform> m_CollapseImage /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    byte m_IsOn /* None */,
    byte m_IsSwitchMultiButtonLayer /* NeedsAlign */,
    byte LayerIsOnAlways /* NeedsAlign */,
    byte LayerIsOffAlways /* NeedsAlign */)
{
    public static ExpandableCollapseMultiButtonPC Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MultiButton */
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Transform> _m_CollapseImage = PPtr<Transform>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        byte _m_IsOn = reader.ReadU8();
        reader.AlignTo(4); /* m_IsSwitchMultiButtonLayer */
        byte _m_IsSwitchMultiButtonLayer = reader.ReadU8();
        reader.AlignTo(4); /* LayerIsOnAlways */
        byte _LayerIsOnAlways = reader.ReadU8();
        reader.AlignTo(4); /* LayerIsOffAlways */
        byte _LayerIsOffAlways = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MultiButton,
            _m_CollapseImage,
            _m_FadeAnimator,
            _m_IsOn,
            _m_IsSwitchMultiButtonLayer,
            _LayerIsOnAlways,
            _LayerIsOffAlways);
    }
}

