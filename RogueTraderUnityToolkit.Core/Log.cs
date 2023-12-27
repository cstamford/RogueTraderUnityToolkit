using System.Diagnostics;

namespace RogueTraderUnityToolkit.Core;

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

public static class LogDebug
{
#if DEBUG_LOGGING
    [Conditional("DEBUG")]
    public static void WriteSingle(string message, ConsoleColor color = ConsoleColor.White) { }

    [Conditional("DEBUG")]
    public static void WriteSingle(params LogEntry[] messages) { }

    [Conditional("DEBUG")]
    public static void WriteSingle(int indent, string message, ConsoleColor color = ConsoleColor.White) { }

    [Conditional("DEBUG")]
    public static void WriteSingle(int indent, params LogEntry[] messages) { }

    [Conditional("DEBUG")]
    public static void Write(string message, ConsoleColor color = ConsoleColor.White) { }

    [Conditional("DEBUG")]
    public static void Write(params LogEntry[] messages) { }

    [Conditional("DEBUG")]
    public static void Write(int indent, string message, ConsoleColor color = ConsoleColor.White) { }

    [Conditional("DEBUG")]
    public static void Write(int indent, params LogEntry[] messages) { }
#else
    [Conditional("DEBUG")]
    public static void WriteSingle(string message, ConsoleColor color = ConsoleColor.White) =>
        Log.WriteSingle(message, color);

    [Conditional("DEBUG")]
    public static void WriteSingle(params LogEntry[] messages) =>
        Log.WriteSingle(messages);

    [Conditional("DEBUG")]
    public static void WriteSingle(int indent, string message, ConsoleColor color = ConsoleColor.White) =>
        Log.WriteSingle(indent, message, color);

    [Conditional("DEBUG")]
    public static void WriteSingle(int indent, params LogEntry[] messages) =>
        Log.WriteSingle(indent, messages);

    [Conditional("DEBUG")]
    public static void Write(string message, ConsoleColor color = ConsoleColor.White) =>
        Log.Write(message, color);

    [Conditional("DEBUG")]
    public static void Write(params LogEntry[] messages) =>
        Log.Write(messages);

    [Conditional("DEBUG")]
    public static void Write(int indent, string message, ConsoleColor color = ConsoleColor.White) =>
        Log.Write(indent, message, color);

    [Conditional("DEBUG")]
    public static void Write(int indent, params LogEntry[] messages) =>
        Log.Write(indent, messages);
#endif
}

public record LogEntry(string Message, ConsoleColor Color = ConsoleColor.White);
