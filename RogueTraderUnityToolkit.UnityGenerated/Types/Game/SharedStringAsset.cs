namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SharedStringAsset (5 fields) 61178B04221A50E2BD25ECD5A9B702D6/5C15E369908E9C75599B2CD4DF6B2CDA */
public record class SharedStringAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString String /* NeedsAlign */)
{
    public static SharedStringAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* String */
        LocalizedString _String = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _String);
    }
}

