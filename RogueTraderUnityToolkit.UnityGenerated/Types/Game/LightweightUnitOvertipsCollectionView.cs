namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LightweightUnitOvertipsCollectionView (6 fields) 615F9A664F0282A13FE5F259CEBBD4D7/DCF77012F346091DE5B70A8599054F2F */
public record class LightweightUnitOvertipsCollectionView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_NpcContainer /* NeedsAlign */,
    PPtr<LightweightUnitOvertipView> m_OvertipLightweightUnitView /* None */)
{
    public static LightweightUnitOvertipsCollectionView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NpcContainer */
        PPtr<RectTransform> _m_NpcContainer = PPtr<RectTransform>.Read(reader);
        PPtr<LightweightUnitOvertipView> _m_OvertipLightweightUnitView = PPtr<LightweightUnitOvertipView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NpcContainer,
            _m_OvertipLightweightUnitView);
    }
}

