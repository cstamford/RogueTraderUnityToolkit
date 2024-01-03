namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Material (12 fields) (IsEngineType) */
public record class Material(
    AsciiString m_Name,
    PPtr<Shader> m_Shader,
    AsciiString[] m_ValidKeywords,
    AsciiString[] m_InvalidKeywords,
    uint m_LightmapFlags,
    bool m_EnableInstancingVariants,
    bool m_DoubleSidedGI,
    int m_CustomRenderQueue,
    Dictionary<AsciiString, AsciiString> stringTagMap,
    AsciiString[] disabledShaderPasses,
    UnityPropertySheet m_SavedProperties,
    BuildTextureStackReference[] m_BuildTextureStacks)
{
    public static Material Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        PPtr<Shader> m_Shader = PPtr<Shader>.Read(reader);
        AsciiString[] m_ValidKeywords = Array<AsciiString>.Read(reader);
        AsciiString[] m_InvalidKeywords = Array<AsciiString>.Read(reader);
        uint m_LightmapFlags = reader.ReadU32();
        bool m_EnableInstancingVariants = reader.ReadBool();
        bool m_DoubleSidedGI = reader.ReadBool();
        int m_CustomRenderQueue = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> stringTagMap = Map<AsciiString, AsciiString>.Read(reader);
        AsciiString[] disabledShaderPasses = Array<AsciiString>.Read(reader);
        UnityPropertySheet m_SavedProperties = UnityPropertySheet.Read(reader);
        BuildTextureStackReference[] m_BuildTextureStacks = Array<BuildTextureStackReference>.Read(reader);
        
        return new(m_Name,
            m_Shader,
            m_ValidKeywords,
            m_InvalidKeywords,
            m_LightmapFlags,
            m_EnableInstancingVariants,
            m_DoubleSidedGI,
            m_CustomRenderQueue,
            stringTagMap,
            disabledShaderPasses,
            m_SavedProperties,
            m_BuildTextureStacks);
    }
}

