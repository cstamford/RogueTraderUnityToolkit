namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $MonoScript (6 fields) CA1AF11EF54057482C227089E9D728E9 */
public record class MonoScript(
    AsciiString m_Name /* None */,
    int m_ExecutionOrder /* NeedsAlign */,
    Hash128 m_PropertiesHash /* None */,
    AsciiString m_ClassName /* None */,
    AsciiString m_Namespace /* NeedsAlign */,
    AsciiString m_AssemblyName /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3390763294, 4114634568, 740454537, 3923192041);
    public static MonoScript Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExecutionOrder */
        int _m_ExecutionOrder = reader.ReadS32();
        Hash128 _m_PropertiesHash = Hash128.Read(reader);
        AsciiString _m_ClassName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Namespace */
        AsciiString _m_Namespace = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AssemblyName */
        AsciiString _m_AssemblyName = BuiltInString.Read(reader);
        
        return new(_m_Name,
            _m_ExecutionOrder,
            _m_PropertiesHash,
            _m_ClassName,
            _m_Namespace,
            _m_AssemblyName);
    }
}

