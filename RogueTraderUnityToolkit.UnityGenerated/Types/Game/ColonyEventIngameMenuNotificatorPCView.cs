namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyEventIngameMenuNotificatorPCView (6 fields) 2F7DFE43B4F880011180563EB77C370B/4A08E82B1FCA108D3CA556B1E8C58B40 */
public record class ColonyEventIngameMenuNotificatorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */)
{
    public static ColonyEventIngameMenuNotificatorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_Icon);
    }
}

