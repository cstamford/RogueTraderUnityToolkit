namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LightDependencyController (5 fields) F73A7BEE1A743BADA0F7D3BAD071D8A1/37A11CB6ADB8FB184924F31D3652C290 */
public record class LightDependencyController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject>[] dependentObjects /* NeedsAlign */)
{
    public static LightDependencyController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* dependentObjects */
        PPtr<GameObject>[] _dependentObjects = BuiltInArray<PPtr<GameObject>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _dependentObjects);
    }
}

