namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GPUSkinningAnimation (9 fields) A259128FE218F3AF2CF8C8C5EC24A448/FC625BC7D0CE3652EC04B5D4638D2657 */
public record class GPUSkinningAnimation(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString m_PrefabId /* NeedsAlign */,
    int BakeFPS /* NeedsAlign */,
    int BonesCount /* None */,
    GPUAnimationClip[] AnimationClips /* None */,
    PPtr<Texture2D> AnimationTexture /* NeedsAlign */)
{
    public static GPUSkinningAnimation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PrefabId */
        AsciiString _m_PrefabId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BakeFPS */
        int _BakeFPS = reader.ReadS32();
        int _BonesCount = reader.ReadS32();
        GPUAnimationClip[] _AnimationClips = BuiltInArray<GPUAnimationClip>.Read(reader);
        reader.AlignTo(4); /* AnimationTexture */
        PPtr<Texture2D> _AnimationTexture = PPtr<Texture2D>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PrefabId,
            _BakeFPS,
            _BonesCount,
            _AnimationClips,
            _AnimationTexture);
    }
}

