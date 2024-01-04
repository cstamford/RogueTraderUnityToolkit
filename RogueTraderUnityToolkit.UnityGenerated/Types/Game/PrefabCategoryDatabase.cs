namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrefabCategoryDatabase (5 fields) 46F8D46611FBB2364848175A767F99E2/163ED7A4AEFC1136D31491CBDB7DCCFA */
public record class PrefabCategoryDatabase(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PrefabCategoryCollection _prefabCategories /* NeedsAlign */)
{
    public static PrefabCategoryDatabase Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _prefabCategories */
        PrefabCategoryCollection __prefabCategories = PrefabCategoryCollection.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __prefabCategories);
    }
}

