namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PageNavigationConsole (9 fields) 5CF08766ECAC95FB4B5B832CAAA931F7/05441E99D844602B1783597752D0D54A */
public record class PageNavigationConsole(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_HasPoints /* NeedsAlign */,
    PPtr<PageNavigationPoint> m_PointPrefab /* NeedsAlign */,
    PPtr<Transform> m_PointsContainer /* None */,
    PPtr<ConsoleHint> m_PreviousHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */)
{
    public static PageNavigationConsole Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HasPoints */
        byte _m_HasPoints = reader.ReadU8();
        reader.AlignTo(4); /* m_PointPrefab */
        PPtr<PageNavigationPoint> _m_PointPrefab = PPtr<PageNavigationPoint>.Read(reader);
        PPtr<Transform> _m_PointsContainer = PPtr<Transform>.Read(reader);
        PPtr<ConsoleHint> _m_PreviousHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HasPoints,
            _m_PointPrefab,
            _m_PointsContainer,
            _m_PreviousHint,
            _m_NextHint);
    }
}

