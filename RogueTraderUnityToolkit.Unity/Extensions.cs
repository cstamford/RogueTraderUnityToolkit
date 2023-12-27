using RogueTraderUnityToolkit.Core;
using System.Text;

namespace RogueTraderUnityToolkit.Unity;

public static class Extensions
{
    public static byte Size(this ObjectParserType type) => type switch
    {
        ObjectParserType.U64 => 8,
        ObjectParserType.U32 => 4,
        ObjectParserType.U16 => 2,
        ObjectParserType.U8 => 1,
        ObjectParserType.S64 => 8,
        ObjectParserType.S32 => 4,
        ObjectParserType.S16 => 2,
        ObjectParserType.S8 => 1,
        ObjectParserType.F64 => 8,
        ObjectParserType.F32 => 4,
        ObjectParserType.Bool => 1,
        ObjectParserType.Char => 1,
        _ => 0
    };
    
    public static unsafe string ReadPrimitiveArrayAsString(
        this ObjectParserReader reader, 
        in ObjectParserNode node,
        int arrayLength,
        int readLength = -1,
        string separator = ", ")
    {
        ObjectParserType type = reader.Type;
        int sizePerElement = type.Size();
        int chunkSize = sizePerElement * Math.Min(256, readLength != -1 ? readLength : 64);
        byte* buffer = stackalloc byte[chunkSize + sizePerElement];
        buffer = Memory.AlignTo(buffer, sizePerElement);
        
        StringBuilder sb = new();

        reader.ReadPrimitiveArray(node, arrayLength, new(buffer, chunkSize), (start, end) =>
        {
            for (int i = 0; i < end - start; ++i)
            {
                byte* elem = buffer + i * sizePerElement;        
                
                sb.Append(type switch
                {
                    ObjectParserType.U64 => (*(ulong*)elem).ToString(),
                    ObjectParserType.U32 => (*(uint*)elem).ToString(),
                    ObjectParserType.U16 => (*(ushort*)elem).ToString(),
                    ObjectParserType.U8 => (*elem).ToString(),
                    ObjectParserType.S64 => (*(long*)elem).ToString(),
                    ObjectParserType.S32 => (*(int*)elem).ToString(),
                    ObjectParserType.S16 => (*(short*)elem).ToString(),
                    ObjectParserType.S8 => (*(sbyte*)elem).ToString(),
                    ObjectParserType.F64 => (*(double*)elem).ToString("R"),
                    ObjectParserType.F32 => (*(float*)elem).ToString("R"),
                    ObjectParserType.Bool => (*elem != 0) ? "true" : "false",
                    ObjectParserType.Char => Convert.ToChar(*(elem)).ToString(),
                    _ => string.Empty
                });

                sb.Append(separator);
            }

            return end != readLength;
        });

        if (sb.Length != 0) // remove trailing separator
        {
            sb.Remove(sb.Length - separator.Length, separator.Length);
        }

        return sb.ToString();
    }
    
    public static string ReadPrimitiveAsString(
        this ObjectParserReader reader,
        in ObjectParserNode node) => node.Type switch
    {
        ObjectParserType.U64 => reader.ReadU64(node).ToString(),
        ObjectParserType.U32 => reader.ReadU32(node).ToString(),
        ObjectParserType.U16 => reader.ReadU16(node).ToString(),
        ObjectParserType.U8 => reader.ReadU8(node).ToString(),
        ObjectParserType.S64 => reader.ReadS64(node).ToString(),
        ObjectParserType.S32 => reader.ReadS32(node).ToString(),
        ObjectParserType.S16 => reader.ReadS16(node).ToString(),
        ObjectParserType.S8 => reader.ReadS8(node).ToString(),
        ObjectParserType.F64 => reader.ReadF64(node).ToString("R"),
        ObjectParserType.F32 => reader.ReadF32(node).ToString("R"),
        ObjectParserType.Bool => reader.ReadBool(node) ? "true" : "false",
        ObjectParserType.Char => reader.ReadChar(node).ToString(),
        _ => string.Empty
    };
}
