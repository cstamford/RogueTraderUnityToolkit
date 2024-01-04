namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterBonesSetup (5 fields) 78F57DE50C0CF4556B2D362A48D6F1A6/DE969AB91354684A9087734B6D113CD5 */
public record class CharacterBonesSetup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString[] KnownTransformNames /* NeedsAlign */)
{
    public static CharacterBonesSetup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* KnownTransformNames */
        AsciiString[] _KnownTransformNames = BuiltInArray<AsciiString>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _KnownTransformNames);
    }
}

