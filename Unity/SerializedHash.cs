﻿using RogueTraderUnityToolkit.Helper;

namespace RogueTraderUnityToolkit.Unity;

public record struct SerializedHash(
    uint Uint0,
    uint Uint1,
    uint Uint2,
    uint Uint3)
{
    public static SerializedHash Read(EndianBinaryReader reader)
    {
        uint uint0 = reader.ReadU32();
        uint uint1 = reader.ReadU32();
        uint uint2 = reader.ReadU32();
        uint uint3 = reader.ReadU32();

        return new(
            Uint0: uint0,
            Uint1: uint1,
            Uint2: uint2,
            Uint3: uint3);
    }
}
