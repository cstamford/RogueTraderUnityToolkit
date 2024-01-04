namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DOTweenVisualManager (7 fields) E594CA45A40C65741FB194EA93BF9AA5/8996B0D684FC4D2DFB5735777FC15584 */
public record class DOTweenVisualManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int preset /* NeedsAlign */,
    int onEnableBehaviour /* None */,
    int onDisableBehaviour /* None */)
{
    public static DOTweenVisualManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* preset */
        int _preset = reader.ReadS32();
        int _onEnableBehaviour = reader.ReadS32();
        int _onDisableBehaviour = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _preset,
            _onEnableBehaviour,
            _onDisableBehaviour);
    }
}

