namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimationClipEventTrack (6 fields) 2EFA573F1CF4C223C160C40BA08E1169/34C92CE4C29FB31B4856ED7DC72D6C29 */
public record class AnimationClipEventTrack(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    managedRefArrayItem[] m_Events /* NeedsAlign */,
    RefRegistry references /* None */)
{
    public static AnimationClipEventTrack Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Events */
        managedRefArrayItem[] _m_Events = BuiltInArray<managedRefArrayItem>.Read(reader);
        RefRegistry _references = default! /* RefRegistry_1 */;
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Events,
            _references);
    }
}

