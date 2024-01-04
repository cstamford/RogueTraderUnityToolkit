namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $VisualEffect (9 fields) 511CF571F43A5F0DAF0E3962651E58EB */
public record class VisualEffect(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<VisualEffectAsset> m_Asset /* NeedsAlign */,
    AsciiString m_InitialEventName /* None */,
    byte m_InitialEventNameOverriden /* NeedsAlign */,
    uint m_StartSeed /* NeedsAlign */,
    byte m_ResetSeedOnPlay /* None */,
    byte m_AllowInstancing /* None */,
    VFXPropertySheetSerializedBase m_PropertySheet /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(1360852337, 4097466125, 2936944994, 1696487659);
    public static VisualEffect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Asset */
        PPtr<VisualEffectAsset> _m_Asset = PPtr<VisualEffectAsset>.Read(reader);
        AsciiString _m_InitialEventName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InitialEventNameOverriden */
        byte _m_InitialEventNameOverriden = reader.ReadU8();
        reader.AlignTo(4); /* m_StartSeed */
        uint _m_StartSeed = reader.ReadU32();
        byte _m_ResetSeedOnPlay = reader.ReadU8();
        byte _m_AllowInstancing = reader.ReadU8();
        reader.AlignTo(4); /* m_PropertySheet */
        VFXPropertySheetSerializedBase _m_PropertySheet = VFXPropertySheetSerializedBase.Read(reader);
        
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
}

