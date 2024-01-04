namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationDecoratorObject (8 fields) 86242BE51AA84313555D10C14AF0759A/E1BE3D253C1AC3E7F1A98ABC7ED7E590 */
public record class UnitAnimationDecoratorObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte UseGender /* NeedsAlign */,
    int gender /* NeedsAlign */,
    float Duration /* None */,
    DecoratorEntry[] Entries /* None */)
{
    public static UnitAnimationDecoratorObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* UseGender */
        byte _UseGender = reader.ReadU8();
        reader.AlignTo(4); /* gender */
        int _gender = reader.ReadS32();
        float _Duration = reader.ReadF32();
        DecoratorEntry[] _Entries = BuiltInArray<DecoratorEntry>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _UseGender,
            _gender,
            _Duration,
            _Entries);
    }
}

