namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InfoSectionView (7 fields) AE1A874639F7E612ADFE3730544606BF/030A72F0A9937104419586281C13A38C */
public record class InfoSectionView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<InfoBodyView> m_InfoBodyView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */)
{
    public static InfoSectionView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<InfoBodyView> _m_InfoBodyView = PPtr<InfoBodyView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_InfoBodyView,
            _m_ScrollRectExtended);
    }
}

