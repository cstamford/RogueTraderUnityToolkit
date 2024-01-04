namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarshipView (11 fields) F694E8D8645BA428847E31DDA6AB4858/D97E4884F656C7E49D33D3715847A3E4 */
public record class StarshipView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UnitEntityView> UnitEntityView /* NeedsAlign */,
    PPtr<ParticlesSnapMap> particleSnapMap /* None */,
    PPtr<StarshipFxHitMask> starshipFxHitMask /* None */,
    PPtr<Mesh> mesh /* None */,
    PPtr<Renderer> BaseRenderer /* None */,
    PPtr<Renderer> StarMapVisualRenderer /* None */,
    PPtr<StarshipItemSlot>[] ItemSlots /* None */)
{
    public static StarshipView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* UnitEntityView */
        PPtr<UnitEntityView> _UnitEntityView = PPtr<UnitEntityView>.Read(reader);
        PPtr<ParticlesSnapMap> _particleSnapMap = PPtr<ParticlesSnapMap>.Read(reader);
        PPtr<StarshipFxHitMask> _starshipFxHitMask = PPtr<StarshipFxHitMask>.Read(reader);
        PPtr<Mesh> _mesh = PPtr<Mesh>.Read(reader);
        PPtr<Renderer> _BaseRenderer = PPtr<Renderer>.Read(reader);
        PPtr<Renderer> _StarMapVisualRenderer = PPtr<Renderer>.Read(reader);
        PPtr<StarshipItemSlot>[] _ItemSlots = BuiltInArray<PPtr<StarshipItemSlot>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _UnitEntityView,
            _particleSnapMap,
            _starshipFxHitMask,
            _mesh,
            _BaseRenderer,
            _StarMapVisualRenderer,
            _ItemSlots);
    }
}

