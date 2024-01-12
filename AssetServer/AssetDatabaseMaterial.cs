using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

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
        Shader shader = shaderPtr.Fetch(withByteArrays: false);

        AsciiString shaderName = shader.m_ParsedForm.m_Name;
        if (shaderName == "")
        {
            if (!AssetDatabaseStorage.ShaderNames.TryGetValue(shaderPtr, out shaderName))
            {
                Log.Write($"Couldn't find shader for {material.m_Name}", ConsoleColor.Yellow);
            }
        }

        return new(material.m_Name, shaderName, textures);
    }
}
