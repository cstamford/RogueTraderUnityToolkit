namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXOwlcatTransformTarget (6 fields) 6805D16EADDBB902FD503431490A4052/2963F4FB4EF29FE4731445A6978F83E6 */
public record class VFXOwlcatTransformTarget(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte LightDependency /* NeedsAlign */,
    PPtr<Transform>[] Targets /* NeedsAlign */)
{
    public static VFXOwlcatTransformTarget Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LightDependency */
        byte _LightDependency = reader.ReadU8();
        reader.AlignTo(4); /* Targets */
        PPtr<Transform>[] _Targets = BuiltInArray<PPtr<Transform>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _LightDependency,
            _Targets);
    }
}

