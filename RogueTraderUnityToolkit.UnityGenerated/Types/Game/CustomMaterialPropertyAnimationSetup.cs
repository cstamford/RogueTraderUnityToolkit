namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CustomMaterialPropertyAnimationSetup (5 fields) 906E49EB52B80AD2C91F997C61784AFF/F6B5F68198F10D1F020C85FF196F3555 */
public record class CustomMaterialPropertyAnimationSetup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Clip[] Clips /* NeedsAlign */)
{
    public static CustomMaterialPropertyAnimationSetup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Clips */
        Clip[] _Clips = BuiltInArray<Clip>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Clips);
    }
}

