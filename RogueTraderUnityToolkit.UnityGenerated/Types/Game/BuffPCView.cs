namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BuffPCView (8 fields) 2C441A934B4C1982A1AE3DFC61723182/64B385AADFAA3CA7F61102EB7C0DB0B1 */
public record class BuffPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Rank /* None */,
    PPtr<GameObject> m_NonStackNotification /* None */,
    PPtr<OwlcatSelectable> m_Selectable /* None */)
{
    public static BuffPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Rank = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_NonStackNotification = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatSelectable> _m_Selectable = PPtr<OwlcatSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Rank,
            _m_NonStackNotification,
            _m_Selectable);
    }
}

