namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfacePCView (7 fields) AE25011068BEA2E9F5942FE98CDBF707/C0AEDB1E4922C684358F2DA805B75978 */
public record class SurfacePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceStaticPartPCView> m_StaticPartPCView /* NeedsAlign */,
    PPtr<SurfaceDynamicPartPCView> m_DynamicPartPCView /* None */,
    PPtr<SurfaceCombatPartView> m_CombatPartPCView /* None */)
{
    public static SurfacePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StaticPartPCView */
        PPtr<SurfaceStaticPartPCView> _m_StaticPartPCView = PPtr<SurfaceStaticPartPCView>.Read(reader);
        PPtr<SurfaceDynamicPartPCView> _m_DynamicPartPCView = PPtr<SurfaceDynamicPartPCView>.Read(reader);
        PPtr<SurfaceCombatPartView> _m_CombatPartPCView = PPtr<SurfaceCombatPartView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StaticPartPCView,
            _m_DynamicPartPCView,
            _m_CombatPartPCView);
    }
}

