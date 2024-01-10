using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Diagnostics;

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
    AssetDatabaseSceneObject[] Children)
{
    public static AssetDatabaseSceneObject Read(
        AssetDatabasePtr<GameObject> ptr,
        out AssetDatabasePtr<Transform> parent)
    {
        GameObject self = ptr.Fetch();

        IEnumerable<AssetDatabasePtr<IUnityObject>> componentPtrs = self.m_Component
            .Select(x => ptr.File.Ptr(x.component).Retype<IUnityObject>());

        AssetDatabaseMesh? mesh = null;

        foreach (AssetDatabasePtr<IUnityObject> component in componentPtrs)
        {
            IUnityObject componentData = component.Fetch();
            if (componentData is MeshFilter filter)
            {
                mesh = AssetDatabaseMesh.Read(component.File.Ptr(filter.m_Mesh));
                break;
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
            Mesh: mesh,
            Children: [..children]);
    }
}
