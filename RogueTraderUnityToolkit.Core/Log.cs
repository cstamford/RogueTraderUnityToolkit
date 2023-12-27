﻿namespace RogueTraderUnityToolkit.Core;

public static class Log
{
    public static void WriteSingle(string message, ConsoleColor color = ConsoleColor.White) =>
        WriteSingle(new LogEntry(message, color));

    public static void WriteSingle(params LogEntry[] messages)
    {
        lock (Console.Out)
        {
            foreach ((string message, ConsoleColor color) in messages)
            {
                Console.ForegroundColor = color;
                Console.Write(message);
                Console.ResetColor();
            }
        }
    }
    public static void WriteSingle(int indent, string message, ConsoleColor color = ConsoleColor.White) =>
        WriteSingle(indent, new LogEntry(message, color));

    public static void WriteSingle(int indent, params LogEntry[] messages) =>
        WriteSingle([new(' '.Repeat(indent)), .. messages]);

    public static void Write(string message, ConsoleColor color = ConsoleColor.White) =>
        Write(new LogEntry(message, color));

    public static void Write(params LogEntry[] messages) =>
        WriteSingle([.. messages, new("\n")]);

    public static void Write(int indent, string message, ConsoleColor color = ConsoleColor.White) =>
        Write(indent, new LogEntry(message, color));

    public static void Write(int indent, params LogEntry[] messages) =>
        WriteSingle(indent, [.. messages.Append(new("\n"))]);
}

public record LogEntry(string Message, ConsoleColor Color = ConsoleColor.White);
