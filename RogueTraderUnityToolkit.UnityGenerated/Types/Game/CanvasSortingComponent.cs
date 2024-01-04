namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CanvasSortingComponent (5 fields) AE47E9AB771A344FF0C4C05BA5D36E4D/3FF5E3C15A0C96898B19E4E228AD1E07 */
public record class CanvasSortingComponent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasSortingComponent>[] m_NestedComponents /* NeedsAlign */)
{
    public static CanvasSortingComponent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NestedComponents */
        PPtr<CanvasSortingComponent>[] _m_NestedComponents = BuiltInArray<PPtr<CanvasSortingComponent>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NestedComponents);
    }
}

