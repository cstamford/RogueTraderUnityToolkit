namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AstarPath (29 fields) 4780BEEA756BBD0474CB893FE4FCEB0E/938E5D10BBCA967D91B3A9AC305B7218 */
public record class AstarPath(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int version /* NeedsAlign */,
    AstarData data /* None */,
    byte showNavGraphs /* NeedsAlign */,
    byte showUnwalkableNodes /* NeedsAlign */,
    int debugMode /* NeedsAlign */,
    float debugFloor /* None */,
    float debugRoof /* None */,
    byte manualDebugFloorRoof /* None */,
    byte showSearchTree /* NeedsAlign */,
    float unwalkableNodeDebugSize /* NeedsAlign */,
    float maxNearestNodeDistance /* None */,
    byte scanOnStartup /* None */,
    byte fullGetNearestSearch /* NeedsAlign */,
    byte prioritizeGraphs /* NeedsAlign */,
    float prioritizeGraphsLimit /* NeedsAlign */,
    AstarColor colorSettings /* None */,
    AsciiString[] tagNames /* NeedsAlign */,
    int heuristic /* NeedsAlign */,
    float heuristicScale /* None */,
    int threadCount /* None */,
    float maxFrameTime /* None */,
    byte batchGraphUpdates /* None */,
    float graphUpdateBatchingInterval /* NeedsAlign */,
    EuclideanEmbedding euclideanEmbedding /* None */,
    byte showGraphs /* None */)
{
    public static AstarPath Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* version */
        int _version = reader.ReadS32();
        AstarData _data = AstarData.Read(reader);
        reader.AlignTo(4); /* showNavGraphs */
        byte _showNavGraphs = reader.ReadU8();
        reader.AlignTo(4); /* showUnwalkableNodes */
        byte _showUnwalkableNodes = reader.ReadU8();
        reader.AlignTo(4); /* debugMode */
        int _debugMode = reader.ReadS32();
        float _debugFloor = reader.ReadF32();
        float _debugRoof = reader.ReadF32();
        byte _manualDebugFloorRoof = reader.ReadU8();
        reader.AlignTo(4); /* showSearchTree */
        byte _showSearchTree = reader.ReadU8();
        reader.AlignTo(4); /* unwalkableNodeDebugSize */
        float _unwalkableNodeDebugSize = reader.ReadF32();
        float _maxNearestNodeDistance = reader.ReadF32();
        byte _scanOnStartup = reader.ReadU8();
        reader.AlignTo(4); /* fullGetNearestSearch */
        byte _fullGetNearestSearch = reader.ReadU8();
        reader.AlignTo(4); /* prioritizeGraphs */
        byte _prioritizeGraphs = reader.ReadU8();
        reader.AlignTo(4); /* prioritizeGraphsLimit */
        float _prioritizeGraphsLimit = reader.ReadF32();
        AstarColor _colorSettings = AstarColor.Read(reader);
        reader.AlignTo(4); /* tagNames */
        AsciiString[] _tagNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* heuristic */
        int _heuristic = reader.ReadS32();
        float _heuristicScale = reader.ReadF32();
        int _threadCount = reader.ReadS32();
        float _maxFrameTime = reader.ReadF32();
        byte _batchGraphUpdates = reader.ReadU8();
        reader.AlignTo(4); /* graphUpdateBatchingInterval */
        float _graphUpdateBatchingInterval = reader.ReadF32();
        EuclideanEmbedding _euclideanEmbedding = EuclideanEmbedding.Read(reader);
        byte _showGraphs = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _version,
            _data,
            _showNavGraphs,
            _showUnwalkableNodes,
            _debugMode,
            _debugFloor,
            _debugRoof,
            _manualDebugFloorRoof,
            _showSearchTree,
            _unwalkableNodeDebugSize,
            _maxNearestNodeDistance,
            _scanOnStartup,
            _fullGetNearestSearch,
            _prioritizeGraphs,
            _prioritizeGraphsLimit,
            _colorSettings,
            _tagNames,
            _heuristic,
            _heuristicScale,
            _threadCount,
            _maxFrameTime,
            _batchGraphUpdates,
            _graphUpdateBatchingInterval,
            _euclideanEmbedding,
            _showGraphs);
    }
}

