namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DraggbleWindow (7 fields) 1B453D6D992548656D5AB79C7D218666/3516DBB50589D1186FE97CE8EA9718BF */
public record class DraggbleWindow(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector2f m_TakeDrag /* NeedsAlign */,
    PPtr<RectTransform> m_OwnRectTransform /* None */,
    PPtr<RectTransform> m_ParentRectTransform /* None */)
{
    public static DraggbleWindow Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TakeDrag */
        Vector2f _m_TakeDrag = Vector2f.Read(reader);
        PPtr<RectTransform> _m_OwnRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_ParentRectTransform = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TakeDrag,
            _m_OwnRectTransform,
            _m_ParentRectTransform);
    }
}

