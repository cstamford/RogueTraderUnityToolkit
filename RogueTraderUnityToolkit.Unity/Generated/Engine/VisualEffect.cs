namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $VisualEffect (9 fields) (IsEngineType) */
public record class VisualEffect(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<VisualEffectAsset> m_Asset,
    AsciiString m_InitialEventName,
    byte m_InitialEventNameOverriden,
    uint m_StartSeed,
    byte m_ResetSeedOnPlay,
    byte m_AllowInstancing,
    VFXPropertySheetSerializedBase m_PropertySheet)
{
    public static VisualEffect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<VisualEffectAsset> m_Asset = PPtr<VisualEffectAsset>.Read(reader);
        AsciiString m_InitialEventName = String.Read(reader);
        byte m_InitialEventNameOverriden = reader.ReadU8();
        uint m_StartSeed = reader.ReadU32();
        byte m_ResetSeedOnPlay = reader.ReadU8();
        byte m_AllowInstancing = reader.ReadU8();
        VFXPropertySheetSerializedBase m_PropertySheet = VFXPropertySheetSerializedBase.Read(reader);
        
        return new(m_GameObject,
            m_Enabled,
            m_Asset,
            m_InitialEventName,
            m_InitialEventNameOverriden,
            m_StartSeed,
            m_ResetSeedOnPlay,
            m_AllowInstancing,
            m_PropertySheet);
    }
}

