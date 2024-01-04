namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Material (12 fields) AC9800C6508BA266DB8005AA8C01BF11 */
public record class Material(
    AsciiString m_Name /* None */,
    PPtr<Shader> m_Shader /* NeedsAlign */,
    AsciiString[] m_ValidKeywords /* None */,
    AsciiString[] m_InvalidKeywords /* NeedsAlign */,
    uint m_LightmapFlags /* NeedsAlign */,
    bool m_EnableInstancingVariants /* None */,
    bool m_DoubleSidedGI /* None */,
    int m_CustomRenderQueue /* NeedsAlign */,
    Dictionary<AsciiString, AsciiString> stringTagMap /* None */,
    AsciiString[] disabledShaderPasses /* NeedsAlign */,
    UnityPropertySheet m_SavedProperties /* NeedsAlign */,
    BuildTextureStackReference[] m_BuildTextureStacks /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2895642822, 1351328358, 3682600362, 2348924689);
    public static Material Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Shader */
        PPtr<Shader> _m_Shader = PPtr<Shader>.Read(reader);
        AsciiString[] _m_ValidKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_InvalidKeywords */
        AsciiString[] _m_InvalidKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_LightmapFlags */
        uint _m_LightmapFlags = reader.ReadU32();
        bool _m_EnableInstancingVariants = reader.ReadBool();
        bool _m_DoubleSidedGI = reader.ReadBool();
        reader.AlignTo(4); /* m_CustomRenderQueue */
        int _m_CustomRenderQueue = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> _stringTagMap = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* disabledShaderPasses */
        AsciiString[] _disabledShaderPasses = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_SavedProperties */
        UnityPropertySheet _m_SavedProperties = UnityPropertySheet.Read(reader);
        reader.AlignTo(4); /* m_BuildTextureStacks */
        BuildTextureStackReference[] _m_BuildTextureStacks = BuiltInArray<BuildTextureStackReference>.Read(reader);
        
        return new(_m_Name,
            _m_Shader,
            _m_ValidKeywords,
            _m_InvalidKeywords,
            _m_LightmapFlags,
            _m_EnableInstancingVariants,
            _m_DoubleSidedGI,
            _m_CustomRenderQueue,
            _stringTagMap,
            _disabledShaderPasses,
            _m_SavedProperties,
            _m_BuildTextureStacks);
    }
}

