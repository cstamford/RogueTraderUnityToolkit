namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $UnityConnectSettings (12 fields) UnityConnectSettings D20A19A1F2AA3CE4E4364300D0BBE1BB */
public record class UnityConnectSettings (
    bool m_Enabled,
    bool m_TestMode,
    AsciiString m_EventOldUrl,
    AsciiString m_EventUrl,
    AsciiString m_ConfigUrl,
    AsciiString m_DashboardUrl,
    int m_TestInitMode,
    CrashReportingSettings CrashReportingSettings_,
    UnityPurchasingSettings UnityPurchasingSettings_,
    UnityAnalyticsSettings UnityAnalyticsSettings_,
    UnityAdsSettings UnityAdsSettings_,
    PerformanceReportingSettings PerformanceReportingSettings_) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.UnityConnectSettings;
    public static Hash128 Hash => new("D20A19A1F2AA3CE4E4364300D0BBE1BB");
    public static UnityConnectSettings Read(EndianBinaryReader reader)
    {
        bool m_Enabled_ = reader.ReadBool();
        bool m_TestMode_ = reader.ReadBool();
        reader.AlignTo(4); /* m_TestMode */
        AsciiString m_EventOldUrl_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EventOldUrl */
        AsciiString m_EventUrl_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EventUrl */
        AsciiString m_ConfigUrl_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ConfigUrl */
        AsciiString m_DashboardUrl_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DashboardUrl */
        int m_TestInitMode_ = reader.ReadS32();
        reader.AlignTo(4); /* m_TestInitMode */
        CrashReportingSettings CrashReportingSettings__ = CrashReportingSettings.Read(reader);
        reader.AlignTo(4); /* CrashReportingSettings_ */
        UnityPurchasingSettings UnityPurchasingSettings__ = UnityPurchasingSettings.Read(reader);
        reader.AlignTo(4); /* UnityPurchasingSettings_ */
        UnityAnalyticsSettings UnityAnalyticsSettings__ = UnityAnalyticsSettings.Read(reader);
        reader.AlignTo(4); /* UnityAnalyticsSettings_ */
        UnityAdsSettings UnityAdsSettings__ = UnityAdsSettings.Read(reader);
        reader.AlignTo(4); /* UnityAdsSettings_ */
        PerformanceReportingSettings PerformanceReportingSettings__ = PerformanceReportingSettings.Read(reader);
        reader.AlignTo(4); /* PerformanceReportingSettings_ */
        
        return new(m_Enabled_,
            m_TestMode_,
            m_EventOldUrl_,
            m_EventUrl_,
            m_ConfigUrl_,
            m_DashboardUrl_,
            m_TestInitMode_,
            CrashReportingSettings__,
            UnityPurchasingSettings__,
            UnityAnalyticsSettings__,
            UnityAdsSettings__,
            PerformanceReportingSettings__);
    }

    public override string ToString() => $"UnityConnectSettings\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TestMode: {m_TestMode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EventOldUrl: \"{m_EventOldUrl}\"");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EventUrl: \"{m_EventUrl}\"");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ConfigUrl: \"{m_ConfigUrl}\"");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DashboardUrl: \"{m_DashboardUrl}\"");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TestInitMode: {m_TestInitMode}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}CrashReportingSettings_: {{ \n{CrashReportingSettings_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}UnityPurchasingSettings_: {{ m_Enabled: {UnityPurchasingSettings_.m_Enabled}, m_TestMode: {UnityPurchasingSettings_.m_TestMode} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}UnityAnalyticsSettings_: {{ m_Enabled: {UnityAnalyticsSettings_.m_Enabled}, m_TestMode: {UnityAnalyticsSettings_.m_TestMode}, m_InitializeOnStartup: {UnityAnalyticsSettings_.m_InitializeOnStartup}, m_PackageRequiringCoreStatsPresent: {UnityAnalyticsSettings_.m_PackageRequiringCoreStatsPresent} }}\n");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}UnityAdsSettings_: {{ \n{UnityAdsSettings_.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}PerformanceReportingSettings_: {{ m_Enabled: {PerformanceReportingSettings_.m_Enabled} }}\n");
    }
}

