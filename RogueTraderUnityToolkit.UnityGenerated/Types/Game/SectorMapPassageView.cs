namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapPassageView (11 fields) AE27330700D70740C433FDEAD7C4A37D/533D5DB041EB5699A4180109591E7DD5 */
public record class SectorMapPassageView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<SectorMapObject> StarSystem1 /* NeedsAlign */,
    PPtr<SectorMapObject> StarSystem2 /* None */,
    int Difficulty /* None */,
    byte ShouldBeExploredFromBothSystems /* None */,
    byte IsExploredOnStart /* NeedsAlign */)
{
    public static SectorMapPassageView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* StarSystem1 */
        PPtr<SectorMapObject> _StarSystem1 = PPtr<SectorMapObject>.Read(reader);
        PPtr<SectorMapObject> _StarSystem2 = PPtr<SectorMapObject>.Read(reader);
        int _Difficulty = reader.ReadS32();
        byte _ShouldBeExploredFromBothSystems = reader.ReadU8();
        reader.AlignTo(4); /* IsExploredOnStart */
        byte _IsExploredOnStart = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _StarSystem1,
            _StarSystem2,
            _Difficulty,
            _ShouldBeExploredFromBothSystems,
            _IsExploredOnStart);
    }
}

