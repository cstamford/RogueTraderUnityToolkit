namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $_2dxFX_DesintegrationFX (9 fields) 23AFB5FAFBCBC018EE05A879F0102D66/DE46CDFAF83B1E9A61C84790BA7F6C26 */
public record class _2dxFX_DesintegrationFX(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> ForceMaterial /* NeedsAlign */,
    float _Alpha /* None */,
    ColorRGBA _Color /* None */,
    float Seed /* None */,
    float Desintegration /* None */)
{
    public static _2dxFX_DesintegrationFX Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ForceMaterial */
        PPtr<Material> _ForceMaterial = PPtr<Material>.Read(reader);
        float __Alpha = reader.ReadF32();
        ColorRGBA __Color = ColorRGBA.Read(reader);
        float _Seed = reader.ReadF32();
        float _Desintegration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ForceMaterial,
            __Alpha,
            __Color,
            _Seed,
            _Desintegration);
    }
}

