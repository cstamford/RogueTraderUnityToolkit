namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DecorPaintObjectPlacementBrushDatabase (6 fields) EB93C143F745506E720FDCC982073DB5/73FA4B72E51FB7E4A95815BD36E8F85E */
public record class DecorPaintObjectPlacementBrushDatabase(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    DecorPaintObjectPlacementBrushCollection _brushes /* NeedsAlign */,
    DecorPaintObjectPlacementBrushDatabaseView _view /* None */)
{
    public static DecorPaintObjectPlacementBrushDatabase Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _brushes */
        DecorPaintObjectPlacementBrushCollection __brushes = DecorPaintObjectPlacementBrushCollection.Read(reader);
        DecorPaintObjectPlacementBrushDatabaseView __view = DecorPaintObjectPlacementBrushDatabaseView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __brushes,
            __view);
    }
}

