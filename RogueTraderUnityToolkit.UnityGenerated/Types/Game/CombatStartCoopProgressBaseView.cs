namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CombatStartCoopProgressBaseView (5 fields) C4D3AE0F8C0EA64A693658EBF303EF80/DA14AC3BD1350B61B7291A5BB93262BA */
public record class CombatStartCoopProgressBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CombatStartCoopProgressBaseItemView>[] m_Items /* NeedsAlign */)
{
    public static CombatStartCoopProgressBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Items */
        PPtr<CombatStartCoopProgressBaseItemView>[] _m_Items = BuiltInArray<PPtr<CombatStartCoopProgressBaseItemView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Items);
    }
}

