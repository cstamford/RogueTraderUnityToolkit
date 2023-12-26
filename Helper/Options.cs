namespace RogueTraderUnityToolkit.Helper;

public static class Options
{
    public static bool ShouldRunSingleThreaded =>
#if SINGLETHREADED
true;
#else
    false;
#endif

    public static int MemoryCacheLimit =>
#if SINGLETHREADED
        0;
#else
    1024 * 1024 * 512;
#endif

    public static bool FastIterationInDebug =>
#if DEBUG
        true;
#else
        false;
#endif
}
