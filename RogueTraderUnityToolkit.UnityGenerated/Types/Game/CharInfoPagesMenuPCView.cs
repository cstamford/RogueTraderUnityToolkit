namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoPagesMenuPCView (9 fields) E28B6D811EB55D2DFCDBD78ACB6D7D57/175D3F51531FCF8AB18CA7711204B147 */
public record class CharInfoPagesMenuPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharInfoPagesMenuEntityPCView> m_MenuItemViewPrefab /* None */,
    PPtr<Transform> m_Lens /* None */,
    float m_LensInitialPositionX /* None */,
    float m_LensAnimationDuration /* None */)
{
    public static CharInfoPagesMenuPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoPagesMenuEntityPCView> _m_MenuItemViewPrefab = PPtr<CharInfoPagesMenuEntityPCView>.Read(reader);
        PPtr<Transform> _m_Lens = PPtr<Transform>.Read(reader);
        float _m_LensInitialPositionX = reader.ReadF32();
        float _m_LensAnimationDuration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_MenuItemViewPrefab,
            _m_Lens,
            _m_LensInitialPositionX,
            _m_LensAnimationDuration);
    }
}

