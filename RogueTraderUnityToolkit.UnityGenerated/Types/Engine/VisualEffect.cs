namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VisualEffect (9 fields) 511CF571F43A5F0DAF0E3962651E58EB */
public record class VisualEffect(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<VisualEffectAsset> m_Asset,
    AsciiString m_InitialEventName,
    byte m_InitialEventNameOverriden,
    uint m_StartSeed,
    byte m_ResetSeedOnPlay,
    byte m_AllowInstancing,
    VFXPropertySheetSerializedBase_0 m_PropertySheet) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1360852337, 4097466125, 2936944994, 1696487659);

    public static VisualEffect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<VisualEffectAsset> _m_Asset = PPtr<VisualEffectAsset>.Read(reader);
        AsciiString _m_InitialEventName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InitialEventName */
        byte _m_InitialEventNameOverriden = reader.ReadU8();
        reader.AlignTo(4); /* m_InitialEventNameOverriden */
        uint _m_StartSeed = reader.ReadU32();
        byte _m_ResetSeedOnPlay = reader.ReadU8();
        byte _m_AllowInstancing = reader.ReadU8();
        reader.AlignTo(4); /* m_AllowInstancing */
        VFXPropertySheetSerializedBase_0 _m_PropertySheet = VFXPropertySheetSerializedBase_0.Read(reader);
        reader.AlignTo(4); /* m_PropertySheet */
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Asset,
            _m_InitialEventName,
            _m_InitialEventNameOverriden,
            _m_StartSeed,
            _m_ResetSeedOnPlay,
            _m_AllowInstancing,
            _m_PropertySheet);
    }

    public override string ToString() => $"VisualEffect\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Asset: ");
        sb.AppendLine(m_Asset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InitialEventName: ");
        sb.AppendLine(m_InitialEventName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InitialEventNameOverriden: ");
        sb.AppendLine(m_InitialEventNameOverriden.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StartSeed: ");
        sb.AppendLine(m_StartSeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ResetSeedOnPlay: ");
        sb.AppendLine(m_ResetSeedOnPlay.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AllowInstancing: ");
        sb.AppendLine(m_AllowInstancing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PropertySheet: ");
        sb.AppendLine();
        sb.Append(m_PropertySheet.ToString(indent+4));

        return sb.ToString();
    }
}

