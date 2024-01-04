namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXOwlcatSkinningBinder (11 fields) 246C3FF7370BAD9BB739D017287D1551/353BB53B26DF008A5798962E6DF36DEC */
public record class VFXOwlcatSkinningBinder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ExposedProperty SkinningTexture /* NeedsAlign */,
    ExposedProperty SkinningFps /* NeedsAlign */,
    ExposedProperty SkinningBonesCount /* NeedsAlign */,
    ExposedProperty SkinningClipsCount /* NeedsAlign */,
    ExposedProperty SkinningFramesOffset /* NeedsAlign */,
    ExposedProperty SkinningFramesCount /* NeedsAlign */,
    PPtr<GPUSkinningAnimation> GPUSkinningAnimation /* NeedsAlign */)
{
    public static VFXOwlcatSkinningBinder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SkinningTexture */
        ExposedProperty _SkinningTexture = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* SkinningFps */
        ExposedProperty _SkinningFps = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* SkinningBonesCount */
        ExposedProperty _SkinningBonesCount = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* SkinningClipsCount */
        ExposedProperty _SkinningClipsCount = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* SkinningFramesOffset */
        ExposedProperty _SkinningFramesOffset = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* SkinningFramesCount */
        ExposedProperty _SkinningFramesCount = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* GPUSkinningAnimation */
        PPtr<GPUSkinningAnimation> _GPUSkinningAnimation = PPtr<GPUSkinningAnimation>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SkinningTexture,
            _SkinningFps,
            _SkinningBonesCount,
            _SkinningClipsCount,
            _SkinningFramesOffset,
            _SkinningFramesCount,
            _GPUSkinningAnimation);
    }
}

