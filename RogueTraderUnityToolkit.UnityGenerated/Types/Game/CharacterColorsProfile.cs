namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterColorsProfile (5 fields) EA0B95CD88ECCF6BA834F31E43B58245/DF7C8F5139FBBB9F82193E4A7792193B */
public record class CharacterColorsProfile(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Texture2D>[] Ramps /* NeedsAlign */)
{
    public static CharacterColorsProfile Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Ramps */
        PPtr<Texture2D>[] _Ramps = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Ramps);
    }
}

