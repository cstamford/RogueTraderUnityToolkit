namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectIntersectionSettings (9 fields) F85CCAD4F2C485BD6934AC1C698757C4/6CEF7249EC8E4D68AC5DF7D53779239D */
public record class ObjectIntersectionSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _allowIntersectionForDecorPaintSingleModeDrag /* NeedsAlign */,
    byte _allowIntersectionForDecorPaintBrushModeDrag /* NeedsAlign */,
    byte _allowIntersectionForPathPlacement /* NeedsAlign */,
    byte _allowIntersectionForBlockPlacement /* NeedsAlign */,
    ObjectIntersectionSettingsView _view /* NeedsAlign */)
{
    public static ObjectIntersectionSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _allowIntersectionForDecorPaintSingleModeDrag */
        byte __allowIntersectionForDecorPaintSingleModeDrag = reader.ReadU8();
        reader.AlignTo(4); /* _allowIntersectionForDecorPaintBrushModeDrag */
        byte __allowIntersectionForDecorPaintBrushModeDrag = reader.ReadU8();
        reader.AlignTo(4); /* _allowIntersectionForPathPlacement */
        byte __allowIntersectionForPathPlacement = reader.ReadU8();
        reader.AlignTo(4); /* _allowIntersectionForBlockPlacement */
        byte __allowIntersectionForBlockPlacement = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        ObjectIntersectionSettingsView __view = ObjectIntersectionSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __allowIntersectionForDecorPaintSingleModeDrag,
            __allowIntersectionForDecorPaintBrushModeDrag,
            __allowIntersectionForPathPlacement,
            __allowIntersectionForBlockPlacement,
            __view);
    }
}

