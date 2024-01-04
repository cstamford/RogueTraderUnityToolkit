namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ClipEventExternalReceiver (6 fields) 50F33202D313A714C816887570AE5BC2/DCC876213616540D72587832A56D9326 */
public record class ClipEventExternalReceiver(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    managedRefArrayItem[] m_Events /* NeedsAlign */,
    RefRegistry references /* None */)
{
    public static ClipEventExternalReceiver Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Events */
        managedRefArrayItem[] _m_Events = BuiltInArray<managedRefArrayItem>.Read(reader);
        RefRegistry _references = default! /* RefRegistry_4 */;
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Events,
            _references);
    }
}

