namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeaponSetSelectorConsoleView (5 fields) 724A74B7172BE482D8622B8A936001DE/5ADAA32F27059A14041BFD8C66CED1F1 */
public record class WeaponSetSelectorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WeaponSetBaseView>[] m_WeaponSetViews /* NeedsAlign */)
{
    public static WeaponSetSelectorConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WeaponSetViews */
        PPtr<WeaponSetBaseView>[] _m_WeaponSetViews = BuiltInArray<PPtr<WeaponSetBaseView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WeaponSetViews);
    }
}

