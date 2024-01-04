namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemScannerObjectView (6 fields) 2FF41D757951013CFBCE16E81E54AFEC/26EF9E8DA94F0894B6C6DF82FFD0DAB3 */
public record class SystemScannerObjectView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_ObjectIcon /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */)
{
    public static SystemScannerObjectView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ObjectIcon */
        PPtr<Image> _m_ObjectIcon = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ObjectIcon,
            _m_CanvasGroup);
    }
}

