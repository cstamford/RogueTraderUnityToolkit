using RogueTraderUnityToolkit.Helper;
using RogueTraderUnityToolkit.Unity;

namespace RogueTraderUnityToolkit;

public interface ISerializedAsset
{
    public AssetDatabaseLoader Loader { get; }
}

public delegate Stream OpenStreamForAssetFunc(long offset = 0, long length = 0);

public static class AssetDatabase
{
    public static int ImportedAssets => _imported;
    public static int ImportedAssetsPending => _importedPending;
    public static int ImportedAssetsWarning => _importedWarning;
    public static int ImportedAssetsError => _importedError;

    public static Task<ISerializedAsset?> LoadUnityAssetAsync(
        AssetDatabaseLoader loader,
        AssetDatabaseImporter[] importers)
    {
        Interlocked.Increment(ref _importedPending);
        return Util.RunTask(() => LoadUnityAssetInternal(loader, importers));
    }

    private static int _imported = 0;
    private static int _importedPending = 0;
    private static int _importedWarning = 0;
    private static int _importedError = 0;

    private static ISerializedAsset? LoadUnityAssetInternal(
        AssetDatabaseLoader loader,
        AssetDatabaseImporter[] importers)
    {
        using var _ = Util.PerfScopeDatabase("LoadUnityAsset");

        ISerializedAsset? asset = null;

        AssetDatabaseImporter? importer = SelectImporter(loader, importers);

        if (importer != null)
        {
            asset = LoadUnityAssetWithImporter(loader, importer);
        }

        if (asset == null)
        {
            Log.Write($"Import: Unrecognised file format for {loader.Identifier}", ConsoleColor.Yellow);
            Interlocked.Increment(ref _importedWarning);
        }
        else
        {
            Interlocked.Increment(ref _imported);
        }

        return asset;
    }

    private static AssetDatabaseImporter? SelectImporter(
        AssetDatabaseLoader loader,
        AssetDatabaseImporter[] importers)
    {
        using var _ = Util.PerfScopeDatabase("LoadUnityAsset/SelectImporter");

        AssetDatabaseImporter? importer = importers.FirstOrDefault(x => x.CanRead(loader));

        if (importer == null)
        {
            string extension = Path.GetExtension(loader.Identifier).ToLower();

            if (SerializedConstants.ResourceFileExtensions.Contains(extension))
            {
                importer = new(fnCanRead: default!, fnRead: _ => new SerializedResourceFile(loader));
            }
        }

        return importer;
    }

    private static ISerializedAsset? LoadUnityAssetWithImporter(
        AssetDatabaseLoader loader,
        AssetDatabaseImporter importer)
    {
        using var _ = Util.PerfScopeDatabase("LoadUnityAsset/WithImporter");

        ISerializedAsset? asset = null;

        try
        {
            asset = importer.Read(loader);
        }
        catch (Exception e)
        {
            Log.Write($"Import: Failed to load {loader.Identifier} because:\n{e}", ConsoleColor.Red);
            Interlocked.Increment(ref _importedError);
        }
        finally
        {
            Interlocked.Decrement(ref _importedPending);
        }

        return asset;
    }
}

public sealed class AssetDatabaseImporter(
    Func<AssetDatabaseLoader, bool> fnCanRead,
    Func<AssetDatabaseLoader, ISerializedAsset> fnRead)
{
    public bool CanRead(AssetDatabaseLoader loader)
    {
        bool canRead = false;

        try
        {
            canRead = fnCanRead(loader);
        }
        catch { /* intentionally ignored */ }

        return canRead;
    }

    public ISerializedAsset Read(AssetDatabaseLoader loader) => fnRead(loader);
}

public sealed class AssetDatabaseLoader(string identifier, long size, OpenStreamForAssetFunc fnOpenStream)
{
    public string Identifier => identifier;
    public long Size => size;
    public Stream OpenStream(long offset = 0, long length = 0) => fnOpenStream(offset, length);
}
