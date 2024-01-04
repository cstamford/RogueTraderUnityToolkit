namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DecorPaintObjectPlacement (8 fields) 4946DFC0325A618E1B875F0A5715E515/13808F3F9C65D03E9D11A3EAB8E345A4 */
public record class DecorPaintObjectPlacement(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SingleModeDecorPaintStroke _singleModeDecorPaintStroke /* NeedsAlign */,
    BrushModeDecorPaintStroke _brushModeDecorPaintStroke /* NeedsAlign */,
    ObjectMask _decorPaintMask /* NeedsAlign */,
    byte _wasInitialized /* NeedsAlign */)
{
    public static DecorPaintObjectPlacement Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _singleModeDecorPaintStroke */
        SingleModeDecorPaintStroke __singleModeDecorPaintStroke = SingleModeDecorPaintStroke.Read(reader);
        reader.AlignTo(4); /* _brushModeDecorPaintStroke */
        BrushModeDecorPaintStroke __brushModeDecorPaintStroke = BrushModeDecorPaintStroke.Read(reader);
        reader.AlignTo(4); /* _decorPaintMask */
        ObjectMask __decorPaintMask = ObjectMask.Read(reader);
        reader.AlignTo(4); /* _wasInitialized */
        byte __wasInitialized = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __singleModeDecorPaintStroke,
            __brushModeDecorPaintStroke,
            __decorPaintMask,
            __wasInitialized);
    }
}

