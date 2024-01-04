namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StandardMaterialController (9 fields) 212DFDCA93006D57CDE4E336042FA1D5/067BFAC34D8BFE062F33819E57669179 */
public record class StandardMaterialController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorTintAnimationController m_ColorTintController /* NeedsAlign */,
    RimLightingAnimationController m_RimController /* NeedsAlign */,
    DissolveAnimationController m_DissolveController /* NeedsAlign */,
    AdditionalAlbedoAnimationController m_AdditionalAlbedoController /* NeedsAlign */,
    MaterialParametersOverrideController m_MaterialParametersOverrideController /* NeedsAlign */)
{
    public static StandardMaterialController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColorTintController */
        ColorTintAnimationController _m_ColorTintController = ColorTintAnimationController.Read(reader);
        reader.AlignTo(4); /* m_RimController */
        RimLightingAnimationController _m_RimController = RimLightingAnimationController.Read(reader);
        reader.AlignTo(4); /* m_DissolveController */
        DissolveAnimationController _m_DissolveController = DissolveAnimationController.Read(reader);
        reader.AlignTo(4); /* m_AdditionalAlbedoController */
        AdditionalAlbedoAnimationController _m_AdditionalAlbedoController = AdditionalAlbedoAnimationController.Read(reader);
        reader.AlignTo(4); /* m_MaterialParametersOverrideController */
        MaterialParametersOverrideController _m_MaterialParametersOverrideController = MaterialParametersOverrideController.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColorTintController,
            _m_RimController,
            _m_DissolveController,
            _m_AdditionalAlbedoController,
            _m_MaterialParametersOverrideController);
    }
}

