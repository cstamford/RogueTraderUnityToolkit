namespace RogueTraderUnityToolkit.Core;

public static class Log
{
    public const ConsoleColor DefaultColor = ConsoleColor.Gray;

    public static void WriteSingle(string message, ConsoleColor color = DefaultColor) =>
        WriteSingle(new LogEntry(message, color));

    public static void WriteSingle(params LogEntry[] messages)
    {
        _lock.Wait();

        foreach ((string message, ConsoleColor color) in messages)
        {
            // TODO: This can be optimized a bit if we care. Cache last color, since this requires syscall.
            Console.ForegroundColor = color;
            Console.Write(message);
        }

        _lock.Release();
    }

    public static void WriteSingle(int indent, string message, ConsoleColor color = DefaultColor) =>
        WriteSingle(indent, new LogEntry(message, color));

    public static void WriteSingle(int indent, params LogEntry[] messages) =>
        WriteSingle([new(' '.Repeat(indent)), .. messages]);

    public static void Write(string message, ConsoleColor color = DefaultColor) =>
        Write(new LogEntry(message, color));

    public static void Write(params LogEntry[] messages) =>
        WriteSingle([.. messages, new("\n")]);

    public static void Write(int indent, string message, ConsoleColor color = DefaultColor) =>
        Write(indent, new LogEntry(message, color));

    public static void Write(int indent, params LogEntry[] messages) =>
        WriteSingle(indent, [.. messages.Append(new("\n"))]);

    private static readonly SemaphoreSlim _lock = new(1, 1);
}

public record LogEntry(string Message, ConsoleColor Color = Log.DefaultColor);
