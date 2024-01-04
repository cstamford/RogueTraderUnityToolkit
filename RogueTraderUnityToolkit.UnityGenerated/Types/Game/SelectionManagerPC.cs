namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SelectionManagerPC (5 fields) 9A8B2AF99B1AFB7DF022D6283E0ED9E0/B3223852FE3449D16F6DFC52DE634BDB */
public record class SelectionManagerPC(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BaseUnitMark> m_SelectionMarkPrefab /* NeedsAlign */)
{
    public static SelectionManagerPC Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SelectionMarkPrefab */
        PPtr<BaseUnitMark> _m_SelectionMarkPrefab = PPtr<BaseUnitMark>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SelectionMarkPrefab);
    }
}

