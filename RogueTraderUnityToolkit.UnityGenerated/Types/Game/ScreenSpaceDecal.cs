namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScreenSpaceDecal (8 fields) AD5CBAECBB20F2EF6E201058F37F880B/2F70A5374F4D18D80CADEC395142BE12 */
public record class ScreenSpaceDecal(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> m_Material /* NeedsAlign */,
    int m_Layer /* None */,
    byte m_ValidateHeight /* None */,
    BitField m_RaycastMask /* NeedsAlign */)
{
    public static ScreenSpaceDecal Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Material,
            _m_Layer,
            _m_ValidateHeight,
            _m_RaycastMask);
    }
}

