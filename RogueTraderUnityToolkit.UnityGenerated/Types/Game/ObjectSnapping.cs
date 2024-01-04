namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSnapping (9 fields) EA951167E42617A339329E6B9A0D1F80/99390F89ABA243F1141D4ACA16CD5690 */
public record class ObjectSnapping(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectSnapSettings> _settings /* NeedsAlign */,
    ObjectMask _objectSnapMask /* None */,
    PPtr<XZGrid> _xzSnapGrid /* NeedsAlign */,
    SnapSurface _objectSnapSurface /* None */,
    byte _wasInitialized /* NeedsAlign */)
{
    public static ObjectSnapping Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _settings */
        PPtr<ObjectSnapSettings> __settings = PPtr<ObjectSnapSettings>.Read(reader);
        ObjectMask __objectSnapMask = ObjectMask.Read(reader);
        reader.AlignTo(4); /* _xzSnapGrid */
        PPtr<XZGrid> __xzSnapGrid = PPtr<XZGrid>.Read(reader);
        SnapSurface __objectSnapSurface = SnapSurface.Read(reader);
        reader.AlignTo(4); /* _wasInitialized */
        byte __wasInitialized = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __settings,
            __objectSnapMask,
            __xzSnapGrid,
            __objectSnapSurface,
            __wasInitialized);
    }
}

