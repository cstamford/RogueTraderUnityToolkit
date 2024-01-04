namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SelectFrameController (6 fields) 5F2A6196411C73F75D7A5F4589E0AE96/AACF408DEA341033AFDAD358E37A9ABF */
public record class SelectFrameController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_CanvasRect /* NeedsAlign */,
    PPtr<RectTransform> m_SelectorFrameRect /* None */)
{
    public static SelectFrameController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasRect */
        PPtr<RectTransform> _m_CanvasRect = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_SelectorFrameRect = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasRect,
            _m_SelectorFrameRect);
    }
}

