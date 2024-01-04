namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StaticMeshCombinerContainer (5 fields) 174D45D4BAC28E36D3174C67697468EB/98C2996A5A220D603B9FB5814EE918A8 */
public record class StaticMeshCombinerContainer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BoxCollider> BoxColliderContainer /* NeedsAlign */)
{
    public static StaticMeshCombinerContainer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BoxColliderContainer */
        PPtr<BoxCollider> _BoxColliderContainer = PPtr<BoxCollider>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BoxColliderContainer);
    }
}

