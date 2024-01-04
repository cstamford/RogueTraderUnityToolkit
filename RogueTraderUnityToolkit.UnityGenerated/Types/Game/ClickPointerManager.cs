namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ClickPointerManager (8 fields) 434C15AE15BE2E7841907ED147E380EB/06DC2CBF49B6603ECAA8D2EE58CE29F9 */
public record class ClickPointerManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ClickPointerPrefab> PointerPrefab /* NeedsAlign */,
    PPtr<ClickPointerPrefab> PreviewPointerPrefab /* None */,
    PPtr<GameObject> PreviewArrow /* None */,
    PPtr<GameObject> PlayerShipPointer /* None */)
{
    public static ClickPointerManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* PointerPrefab */
        PPtr<ClickPointerPrefab> _PointerPrefab = PPtr<ClickPointerPrefab>.Read(reader);
        PPtr<ClickPointerPrefab> _PreviewPointerPrefab = PPtr<ClickPointerPrefab>.Read(reader);
        PPtr<GameObject> _PreviewArrow = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _PlayerShipPointer = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _PointerPrefab,
            _PreviewPointerPrefab,
            _PreviewArrow,
            _PlayerShipPointer);
    }
}

