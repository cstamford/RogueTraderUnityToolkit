namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $BuildSettings (20 fields) BuildSettings 0CDC11E1487707EEAF408BB90FBC06C0 */
public record class BuildSettings (
    AsciiString[] scenes,
    AsciiString[] preloadedPlugins,
    AsciiString[] enabledVRDevices,
    AsciiString[] buildTags,
    bool hasPROVersion,
    bool isNoWatermarkBuild,
    bool isPrototypingBuild,
    bool isEducationalBuild,
    bool isEmbedded,
    bool isTrial,
    bool hasPublishingRights,
    bool hasShadows,
    bool hasSoftShadows,
    bool hasLocalLightShadows,
    bool hasAdvancedVersion,
    bool enableDynamicBatching,
    bool usesOnMouseEvents,
    bool hasClusterRendering,
    AsciiString m_Version,
    int[] m_GraphicsAPIs) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.BuildSettings;
    public static Hash128 Hash => new("0CDC11E1487707EEAF408BB90FBC06C0");
    public static BuildSettings Read(EndianBinaryReader reader)
    {
        AsciiString[] scenes_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* scenes */
        AsciiString[] preloadedPlugins_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* preloadedPlugins */
        AsciiString[] enabledVRDevices_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* enabledVRDevices */
        AsciiString[] buildTags_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* buildTags */
        bool hasPROVersion_ = reader.ReadBool();
        bool isNoWatermarkBuild_ = reader.ReadBool();
        bool isPrototypingBuild_ = reader.ReadBool();
        bool isEducationalBuild_ = reader.ReadBool();
        bool isEmbedded_ = reader.ReadBool();
        bool isTrial_ = reader.ReadBool();
        bool hasPublishingRights_ = reader.ReadBool();
        bool hasShadows_ = reader.ReadBool();
        bool hasSoftShadows_ = reader.ReadBool();
        bool hasLocalLightShadows_ = reader.ReadBool();
        bool hasAdvancedVersion_ = reader.ReadBool();
        bool enableDynamicBatching_ = reader.ReadBool();
        bool usesOnMouseEvents_ = reader.ReadBool();
        bool hasClusterRendering_ = reader.ReadBool();
        reader.AlignTo(4); /* hasClusterRendering */
        AsciiString m_Version_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Version */
        int[] m_GraphicsAPIs_ = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_GraphicsAPIs */
        
        return new(scenes_,
            preloadedPlugins_,
            enabledVRDevices_,
            buildTags_,
            hasPROVersion_,
            isNoWatermarkBuild_,
            isPrototypingBuild_,
            isEducationalBuild_,
            isEmbedded_,
            isTrial_,
            hasPublishingRights_,
            hasShadows_,
            hasSoftShadows_,
            hasLocalLightShadows_,
            hasAdvancedVersion_,
            enableDynamicBatching_,
            usesOnMouseEvents_,
            hasClusterRendering_,
            m_Version_,
            m_GraphicsAPIs_);
    }

    public override string ToString() => $"BuildSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}scenes[{scenes.Length}] = {{");
        if (scenes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in scenes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (scenes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}preloadedPlugins[{preloadedPlugins.Length}] = {{");
        if (preloadedPlugins.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in preloadedPlugins)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (preloadedPlugins.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}enabledVRDevices[{enabledVRDevices.Length}] = {{");
        if (enabledVRDevices.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in enabledVRDevices)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (enabledVRDevices.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}buildTags[{buildTags.Length}] = {{");
        if (buildTags.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in buildTags)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (buildTags.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasPROVersion: {hasPROVersion}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isNoWatermarkBuild: {isNoWatermarkBuild}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isPrototypingBuild: {isPrototypingBuild}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isEducationalBuild: {isEducationalBuild}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isEmbedded: {isEmbedded}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isTrial: {isTrial}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasPublishingRights: {hasPublishingRights}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasShadows: {hasShadows}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasSoftShadows: {hasSoftShadows}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasLocalLightShadows: {hasLocalLightShadows}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasAdvancedVersion: {hasAdvancedVersion}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enableDynamicBatching: {enableDynamicBatching}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}usesOnMouseEvents: {usesOnMouseEvents}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hasClusterRendering: {hasClusterRendering}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Version: \"{m_Version}\"");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_GraphicsAPIs[{m_GraphicsAPIs.Length}] = {{");
        if (m_GraphicsAPIs.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_GraphicsAPIs)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_GraphicsAPIs.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}

