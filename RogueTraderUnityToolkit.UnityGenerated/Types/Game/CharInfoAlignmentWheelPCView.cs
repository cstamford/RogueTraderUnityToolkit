namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoAlignmentWheelPCView (15 fields) 091CA63C6EFBD301CE2194C51B08D637/6319B2ACA2AA04F633A932E61CACE7BB */
public record class CharInfoAlignmentWheelPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<ConvictionBarBaseView> m_ConvictionBar /* None */,
    PPtr<CharInfoSoulMarkSectorView> m_FaithSectorView /* None */,
    PPtr<CharInfoSoulMarkSectorView> m_CorruptionSectorView /* None */,
    PPtr<CharInfoSoulMarkSectorView> m_HopeSectorView /* None */,
    PPtr<GameObject> m_MainCharGroup /* None */,
    PPtr<GameObject> m_CompanionGroup /* None */,
    ColorRGBA m_FaithColor /* None */,
    ColorRGBA m_CorruptionColor /* None */,
    ColorRGBA m_HopeColor /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static CharInfoAlignmentWheelPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ConvictionBarBaseView> _m_ConvictionBar = PPtr<ConvictionBarBaseView>.Read(reader);
        PPtr<CharInfoSoulMarkSectorView> _m_FaithSectorView = PPtr<CharInfoSoulMarkSectorView>.Read(reader);
        PPtr<CharInfoSoulMarkSectorView> _m_CorruptionSectorView = PPtr<CharInfoSoulMarkSectorView>.Read(reader);
        PPtr<CharInfoSoulMarkSectorView> _m_HopeSectorView = PPtr<CharInfoSoulMarkSectorView>.Read(reader);
        PPtr<GameObject> _m_MainCharGroup = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompanionGroup = PPtr<GameObject>.Read(reader);
        ColorRGBA _m_FaithColor = ColorRGBA.Read(reader);
        ColorRGBA _m_CorruptionColor = ColorRGBA.Read(reader);
        ColorRGBA _m_HopeColor = ColorRGBA.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_ConvictionBar,
            _m_FaithSectorView,
            _m_CorruptionSectorView,
            _m_HopeSectorView,
            _m_MainCharGroup,
            _m_CompanionGroup,
            _m_FaithColor,
            _m_CorruptionColor,
            _m_HopeColor,
            _m_NavigationParameters);
    }
}

