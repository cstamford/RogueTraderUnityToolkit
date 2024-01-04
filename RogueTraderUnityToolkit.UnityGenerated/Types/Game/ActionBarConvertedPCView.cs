namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ActionBarConvertedPCView (6 fields) D5DCD0A2876A90256C63541F13861165/1DE6EF3AD35824B2E1897A2BAAEB8EC3 */
public record class ActionBarConvertedPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ActionBarBaseSlotView> m_SlotView /* NeedsAlign */,
    PPtr<RectTransform> m_Container /* None */)
{
    public static ActionBarConvertedPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SlotView */
        PPtr<ActionBarBaseSlotView> _m_SlotView = PPtr<ActionBarBaseSlotView>.Read(reader);
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SlotView,
            _m_Container);
    }
}

