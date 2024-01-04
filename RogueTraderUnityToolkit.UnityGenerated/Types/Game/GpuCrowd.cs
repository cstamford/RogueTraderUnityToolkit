namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GpuCrowd (9 fields) 7EAA3A13C75083BCDBA442E4BF7AADEE/CB15BB2A597726E7399BAF96B93EA86A */
public record class GpuCrowd(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VisualEffect> CrowdVfx /* NeedsAlign */,
    PPtr<GpuCrowdLocator>[] CrowdLocators /* None */,
    PPtr<Texture2D> PositionsTexture /* None */,
    PPtr<Texture2D> RotationsTexture /* None */,
    byte DrawGizmos /* None */)
{
    public static GpuCrowd Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CrowdVfx */
        PPtr<VisualEffect> _CrowdVfx = PPtr<VisualEffect>.Read(reader);
        PPtr<GpuCrowdLocator>[] _CrowdLocators = BuiltInArray<PPtr<GpuCrowdLocator>>.Read(reader);
        PPtr<Texture2D> _PositionsTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _RotationsTexture = PPtr<Texture2D>.Read(reader);
        byte _DrawGizmos = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CrowdVfx,
            _CrowdLocators,
            _PositionsTexture,
            _RotationsTexture,
            _DrawGizmos);
    }
}

