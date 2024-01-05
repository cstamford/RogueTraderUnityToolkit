namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Material (12 fields) AC9800C6508BA266DB8005AA8C01BF11 */
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
    BuildTextureStackReference[] m_BuildTextureStacks) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2895642822, 1351328358, 3682600362, 2348924689);

    public static Material Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Shader> _m_Shader = PPtr<Shader>.Read(reader);
        AsciiString[] _m_ValidKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_ValidKeywords */
        AsciiString[] _m_InvalidKeywords = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_InvalidKeywords */
        uint _m_LightmapFlags = reader.ReadU32();
        bool _m_EnableInstancingVariants = reader.ReadBool();
        bool _m_DoubleSidedGI = reader.ReadBool();
        reader.AlignTo(4); /* m_DoubleSidedGI */
        int _m_CustomRenderQueue = reader.ReadS32();
        Dictionary<AsciiString, AsciiString> _stringTagMap = BuiltInMap<AsciiString, AsciiString>.Read(reader);
        reader.AlignTo(4); /* stringTagMap */
        AsciiString[] _disabledShaderPasses = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* disabledShaderPasses */
        UnityPropertySheet _m_SavedProperties = UnityPropertySheet.Read(reader);
        reader.AlignTo(4); /* m_SavedProperties */
        BuildTextureStackReference[] _m_BuildTextureStacks = BuiltInArray<BuildTextureStackReference>.Read(reader);
        reader.AlignTo(4); /* m_BuildTextureStacks */
        
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

    public override string ToString() => $"Material\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Shader: ");
        sb.AppendLine(m_Shader.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ValidKeywords: ");
        sb.AppendLine(m_ValidKeywords.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InvalidKeywords: ");
        sb.AppendLine(m_InvalidKeywords.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapFlags: ");
        sb.AppendLine(m_LightmapFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableInstancingVariants: ");
        sb.AppendLine(m_EnableInstancingVariants.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DoubleSidedGI: ");
        sb.AppendLine(m_DoubleSidedGI.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CustomRenderQueue: ");
        sb.AppendLine(m_CustomRenderQueue.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stringTagMap: ");
        sb.AppendLine(stringTagMap.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("disabledShaderPasses: ");
        sb.AppendLine(disabledShaderPasses.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SavedProperties: ");
        sb.AppendLine();
        sb.Append(m_SavedProperties.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BuildTextureStacks: ");
        sb.AppendLine(m_BuildTextureStacks.ToString());

        return sb.ToString();
    }
}

