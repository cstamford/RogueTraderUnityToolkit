namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ConsoleHintsWidget (8 fields) B51C8CA6B6193ABDDF49CE2267858F06/614CDE2439378917F63E9F2DA30235FA */
public record class ConsoleHintsWidget(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ConsoleHint> m_ConsoleHintPrefab /* NeedsAlign */,
    PPtr<Transform> m_LeftHintsContainer /* None */,
    PPtr<Transform> m_CenterHintsContainer /* None */,
    PPtr<Transform> m_RightHintsContainer /* None */)
{
    public static ConsoleHintsWidget Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ConsoleHintPrefab */
        PPtr<ConsoleHint> _m_ConsoleHintPrefab = PPtr<ConsoleHint>.Read(reader);
        PPtr<Transform> _m_LeftHintsContainer = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_CenterHintsContainer = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_RightHintsContainer = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ConsoleHintPrefab,
            _m_LeftHintsContainer,
            _m_CenterHintsContainer,
            _m_RightHintsContainer);
    }
}

