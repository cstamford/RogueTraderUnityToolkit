namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickWidgetView (7 fields) 2ECD8D0432AC52A519CFDED4F51265BF/347924947EABA63CB896D6A4CA7964B3 */
public record class TooltipBrickWidgetView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<TooltipBricksView> m_BricksConfig /* None */,
    PPtr<TooltipBrickTextView> m_TooltipBrickTextView /* None */)
{
    public static TooltipBrickWidgetView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<TooltipBricksView> _m_BricksConfig = PPtr<TooltipBricksView>.Read(reader);
        PPtr<TooltipBrickTextView> _m_TooltipBrickTextView = PPtr<TooltipBrickTextView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_BricksConfig,
            _m_TooltipBrickTextView);
    }
}

