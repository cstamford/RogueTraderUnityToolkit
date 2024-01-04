namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScaleAnimator (8 fields) 94CA8E62AD61DB94905034027B5C3005/6458ADDB0E4195C80EE64B58B1CFFE0F */
public record class ScaleAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f m_BaseScale /* NeedsAlign */,
    Vector3f m_Scale /* None */,
    float m_ScaleTime /* None */,
    int m_LoopsCount /* None */)
{
    public static ScaleAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BaseScale */
        Vector3f _m_BaseScale = Vector3f.Read(reader);
        Vector3f _m_Scale = Vector3f.Read(reader);
        float _m_ScaleTime = reader.ReadF32();
        int _m_LoopsCount = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BaseScale,
            _m_Scale,
            _m_ScaleTime,
            _m_LoopsCount);
    }
}

