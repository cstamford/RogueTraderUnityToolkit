namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $PreloadData (4 fields) B5957185FBF85C93CB980B7CAC7E71A9 */
public record class PreloadData(
    AsciiString m_Name /* None */,
    PPtr<Object>[] m_Assets /* NeedsAlign */,
    AsciiString[] m_Dependencies /* NeedsAlign */,
    bool m_ExplicitDataLayout /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3046470021, 4227357843, 3415739260, 2893967785);
    public static PreloadData Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Assets */
        PPtr<Object>[] _m_Assets = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        AsciiString[] _m_Dependencies = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_ExplicitDataLayout */
        bool _m_ExplicitDataLayout = reader.ReadBool();
        
        return new(_m_Name,
            _m_Assets,
            _m_Dependencies,
            _m_ExplicitDataLayout);
    }
}

