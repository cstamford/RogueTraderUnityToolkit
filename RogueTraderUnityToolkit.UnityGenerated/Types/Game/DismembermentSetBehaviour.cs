namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DismembermentSetBehaviour (7 fields) A3F677A299248C450CF99977B77BAF15/57B489534FDACA0CE8C0C593E9F0CF0A */
public record class DismembermentSetBehaviour(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> SliceMaterial /* NeedsAlign */,
    PPtr<Mesh>[] Meshes /* None */,
    DismembermentPieceDescriptor[] Pieces /* None */)
{
    public static DismembermentSetBehaviour Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SliceMaterial */
        PPtr<Material> _SliceMaterial = PPtr<Material>.Read(reader);
        PPtr<Mesh>[] _Meshes = BuiltInArray<PPtr<Mesh>>.Read(reader);
        DismembermentPieceDescriptor[] _Pieces = BuiltInArray<DismembermentPieceDescriptor>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SliceMaterial,
            _Meshes,
            _Pieces);
    }
}

