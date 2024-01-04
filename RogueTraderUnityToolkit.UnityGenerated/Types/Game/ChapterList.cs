namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ChapterList (5 fields) D0BA71665E1B0AFDFB7E7C0C72844F46/945BBBF0C73A4B4F44BD86A41FFC13C7 */
public record class ChapterList(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintEncyclopediaChapterReference[] m_List /* NeedsAlign */)
{
    public static ChapterList Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_List */
        BlueprintEncyclopediaChapterReference[] _m_List = BuiltInArray<BlueprintEncyclopediaChapterReference>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_List);
    }
}

