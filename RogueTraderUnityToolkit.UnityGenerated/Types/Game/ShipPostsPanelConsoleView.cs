namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipPostsPanelConsoleView (9 fields) 56B82F478F6337B544941AA999F2555B/2FD7FB72CBCD0ABD0451D1D474C06689 */
public record class ShipPostsPanelConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_TooltipPlace /* NeedsAlign */,
    PPtr<ShipPostConsoleView>[] m_ShipPostViews /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<MonoBehaviour>[] m_AnimatorObjects /* None */,
    PPtr<Image>[] m_PostGlitchImages /* None */)
{
    public static ShipPostsPanelConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipPlace */
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<ShipPostConsoleView>[] _m_ShipPostViews = BuiltInArray<PPtr<ShipPostConsoleView>>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<MonoBehaviour>[] _m_AnimatorObjects = BuiltInArray<PPtr<MonoBehaviour>>.Read(reader);
        PPtr<Image>[] _m_PostGlitchImages = BuiltInArray<PPtr<Image>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipPlace,
            _m_ShipPostViews,
            _m_HintsWidget,
            _m_AnimatorObjects,
            _m_PostGlitchImages);
    }
}

