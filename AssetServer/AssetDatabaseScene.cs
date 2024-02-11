using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

namespace AssetServer;

public readonly record struct AssetDatabaseScene(
    AsciiString Name,
    AssetDatabaseSceneObject[] RootObjects)
{
    public static AssetDatabaseScene Read(
        AsciiString name,
        SerializedFile sceneContainer)
    {
        List<AssetDatabaseSceneObject> rootObjects = [];

        Parallel.ForEach(
            sceneContainer.GetObjectPtrs<GameObject>(UnityObjectType.GameObject),
            objPtr =>
        {
            AssetDatabaseSceneObject obj = AssetDatabaseSceneObject.Read(objPtr, out AssetDatabasePtr<Transform> parent);
            if (parent.Valid) return; // only take root objects
            lock (rootObjects) { rootObjects.Add(obj); }
        });

        return new(name, [.. rootObjects]);
    }

    public List<AssetDatabaseSceneObject> GetAllObjects()
    {
        List<AssetDatabaseSceneObject> list = [];
        foreach (AssetDatabaseSceneObject obj in RootObjects)
        {
            GetAllObjectsInternal(obj, list);
        }
        return list;
    }

    private void GetAllObjectsInternal(AssetDatabaseSceneObject obj, List<AssetDatabaseSceneObject> list)
    {
        list.Add(obj);

        foreach (AssetDatabaseSceneObject child in obj.Children)
        {
            GetAllObjectsInternal(child, list);
        }
    }
}

public record struct AssetDatabaseSceneObject(
    AsciiString Name,
    Transform Transform,
    AssetDatabaseMesh? Mesh,
    AssetDatabaseMaterial[] MeshMaterials,
    AssetDatabaseSceneObject[] Children)
{
    public static AssetDatabaseSceneObject Read(
        AssetDatabasePtr<GameObject> ptr,
        out AssetDatabasePtr<Transform> parent)
    {
        GameObject self = ptr.Fetch();

        IEnumerable<AssetDatabasePtr<IUnityObject>> componentPtrs = self.m_Component
            .Select(x => ptr.File.Ptr(x.component).Retype<IUnityObject>());

        AssetDatabasePtr<IUnityObject> meshFilterPtr = componentPtrs.FirstOrDefault(x => x.Fetch() is MeshFilter);
        AssetDatabasePtr<IUnityObject> meshRendererPtr = componentPtrs.FirstOrDefault(x => x.Fetch() is MeshRenderer);

        AssetDatabaseMesh? databaseMesh = null;
        AssetDatabaseMaterial[] databaseMeshMaterials = Array.Empty<AssetDatabaseMaterial>();

        if (meshFilterPtr.Valid && meshRendererPtr.Valid)
        {
            AssetDatabasePtr<Mesh> meshPtr = new(meshFilterPtr.File, meshFilterPtr.Fetch<MeshFilter>().m_Mesh);
            if (meshPtr.Valid)
            {
                databaseMesh = AssetDatabaseMesh.Read(meshPtr);

                MeshRenderer meshRenderer = meshRendererPtr.Fetch<MeshRenderer>();
                AssetDatabasePtr<Material>[] materialPtrs = meshRenderer.m_Materials
                    .Select(x => new AssetDatabasePtr<Material>(meshRendererPtr.File, x))
                    .Where(x => x.Valid)
                    .ToArray();

                databaseMeshMaterials = new AssetDatabaseMaterial[materialPtrs.Length];

                for (int i = 0; i < materialPtrs.Length; ++i)
                {
                    databaseMeshMaterials[i] = AssetDatabaseMaterial.Read(materialPtrs[i]);
                }
            }
        }

        AssetDatabasePtr<Transform> transformPtr = componentPtrs
            .First(x => x.Fetch() is Transform)
            .Retype<Transform>();

        Transform transform = transformPtr.Fetch();
        parent = transformPtr.File.Ptr(transform.m_Father);

        IEnumerable<AssetDatabaseSceneObject> children = transform.m_Children
            .Select(x => transformPtr.File.Ptr(x))
            .Select(child => child.File.Ptr(child.Fetch().m_GameObject))
            .Select(x => Read(x, out _));

        return new(
            Name: self.m_Name,
            Transform: transform,
            Mesh: databaseMesh,
            MeshMaterials: databaseMeshMaterials,
            Children: [..children]);
    }
}
