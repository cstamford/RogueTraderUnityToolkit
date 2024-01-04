namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FxAoeSpawner (11 fields) 9D0FACA33F8544D460132435F09CD4BE/34424C541493D13E7BBD315DE21A47C3 */
public record class FxAoeSpawner(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int Pattern /* NeedsAlign */,
    float Radius /* None */,
    PPtr<GameObject> FxVisualPrefab /* None */,
    PPtr<GameObject> LocatorsObject /* None */,
    BitField RaycastMask /* None */,
    float RaycastUpDownShift /* None */,
    Entry Entries /* None */)
{
    public static FxAoeSpawner Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Pattern */
        int _Pattern = reader.ReadS32();
        float _Radius = reader.ReadF32();
        PPtr<GameObject> _FxVisualPrefab = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _LocatorsObject = PPtr<GameObject>.Read(reader);
        BitField _RaycastMask = BitField.Read(reader);
        float _RaycastUpDownShift = reader.ReadF32();
        Entry _Entries = Entry.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Pattern,
            _Radius,
            _FxVisualPrefab,
            _LocatorsObject,
            _RaycastMask,
            _RaycastUpDownShift,
            _Entries);
    }
}

