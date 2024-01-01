﻿using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

public static class UnityTypeNames
{
    static UnityTypeNames()
    {
        Span<byte> buffer = _typeNameBinaryData;
        int head = 0;

        while (true)
        {
            int nextNull = Util.FastFindByte(0, buffer, head);
            if (nextNull == -1) break;

            ReadOnlyMemory<byte> memory = _typeNameBinaryData.AsMemory()[head..nextNull];
            _offsetLookupBytes.Add(head, memory);

            head = nextNull + 1;
        }
    }

    public static bool TryGetValue(int offset, out ReadOnlyMemory<byte> bytes) =>
        _offsetLookupBytes.TryGetValue(offset, out bytes);

    private static readonly Dictionary<int, ReadOnlyMemory<byte>> _offsetLookupBytes = [];

    #region codegen
    // exported from IDA, ref: 0x00000001825B6240 @ UnityPlayer.dll 2022.3.7f1 (see also ref to CommonStringTable) (alt+L, edit -> export data)
    private static readonly byte[] _typeNameBinaryData =
    [
        0x41,
        0x41,
        0x42,
        0x42,
        0x00,
        0x41,
        0x6E,
        0x69,
        0x6D,
        0x61,
        0x74,
        0x69,
        0x6F,
        0x6E,
        0x43,
        0x6C,
        0x69,
        0x70,
        0x00,
        0x41,
        0x6E,
        0x69,
        0x6D,
        0x61,
        0x74,
        0x69,
        0x6F,
        0x6E,
        0x43,
        0x75,
        0x72,
        0x76,
        0x65,
        0x00,
        0x41,
        0x6E,
        0x69,
        0x6D,
        0x61,
        0x74,
        0x69,
        0x6F,
        0x6E,
        0x53,
        0x74,
        0x61,
        0x74,
        0x65,
        0x00,
        0x41,
        0x72,
        0x72,
        0x61,
        0x79,
        0x00,
        0x42,
        0x61,
        0x73,
        0x65,
        0x00,
        0x42,
        0x69,
        0x74,
        0x46,
        0x69,
        0x65,
        0x6C,
        0x64,
        0x00,
        0x62,
        0x69,
        0x74,
        0x73,
        0x65,
        0x74,
        0x00,
        0x62,
        0x6F,
        0x6F,
        0x6C,
        0x00,
        0x63,
        0x68,
        0x61,
        0x72,
        0x00,
        0x43,
        0x6F,
        0x6C,
        0x6F,
        0x72,
        0x52,
        0x47,
        0x42,
        0x41,
        0x00,
        0x43,
        0x6F,
        0x6D,
        0x70,
        0x6F,
        0x6E,
        0x65,
        0x6E,
        0x74,
        0x00,
        0x64,
        0x61,
        0x74,
        0x61,
        0x00,
        0x64,
        0x65,
        0x71,
        0x75,
        0x65,
        0x00,
        0x64,
        0x6F,
        0x75,
        0x62,
        0x6C,
        0x65,
        0x00,
        0x64,
        0x79,
        0x6E,
        0x61,
        0x6D,
        0x69,
        0x63,
        0x5F,
        0x61,
        0x72,
        0x72,
        0x61,
        0x79,
        0x00,
        0x46,
        0x61,
        0x73,
        0x74,
        0x50,
        0x72,
        0x6F,
        0x70,
        0x65,
        0x72,
        0x74,
        0x79,
        0x4E,
        0x61,
        0x6D,
        0x65,
        0x00,
        0x66,
        0x69,
        0x72,
        0x73,
        0x74,
        0x00,
        0x66,
        0x6C,
        0x6F,
        0x61,
        0x74,
        0x00,
        0x46,
        0x6F,
        0x6E,
        0x74,
        0x00,
        0x47,
        0x61,
        0x6D,
        0x65,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x00,
        0x47,
        0x65,
        0x6E,
        0x65,
        0x72,
        0x69,
        0x63,
        0x20,
        0x4D,
        0x6F,
        0x6E,
        0x6F,
        0x00,
        0x47,
        0x72,
        0x61,
        0x64,
        0x69,
        0x65,
        0x6E,
        0x74,
        0x4E,
        0x45,
        0x57,
        0x00,
        0x47,
        0x55,
        0x49,
        0x44,
        0x00,
        0x47,
        0x55,
        0x49,
        0x53,
        0x74,
        0x79,
        0x6C,
        0x65,
        0x00,
        0x69,
        0x6E,
        0x74,
        0x00,
        0x6C,
        0x69,
        0x73,
        0x74,
        0x00,
        0x6C,
        0x6F,
        0x6E,
        0x67,
        0x20,
        0x6C,
        0x6F,
        0x6E,
        0x67,
        0x00,
        0x6D,
        0x61,
        0x70,
        0x00,
        0x4D,
        0x61,
        0x74,
        0x72,
        0x69,
        0x78,
        0x34,
        0x78,
        0x34,
        0x66,
        0x00,
        0x4D,
        0x64,
        0x46,
        0x6F,
        0x75,
        0x72,
        0x00,
        0x4D,
        0x6F,
        0x6E,
        0x6F,
        0x42,
        0x65,
        0x68,
        0x61,
        0x76,
        0x69,
        0x6F,
        0x75,
        0x72,
        0x00,
        0x4D,
        0x6F,
        0x6E,
        0x6F,
        0x53,
        0x63,
        0x72,
        0x69,
        0x70,
        0x74,
        0x00,
        0x6D,
        0x5F,
        0x42,
        0x79,
        0x74,
        0x65,
        0x53,
        0x69,
        0x7A,
        0x65,
        0x00,
        0x6D,
        0x5F,
        0x43,
        0x75,
        0x72,
        0x76,
        0x65,
        0x00,
        0x6D,
        0x5F,
        0x45,
        0x64,
        0x69,
        0x74,
        0x6F,
        0x72,
        0x43,
        0x6C,
        0x61,
        0x73,
        0x73,
        0x49,
        0x64,
        0x65,
        0x6E,
        0x74,
        0x69,
        0x66,
        0x69,
        0x65,
        0x72,
        0x00,
        0x6D,
        0x5F,
        0x45,
        0x64,
        0x69,
        0x74,
        0x6F,
        0x72,
        0x48,
        0x69,
        0x64,
        0x65,
        0x46,
        0x6C,
        0x61,
        0x67,
        0x73,
        0x00,
        0x6D,
        0x5F,
        0x45,
        0x6E,
        0x61,
        0x62,
        0x6C,
        0x65,
        0x64,
        0x00,
        0x6D,
        0x5F,
        0x45,
        0x78,
        0x74,
        0x65,
        0x6E,
        0x73,
        0x69,
        0x6F,
        0x6E,
        0x50,
        0x74,
        0x72,
        0x00,
        0x6D,
        0x5F,
        0x47,
        0x61,
        0x6D,
        0x65,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x00,
        0x6D,
        0x5F,
        0x49,
        0x6E,
        0x64,
        0x65,
        0x78,
        0x00,
        0x6D,
        0x5F,
        0x49,
        0x73,
        0x41,
        0x72,
        0x72,
        0x61,
        0x79,
        0x00,
        0x6D,
        0x5F,
        0x49,
        0x73,
        0x53,
        0x74,
        0x61,
        0x74,
        0x69,
        0x63,
        0x00,
        0x6D,
        0x5F,
        0x4D,
        0x65,
        0x74,
        0x61,
        0x46,
        0x6C,
        0x61,
        0x67,
        0x00,
        0x6D,
        0x5F,
        0x4E,
        0x61,
        0x6D,
        0x65,
        0x00,
        0x6D,
        0x5F,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x48,
        0x69,
        0x64,
        0x65,
        0x46,
        0x6C,
        0x61,
        0x67,
        0x73,
        0x00,
        0x6D,
        0x5F,
        0x50,
        0x72,
        0x65,
        0x66,
        0x61,
        0x62,
        0x49,
        0x6E,
        0x74,
        0x65,
        0x72,
        0x6E,
        0x61,
        0x6C,
        0x00,
        0x6D,
        0x5F,
        0x50,
        0x72,
        0x65,
        0x66,
        0x61,
        0x62,
        0x50,
        0x61,
        0x72,
        0x65,
        0x6E,
        0x74,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x00,
        0x6D,
        0x5F,
        0x53,
        0x63,
        0x72,
        0x69,
        0x70,
        0x74,
        0x00,
        0x6D,
        0x5F,
        0x53,
        0x74,
        0x61,
        0x74,
        0x69,
        0x63,
        0x45,
        0x64,
        0x69,
        0x74,
        0x6F,
        0x72,
        0x46,
        0x6C,
        0x61,
        0x67,
        0x73,
        0x00,
        0x6D,
        0x5F,
        0x54,
        0x79,
        0x70,
        0x65,
        0x00,
        0x6D,
        0x5F,
        0x56,
        0x65,
        0x72,
        0x73,
        0x69,
        0x6F,
        0x6E,
        0x00,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x00,
        0x70,
        0x61,
        0x69,
        0x72,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x43,
        0x6F,
        0x6D,
        0x70,
        0x6F,
        0x6E,
        0x65,
        0x6E,
        0x74,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x47,
        0x61,
        0x6D,
        0x65,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x4D,
        0x61,
        0x74,
        0x65,
        0x72,
        0x69,
        0x61,
        0x6C,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x4D,
        0x6F,
        0x6E,
        0x6F,
        0x42,
        0x65,
        0x68,
        0x61,
        0x76,
        0x69,
        0x6F,
        0x75,
        0x72,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x4D,
        0x6F,
        0x6E,
        0x6F,
        0x53,
        0x63,
        0x72,
        0x69,
        0x70,
        0x74,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x50,
        0x72,
        0x65,
        0x66,
        0x61,
        0x62,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x53,
        0x70,
        0x72,
        0x69,
        0x74,
        0x65,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x54,
        0x65,
        0x78,
        0x74,
        0x41,
        0x73,
        0x73,
        0x65,
        0x74,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x54,
        0x65,
        0x78,
        0x74,
        0x75,
        0x72,
        0x65,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x54,
        0x65,
        0x78,
        0x74,
        0x75,
        0x72,
        0x65,
        0x32,
        0x44,
        0x3E,
        0x00,
        0x50,
        0x50,
        0x74,
        0x72,
        0x3C,
        0x54,
        0x72,
        0x61,
        0x6E,
        0x73,
        0x66,
        0x6F,
        0x72,
        0x6D,
        0x3E,
        0x00,
        0x50,
        0x72,
        0x65,
        0x66,
        0x61,
        0x62,
        0x00,
        0x51,
        0x75,
        0x61,
        0x74,
        0x65,
        0x72,
        0x6E,
        0x69,
        0x6F,
        0x6E,
        0x66,
        0x00,
        0x52,
        0x65,
        0x63,
        0x74,
        0x66,
        0x00,
        0x52,
        0x65,
        0x63,
        0x74,
        0x49,
        0x6E,
        0x74,
        0x00,
        0x52,
        0x65,
        0x63,
        0x74,
        0x4F,
        0x66,
        0x66,
        0x73,
        0x65,
        0x74,
        0x00,
        0x73,
        0x65,
        0x63,
        0x6F,
        0x6E,
        0x64,
        0x00,
        0x73,
        0x65,
        0x74,
        0x00,
        0x73,
        0x68,
        0x6F,
        0x72,
        0x74,
        0x00,
        0x73,
        0x69,
        0x7A,
        0x65,
        0x00,
        0x53,
        0x49,
        0x6E,
        0x74,
        0x31,
        0x36,
        0x00,
        0x53,
        0x49,
        0x6E,
        0x74,
        0x33,
        0x32,
        0x00,
        0x53,
        0x49,
        0x6E,
        0x74,
        0x36,
        0x34,
        0x00,
        0x53,
        0x49,
        0x6E,
        0x74,
        0x38,
        0x00,
        0x73,
        0x74,
        0x61,
        0x74,
        0x69,
        0x63,
        0x76,
        0x65,
        0x63,
        0x74,
        0x6F,
        0x72,
        0x00,
        0x73,
        0x74,
        0x72,
        0x69,
        0x6E,
        0x67,
        0x00,
        0x54,
        0x65,
        0x78,
        0x74,
        0x41,
        0x73,
        0x73,
        0x65,
        0x74,
        0x00,
        0x54,
        0x65,
        0x78,
        0x74,
        0x4D,
        0x65,
        0x73,
        0x68,
        0x00,
        0x54,
        0x65,
        0x78,
        0x74,
        0x75,
        0x72,
        0x65,
        0x00,
        0x54,
        0x65,
        0x78,
        0x74,
        0x75,
        0x72,
        0x65,
        0x32,
        0x44,
        0x00,
        0x54,
        0x72,
        0x61,
        0x6E,
        0x73,
        0x66,
        0x6F,
        0x72,
        0x6D,
        0x00,
        0x54,
        0x79,
        0x70,
        0x65,
        0x6C,
        0x65,
        0x73,
        0x73,
        0x44,
        0x61,
        0x74,
        0x61,
        0x00,
        0x55,
        0x49,
        0x6E,
        0x74,
        0x31,
        0x36,
        0x00,
        0x55,
        0x49,
        0x6E,
        0x74,
        0x33,
        0x32,
        0x00,
        0x55,
        0x49,
        0x6E,
        0x74,
        0x36,
        0x34,
        0x00,
        0x55,
        0x49,
        0x6E,
        0x74,
        0x38,
        0x00,
        0x75,
        0x6E,
        0x73,
        0x69,
        0x67,
        0x6E,
        0x65,
        0x64,
        0x20,
        0x69,
        0x6E,
        0x74,
        0x00,
        0x75,
        0x6E,
        0x73,
        0x69,
        0x67,
        0x6E,
        0x65,
        0x64,
        0x20,
        0x6C,
        0x6F,
        0x6E,
        0x67,
        0x20,
        0x6C,
        0x6F,
        0x6E,
        0x67,
        0x00,
        0x75,
        0x6E,
        0x73,
        0x69,
        0x67,
        0x6E,
        0x65,
        0x64,
        0x20,
        0x73,
        0x68,
        0x6F,
        0x72,
        0x74,
        0x00,
        0x76,
        0x65,
        0x63,
        0x74,
        0x6F,
        0x72,
        0x00,
        0x56,
        0x65,
        0x63,
        0x74,
        0x6F,
        0x72,
        0x32,
        0x66,
        0x00,
        0x56,
        0x65,
        0x63,
        0x74,
        0x6F,
        0x72,
        0x33,
        0x66,
        0x00,
        0x56,
        0x65,
        0x63,
        0x74,
        0x6F,
        0x72,
        0x34,
        0x66,
        0x00,
        0x6D,
        0x5F,
        0x53,
        0x63,
        0x72,
        0x69,
        0x70,
        0x74,
        0x69,
        0x6E,
        0x67,
        0x43,
        0x6C,
        0x61,
        0x73,
        0x73,
        0x49,
        0x64,
        0x65,
        0x6E,
        0x74,
        0x69,
        0x66,
        0x69,
        0x65,
        0x72,
        0x00,
        0x47,
        0x72,
        0x61,
        0x64,
        0x69,
        0x65,
        0x6E,
        0x74,
        0x00,
        0x54,
        0x79,
        0x70,
        0x65,
        0x2A,
        0x00,
        0x69,
        0x6E,
        0x74,
        0x32,
        0x5F,
        0x73,
        0x74,
        0x6F,
        0x72,
        0x61,
        0x67,
        0x65,
        0x00,
        0x69,
        0x6E,
        0x74,
        0x33,
        0x5F,
        0x73,
        0x74,
        0x6F,
        0x72,
        0x61,
        0x67,
        0x65,
        0x00,
        0x42,
        0x6F,
        0x75,
        0x6E,
        0x64,
        0x73,
        0x49,
        0x6E,
        0x74,
        0x00,
        0x6D,
        0x5F,
        0x43,
        0x6F,
        0x72,
        0x72,
        0x65,
        0x73,
        0x70,
        0x6F,
        0x6E,
        0x64,
        0x69,
        0x6E,
        0x67,
        0x53,
        0x6F,
        0x75,
        0x72,
        0x63,
        0x65,
        0x4F,
        0x62,
        0x6A,
        0x65,
        0x63,
        0x74,
        0x00,
        0x6D,
        0x5F,
        0x50,
        0x72,
        0x65,
        0x66,
        0x61,
        0x62,
        0x49,
        0x6E,
        0x73,
        0x74,
        0x61,
        0x6E,
        0x63,
        0x65,
        0x00,
        0x6D,
        0x5F,
        0x50,
        0x72,
        0x65,
        0x66,
        0x61,
        0x62,
        0x41,
        0x73,
        0x73,
        0x65,
        0x74,
        0x00,
        0x46,
        0x69,
        0x6C,
        0x65,
        0x53,
        0x69,
        0x7A,
        0x65,
        0x00,
        0x48,
        0x61,
        0x73,
        0x68,
        0x31,
        0x32,
        0x38,
        0x00,
        0x00
    ];
    #endregion
}
