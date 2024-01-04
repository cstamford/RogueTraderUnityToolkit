namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AbilityPatternView (9 fields) EA4EF24B541F6E595F0F8C65A776C45F/3D3ABCF99F8C069B28CD86519DF13ACB */
public record class AbilityPatternView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_PatternContainer /* NeedsAlign */,
    float m_PatternContainerSize /* None */,
    float m_Spacing /* None */,
    int m_MinSizeInCells /* None */,
    PPtr<AbilityPatternCell> m_AbilityPatternCellPrefab /* None */)
{
    public static AbilityPatternView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PatternContainer */
        PPtr<RectTransform> _m_PatternContainer = PPtr<RectTransform>.Read(reader);
        float _m_PatternContainerSize = reader.ReadF32();
        float _m_Spacing = reader.ReadF32();
        int _m_MinSizeInCells = reader.ReadS32();
        PPtr<AbilityPatternCell> _m_AbilityPatternCellPrefab = PPtr<AbilityPatternCell>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PatternContainer,
            _m_PatternContainerSize,
            _m_Spacing,
            _m_MinSizeInCells,
            _m_AbilityPatternCellPrefab);
    }
}

