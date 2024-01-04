namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TurnVirtualListController (11 fields) 812E76072D35609B680ABCFBFE5B45E2/DED021DDE09017F69FE4E69B49C98583 */
public record class TurnVirtualListController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_VirtualDirection /* NeedsAlign */,
    RectOffset Padding /* None */,
    Vector2f Spacing /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    float m_AutoScrollDelta /* None */,
    int ElementsInRow /* None */,
    float m_AnimationTime /* None */)
{
    public static TurnVirtualListController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VirtualDirection */
        int _m_VirtualDirection = reader.ReadS32();
        RectOffset _Padding = RectOffset.Read(reader);
        Vector2f _Spacing = Vector2f.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        float _m_AutoScrollDelta = reader.ReadF32();
        int _ElementsInRow = reader.ReadS32();
        float _m_AnimationTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VirtualDirection,
            _Padding,
            _Spacing,
            _m_ScrollRect,
            _m_AutoScrollDelta,
            _ElementsInRow,
            _m_AnimationTime);
    }
}

