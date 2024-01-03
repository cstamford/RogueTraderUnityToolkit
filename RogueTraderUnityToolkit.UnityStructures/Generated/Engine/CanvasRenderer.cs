namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $CanvasRenderer (2 fields) (IsEngineType) */
public record class CanvasRenderer(
    PPtr<GameObject> m_GameObject,
    bool m_CullTransparentMesh)
{
    public static CanvasRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        bool m_CullTransparentMesh = reader.ReadBool();
        
        return new(m_GameObject,
            m_CullTransparentMesh);
    }
}

