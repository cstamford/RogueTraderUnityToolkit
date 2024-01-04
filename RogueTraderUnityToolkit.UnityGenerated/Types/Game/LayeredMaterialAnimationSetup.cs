namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LayeredMaterialAnimationSetup (17 fields) CE0BA7D5E83640BEED2B163B355A72AC/212CC811186DA7244451A237EE1290E4 */
public record class LayeredMaterialAnimationSetup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_FormatVersion /* NeedsAlign */,
    int m_Priority /* None */,
    int m_RendererTypeFilter /* None */,
    int m_RendererTypeMask /* None */,
    PPtr<Material> m_Material /* None */,
    float m_Duration /* None */,
    float m_Delay /* None */,
    FloatPropertyAnimationData[] m_FloatClips /* None */,
    ColorPropertyAnimationData[] m_ColorClips /* NeedsAlign */,
    TexturePropertyAnimationData[] m_TextureClips /* NeedsAlign */,
    TransformPropertyAnimationData[] m_TransformClips /* NeedsAlign */,
    TransferMaterialPropertyAnimationData[] m_TransferMaterialPropertyClips /* NeedsAlign */,
    TransferScriptPropertyAnimationData[] m_TransferScriptPropertyClips /* NeedsAlign */)
{
    public static LayeredMaterialAnimationSetup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FormatVersion */
        int _m_FormatVersion = reader.ReadS32();
        int _m_Priority = reader.ReadS32();
        int _m_RendererTypeFilter = reader.ReadS32();
        int _m_RendererTypeMask = reader.ReadS32();
        PPtr<Material> _m_Material = PPtr<Material>.Read(reader);
        float _m_Duration = reader.ReadF32();
        float _m_Delay = reader.ReadF32();
        FloatPropertyAnimationData[] _m_FloatClips = BuiltInArray<FloatPropertyAnimationData>.Read(reader);
        reader.AlignTo(4); /* m_ColorClips */
        ColorPropertyAnimationData[] _m_ColorClips = BuiltInArray<ColorPropertyAnimationData>.Read(reader);
        reader.AlignTo(4); /* m_TextureClips */
        TexturePropertyAnimationData[] _m_TextureClips = BuiltInArray<TexturePropertyAnimationData>.Read(reader);
        reader.AlignTo(4); /* m_TransformClips */
        TransformPropertyAnimationData[] _m_TransformClips = BuiltInArray<TransformPropertyAnimationData>.Read(reader);
        reader.AlignTo(4); /* m_TransferMaterialPropertyClips */
        TransferMaterialPropertyAnimationData[] _m_TransferMaterialPropertyClips = BuiltInArray<TransferMaterialPropertyAnimationData>.Read(reader);
        reader.AlignTo(4); /* m_TransferScriptPropertyClips */
        TransferScriptPropertyAnimationData[] _m_TransferScriptPropertyClips = BuiltInArray<TransferScriptPropertyAnimationData>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FormatVersion,
            _m_Priority,
            _m_RendererTypeFilter,
            _m_RendererTypeMask,
            _m_Material,
            _m_Duration,
            _m_Delay,
            _m_FloatClips,
            _m_ColorClips,
            _m_TextureClips,
            _m_TransformClips,
            _m_TransferMaterialPropertyClips,
            _m_TransferScriptPropertyClips);
    }
}

