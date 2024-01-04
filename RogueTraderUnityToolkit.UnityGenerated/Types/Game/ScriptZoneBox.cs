namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScriptZoneBox (6 fields) 87A76E0955EE505E314729CD4E6750E8/363022B1494877B8FE853E43C302E436 */
public record class ScriptZoneBox(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AABB Bounds /* NeedsAlign */,
    byte AlwaysShowPattern /* None */)
{
    public static ScriptZoneBox Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Bounds */
        AABB _Bounds = AABB.Read(reader);
        byte _AlwaysShowPattern = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Bounds,
            _AlwaysShowPattern);
    }
}

