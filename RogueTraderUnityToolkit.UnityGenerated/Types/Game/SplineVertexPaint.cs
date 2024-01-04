namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SplineVertexPaint (12 fields) CC03E388AC76ACA9DC7D214554D28B04/7A61DEABA6B26688CDB12E459FCA1A17 */
public record class SplineVertexPaint(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte InvertMode /* NeedsAlign */,
    ListItems[] PointsList /* NeedsAlign */,
    ListOriginalMeshes[] OriginalMeshesList /* None */,
    ListMeshes[] MeshesList /* None */,
    PPtr<MeshFilter>[] SplinesList /* None */,
    byte SearchPointsParent /* None */,
    byte ShowDebugOptions /* NeedsAlign */,
    byte CollectMeshes /* NeedsAlign */)
{
    public static SplineVertexPaint Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* InvertMode */
        byte _InvertMode = reader.ReadU8();
        reader.AlignTo(4); /* PointsList */
        ListItems[] _PointsList = BuiltInArray<ListItems>.Read(reader);
        ListOriginalMeshes[] _OriginalMeshesList = BuiltInArray<ListOriginalMeshes>.Read(reader);
        ListMeshes[] _MeshesList = BuiltInArray<ListMeshes>.Read(reader);
        PPtr<MeshFilter>[] _SplinesList = BuiltInArray<PPtr<MeshFilter>>.Read(reader);
        byte _SearchPointsParent = reader.ReadU8();
        reader.AlignTo(4); /* ShowDebugOptions */
        byte _ShowDebugOptions = reader.ReadU8();
        reader.AlignTo(4); /* CollectMeshes */
        byte _CollectMeshes = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _InvertMode,
            _PointsList,
            _OriginalMeshesList,
            _MeshesList,
            _SplinesList,
            _SearchPointsParent,
            _ShowDebugOptions,
            _CollectMeshes);
    }
}

