using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;

namespace AssetServer;

public readonly record struct AssetDatabaseMaterial(
    AsciiString Name,
    AsciiString ShaderName,
    Dictionary<AsciiString, AssetDatabaseTexture> Textures)
{
    public static AssetDatabaseMaterial Read(AssetDatabasePtr<Material> ptr)
    {
        Material material = ptr.Fetch();

        Dictionary<AsciiString, AssetDatabaseTexture> textures = [];

        foreach ((AsciiString str, UnityTexEnv env) in material.m_SavedProperties.m_TexEnvs)
        {
            AssetDatabasePtr<Texture> texPtr = new(ptr.File, env.m_Texture);
            if (texPtr.Valid && AssetDatabaseTexture.Read(texPtr, out AssetDatabaseTexture tex))
            {
                textures[str] = tex;
            }
        }

        AssetDatabasePtr<Shader> shaderPtr = new(ptr.File, material.m_Shader);

        if (!_shaderNameCache.TryGetValue(shaderPtr, out AsciiString shaderName))
        {
            shaderName = shaderPtr.Fetch(withByteArrays: false).m_ParsedForm.m_Name;
            if (shaderName == "")
            {
                if (!AssetDatabaseStorage.ShaderNames.TryGetValue(shaderPtr, out shaderName))
                {
                    Log.Write($"Couldn't find shader for {material.m_Name}", ConsoleColor.Yellow);
                }
            }
            _shaderNameCache[shaderPtr] = shaderName;
        }

        return new(material.m_Name, shaderName, textures);
    }

    private static readonly ConcurrentDictionary<AssetDatabasePtr<Shader>, AsciiString> _shaderNameCache = [];
}
