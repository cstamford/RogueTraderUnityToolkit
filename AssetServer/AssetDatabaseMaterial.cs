using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Diagnostics;

namespace AssetServer;

public readonly record struct AssetDatabaseMaterial(
    AsciiString Name,
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

        return new(material.m_Name, textures);
    }
}

public readonly record struct AssetDatabaseTexture(
    AsciiString Name,
    int Width,
    int Height,
    TextureFormat Format,
    GLTextureSettings Settings,
    byte[] Data)
{
    public static bool Read(AssetDatabasePtr<Texture> ptr, out AssetDatabaseTexture texture)
    {
        IUnityObject tex = ptr.Fetch<IUnityObject>();

        if (tex is Texture2D tex2d)
        {
            byte[] data = tex2d.image_data;

            if (data.Length == 0)
            {
                string path = tex2d.m_StreamData.path.ToString().Split('/').Last();
                ResourceFile file = (ResourceFile)AssetDatabaseStorage.Assets[path];
                using Stream stream = file.Info.Open((long)tex2d.m_StreamData.offset, tex2d.m_StreamData.size);
                data = new byte[tex2d.m_StreamData.size];
                int bytesRead = stream.Read(data.AsSpan());
                Debug.Assert(bytesRead == data.Length);
            }

            Debug.Assert(data.Length == tex2d.m_CompleteImageSize);

            texture = new(tex2d.m_Name,
                tex2d.m_Width,
                tex2d.m_Height,
                (TextureFormat)tex2d.m_TextureFormat,
                tex2d.m_TextureSettings,
                data);

            return true;
        }

        texture = default;
        return false;
    }
}

// ref: https://docs.unity3d.com/ScriptReference/TextureFormat.html
public enum TextureFormat
{
    Alpha8 = 1, // Alpha-only texture format, 8 bit integer.
    ARGB4444, // A 16 bits/pixel texture format. Texture stores color with an alpha channel.
    RGB24, // Color texture format, 8-bits per channel.
    RGBA32, // Color with alpha texture format, 8-bits per channel.
    ARGB32, // Color with alpha texture format, 8-bits per channel.
    RGB565, // A 16 bit color texture format.
    R16, // Single channel (R) texture format, 16 bit integer.
    DXT1, // Compressed color texture format.
    DXT5, // Compressed color with alpha channel texture format.
    RGBA4444, // Color and alpha texture format, 4 bit per channel.
    BGRA32, // Color with alpha texture format, 8-bits per channel.
    RHalf, // Scalar (R) texture format, 16 bit floating point.
    RGHalf, // Two color (RG) texture format, 16 bit floating point per channel.
    RGBAHalf, // RGB color and alpha texture format, 16 bit floating point per channel.
    RFloat, // Scalar (R) texture format, 32 bit floating point.
    RGFloat, // Two color (RG) texture format, 32 bit floating point per channel.
    RGBAFloat, // RGB color and alpha texture format, 32-bit floats per channel.
    YUY2, // A format that uses the YUV color space and is often used for video encoding or playback.
    RGB9e5Float, // RGB HDR format, with 9 bit mantissa per channel and a 5 bit shared exponent.
    BC4, // Compressed one channel (R) texture format.
    BC5, // Compressed two-channel (RG) texture format.
    BC6H, // HDR compressed color texture format.
    BC7, // High quality compressed color texture format.
    DXT1Crunched, // Compressed color texture format with Crunch compression for smaller storage sizes.
    DXT5Crunched, // Compressed color with alpha channel texture format with Crunch compression for smaller storage sizes.
    PVRTC_RGB2, // PowerVR (iOS) 2 bits/pixel compressed color texture format.
    PVRTC_RGBA2, // PowerVR (iOS) 2 bits/pixel compressed with alpha channel texture format.
    PVRTC_RGB4, // PowerVR (iOS) 4 bits/pixel compressed color texture format.
    PVRTC_RGBA4, // PowerVR (iOS) 4 bits/pixel compressed with alpha channel texture format.
    ETC_RGB4, // ETC (GLES2.0) 4 bits/pixel compressed RGB texture format.
    EAC_R, // ETC2 / EAC (GL ES 3.0) 4 bits/pixel compressed unsigned single-channel texture format.
    EAC_R_SIGNED, // ETC2 / EAC (GL ES 3.0) 4 bits/pixel compressed signed single-channel texture format.
    EAC_RG, // ETC2 / EAC (GL ES 3.0) 8 bits/pixel compressed unsigned dual-channel (RG) texture format.
    EAC_RG_SIGNED, // ETC2 / EAC (GL ES 3.0) 8 bits/pixel compressed signed dual-channel (RG) texture format.
    ETC2_RGB, // ETC2 (GL ES 3.0) 4 bits/pixel compressed RGB texture format.
    ETC2_RGBA1, // ETC2 (GL ES 3.0) 4 bits/pixel RGB+1-bit alpha texture format.
    ETC2_RGBA8, // ETC2 (GL ES 3.0) 8 bits/pixel compressed RGBA texture format.
    ASTC_4x4, // ASTC (4x4 pixel block in 128 bits) compressed RGB(A) texture format.
    ASTC_5x5, // ASTC (5x5 pixel block in 128 bits) compressed RGB(A) texture format.
    ASTC_6x6, // ASTC (6x6 pixel block in 128 bits) compressed RGB(A) texture format.
    ASTC_8x8, // ASTC (8x8 pixel block in 128 bits) compressed RGB(A) texture format.
    ASTC_10x10, // ASTC (10x10 pixel block in 128 bits) compressed RGB(A) texture format.
    ASTC_12x12, // ASTC (12x12 pixel block in 128 bits) compressed RGB(A) texture format.
    RG16, // Two color (RG) texture format, 8-bits per channel.
    R8, // Single channel (R) texture format, 8 bit integer.
    ETC_RGB4Crunched, // Compressed color texture format with Crunch compression for smaller storage sizes.
    ETC2_RGBA8Crunched, // Compressed color with alpha channel texture format using Crunch compression for smaller storage sizes.
    ASTC_HDR_4x4, // ASTC (4x4 pixel block in 128 bits) compressed RGB(A) HDR texture format.
    ASTC_HDR_5x5, // ASTC (5x5 pixel block in 128 bits) compressed RGB(A) HDR texture format.
    ASTC_HDR_6x6, // ASTC (6x6 pixel block in 128 bits) compressed RGB(A) HDR texture format.
    ASTC_HDR_8x8, // ASTC (8x8 pixel block in 128 bits) compressed RGB(A) texture format.
    ASTC_HDR_10x10, // ASTC (10x10 pixel block in 128 bits) compressed RGB(A) HDR texture format.
    ASTC_HDR_12x12, // ASTC (12x12 pixel block in 128 bits) compressed RGB(A) HDR texture format.
    RG32, // Two channel (RG) texture format, 16 bit integer per channel.
    RGB48, // Three channel (RGB) texture format, 16 bit integer per channel.
    RGBA64, // Four channel (RGBA) texture format, 16 bit integer per channel.
}
