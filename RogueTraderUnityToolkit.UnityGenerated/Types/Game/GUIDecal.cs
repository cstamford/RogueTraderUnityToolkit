namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GUIDecal (10 fields) 645075CCBD1A15AC0DEF27A8A64A25B7/87916DDE5B4D81D62D8D7F6B1BC558B3 */
public record class GUIDecal(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> m_Material /* NeedsAlign */,
    int m_Layer /* None */,
    byte m_ValidateHeight /* None */,
    BitField m_RaycastMask /* NeedsAlign */,
    ColorRGBA m_NormalColor /* None */,
    ColorRGBA m_SelfColor /* None */)
{
    public static GUIDecal Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Material */
        PPtr<Material> _m_Material = PPtr<Material>.Read(reader);
        int _m_Layer = reader.ReadS32();
        byte _m_ValidateHeight = reader.ReadU8();
        reader.AlignTo(4); /* m_RaycastMask */
        BitField _m_RaycastMask = BitField.Read(reader);
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _m_SelfColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Material,
            _m_Layer,
            _m_ValidateHeight,
            _m_RaycastMask,
            _m_NormalColor,
            _m_SelfColor);
    }
}

