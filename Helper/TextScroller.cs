namespace RogueTraderUnityToolkit.Helper;

public class TextScroller(List<string[]> asciiArt, int frameDelay = 150)
{
    public void Scroll()
    {
        int[] widthsPerGroup = [.. asciiArt.Select(x => x.Max(y => y.Length))];
        int highestWidth = widthsPerGroup.Max(x => x);

        int[] offsetsPerGroup = [.. widthsPerGroup.Select(x => (highestWidth - x) / 2)];

        string[] combined = ["", "", .. asciiArt
            .Select(x => x.Append("").Append(""))
            .SelectMany((x, i) => x
                .Select(y => y.PadLeft(y.Length + offsetsPerGroup[i])))];

        int totalLines = combined.Length;
        int consoleHeight = Console.WindowHeight;

        for (int startLine = combined.Length - 1; startLine >= 0; --startLine)
        {
            Console.Clear();
            for (int line = startLine; line < Math.Min(startLine + consoleHeight, totalLines); line++)
            {
                Console.WriteLine(combined[line]);
            }
            Thread.Sleep(frameDelay);
        }

        Thread.Sleep(frameDelay*5);
    }
}

// Glokta said it best - Why do I do this?
public static class TextScrollerAscii
{
    public static readonly List<string[]> Art = [
        [
            "   █████╗ ██╗   ██╗███████╗  ",
            "  ██╔══██╗██║   ██║██╔════╝  ",
            "  ███████║██║   ██║█████╗    ",
            "  ███████║██║   ██║█████╗    ",
            "  ██╔══██║╚██╗ ██╔╝██╔══╝    ",
            "  ██║  ██║ ╚████╔╝ ███████╗  ",
            "  ╚═╝  ╚═╝  ╚═══╝  ╚══════╝  "
        ],

        [
            "  ██████╗ ███████╗██╗   ██╗███████╗  ",
            "  ██╔══██╗██╔════╝██║   ██║██╔════╝  ",
            "  ██║  ██║█████╗  ██║   ██║███████╗  ",
            "  ██║  ██║██╔══╝  ██║   ██║╚════██║  ",
            "  ██████╔╝███████╗╚██████╔╝███████║  ",
            "  ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝  "
        ],

        [
            "  ███╗   ███╗███████╗ ██████╗██╗  ██╗ █████╗ ███╗   ██╗██╗ ██████╗██╗   ██╗███████╗██╗  ",
            "  ████╗ ████║██╔════╝██╔════╝██║  ██║██╔══██╗████╗  ██║██║██╔════╝██║   ██║██╔════╝██║  ",
            "  ██╔████╔██║█████╗  ██║     ███████║███████║██╔██╗ ██║██║██║     ██║   ██║███████╗██║  ",
            "  ██║╚██╔╝██║██╔══╝  ██║     ██╔══██║██╔══██║██║╚██╗██║██║██║     ██║   ██║╚════██║╚═╝  ",
            "  ██║ ╚═╝ ██║███████╗╚██████╗██║  ██║██║  ██║██║ ╚████║██║╚██████╗╚██████╔╝███████║██╗  ",
            "  ╚═╝     ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝ ╚═════╝╚═════╝ ╚══════╝╚═╝   "
        ]
    ];
}