namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ChildForwardProceduralAnimation (6 fields) 470C1420EBCE0A92CEB812DEE755A00F/437815614F3F1169859047C0F9010671 */
public record class ChildForwardProceduralAnimation(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TimeOfAppearance /* NeedsAlign */,
    float StartOffset /* None */)
{
    public static ChildForwardProceduralAnimation Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TimeOfAppearance */
        float _TimeOfAppearance = reader.ReadF32();
        float _StartOffset = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TimeOfAppearance,
            _StartOffset);
    }
}

