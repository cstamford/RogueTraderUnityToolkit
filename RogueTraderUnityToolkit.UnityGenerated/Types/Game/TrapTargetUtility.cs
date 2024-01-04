namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TrapTargetUtility (8 fields) C68C57B0DC250EB0290BE2C23B2DF4EE/08E3B9AA6ECE5DF898343F76A9BEADAC */
public record class TrapTargetUtility(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ScriptZonePolygon> _polygon /* NeedsAlign */,
    BitField RaycastLayers /* None */,
    float RaycastHeightOffset /* None */,
    float Height /* None */)
{
    public static TrapTargetUtility Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _polygon */
        PPtr<ScriptZonePolygon> __polygon = PPtr<ScriptZonePolygon>.Read(reader);
        BitField _RaycastLayers = BitField.Read(reader);
        float _RaycastHeightOffset = reader.ReadF32();
        float _Height = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __polygon,
            _RaycastLayers,
            _RaycastHeightOffset,
            _Height);
    }
}

