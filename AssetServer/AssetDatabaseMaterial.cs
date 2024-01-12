using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;

namespace AssetServer;

public readonly record struct AssetDatabaseMaterial(
    AsciiString Name,
    AsciiString ShaderName,
    int CustomRenderQueue,
    bool DoubleSidedGI,
    bool EnableInstancingVariants,
    Dictionary<AsciiString, ColorRGBA_1> Colors,
    Dictionary<AsciiString, float> Floats,
    Dictionary<AsciiString, int> Ints,
    Dictionary<AsciiString, AssetDatabaseTexture> Textures,
    AsciiString[] DisabledShaderPasses,
    AsciiString[] InvalidKeywords,
    AsciiString[] ValidKeywords,
    Dictionary<AsciiString, AsciiString> StringTagMap)
{
    public static AssetDatabaseMaterial Read(AssetDatabasePtr<Material> ptr)
    {
        if (_materialCache.TryGetValue(ptr, out AssetDatabaseMaterial material))
        {
            return material;
        }

        Material mat = ptr.Fetch();

        Dictionary<AsciiString, AssetDatabaseTexture> textures = [];

        foreach ((AsciiString str, UnityTexEnv env) in mat.m_SavedProperties.m_TexEnvs)
        {
            AssetDatabasePtr<Texture> texPtr = new(ptr.File, env.m_Texture);
            if (texPtr.Valid && AssetDatabaseTexture.Read(texPtr, out AssetDatabaseTexture tex))
            {
                textures[str] = tex;
            }
        }

        AssetDatabasePtr<Shader> shaderPtr = new(ptr.File, mat.m_Shader);

        if (!_shaderNameCache.TryGetValue(shaderPtr, out AsciiString shaderName))
        {
            shaderName = shaderPtr.Fetch(withByteArrays: false).m_ParsedForm.m_Name;
            if (shaderName == "")
            {
                if (!AssetDatabaseStorage.ShaderNames.TryGetValue(shaderPtr, out shaderName))
                {
                    Log.Write($"Couldn't find shader for {mat.m_Name}", ConsoleColor.Yellow);
                }
            }
            _shaderNameCache[shaderPtr] = shaderName;
        }

        material = new(
            mat.m_Name,
            shaderName,
            mat.m_CustomRenderQueue,
            mat.m_DoubleSidedGI,
            mat.m_EnableInstancingVariants,
            mat.m_SavedProperties.m_Colors,
            mat.m_SavedProperties.m_Floats,
            mat.m_SavedProperties.m_Ints,
            textures,
            mat.disabledShaderPasses,
            mat.m_InvalidKeywords,
            mat.m_ValidKeywords,
            mat.stringTagMap);

        _materialCache[ptr] = material;

        return material;
    }

    private static readonly ConcurrentDictionary<AssetDatabasePtr<Material>, AssetDatabaseMaterial> _materialCache = [];
    private static readonly ConcurrentDictionary<AssetDatabasePtr<Shader>, AsciiString> _shaderNameCache = [];
}
