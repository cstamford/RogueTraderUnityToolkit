namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RectMask2D (6 fields) 276C002B5EE595B5E7E02D1174353313/0ED9C8CDCE5B1D0809BFEA198F75C1AC */
public record class RectMask2D(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector4f m_Padding /* NeedsAlign */,
    int2_storage m_Softness /* None */)
{
    public static RectMask2D Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Padding */
        Vector4f _m_Padding = Vector4f.Read(reader);
        int2_storage _m_Softness = int2_storage.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Padding,
            _m_Softness);
    }
}

