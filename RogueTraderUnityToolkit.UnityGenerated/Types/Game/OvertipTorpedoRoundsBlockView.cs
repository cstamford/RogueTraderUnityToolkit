namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipTorpedoRoundsBlockView (8 fields) A5C8565CA2844133A5F51E457659CB40/FEF23C1E39B432BA0245B9B6BA14E33A */
public record class OvertipTorpedoRoundsBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_RectTransform /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    PPtr<TextMeshProUGUI> m_RoundsLeftLabel /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */)
{
    public static OvertipTorpedoRoundsBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RectTransform */
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RoundsLeftLabel = PPtr<TextMeshProUGUI>.Read(reader);
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RectTransform,
            _m_CanvasGroup,
            _m_RoundsLeftLabel,
            _m_UnitOvertipVisibilitySettings);
    }
}

