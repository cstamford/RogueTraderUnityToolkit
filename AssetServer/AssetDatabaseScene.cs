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
            databaseMesh = AssetDatabaseMesh.Read(new(meshFilterPtr.File, meshFilterPtr.Fetch<MeshFilter>().m_Mesh));

            MeshRenderer meshRenderer = meshRendererPtr.Fetch<MeshRenderer>();
            databaseMeshMaterials = new AssetDatabaseMaterial[meshRenderer.m_Materials.Length];

            for (int i = 0; i < meshRenderer.m_Materials.Length; ++i)
            {
                databaseMeshMaterials[i] = AssetDatabaseMaterial.Read(new(meshRendererPtr.File, meshRenderer.m_Materials[i]));
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
