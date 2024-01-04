namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryPCView (12 fields) E65D56B72F92AED3FCBD42B2D3A5F9BD/39F9F66CB801B20E1DB1465749E6E84E */
public record class InventoryPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_LeftCanvas /* NeedsAlign */,
    PPtr<RectTransform> m_RightCanvas /* None */,
    float m_MoveAnimationTime /* None */,
    PPtr<CharInfoNameAndPortraitPCView> m_NameAndPortraitPCView /* None */,
    PPtr<CharInfoLevelClassScoresPCView> m_LevelClassScoresView /* None */,
    PPtr<CharInfoSkillsAndWeaponsBaseView> m_SkillsAndWeaponsView /* None */,
    PPtr<InventoryDollPCView> m_DollView /* None */,
    PPtr<InventoryStashPCView> m_StashView /* None */)
{
    public static InventoryPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LeftCanvas */
        PPtr<RectTransform> _m_LeftCanvas = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_RightCanvas = PPtr<RectTransform>.Read(reader);
        float _m_MoveAnimationTime = reader.ReadF32();
        PPtr<CharInfoNameAndPortraitPCView> _m_NameAndPortraitPCView = PPtr<CharInfoNameAndPortraitPCView>.Read(reader);
        PPtr<CharInfoLevelClassScoresPCView> _m_LevelClassScoresView = PPtr<CharInfoLevelClassScoresPCView>.Read(reader);
        PPtr<CharInfoSkillsAndWeaponsBaseView> _m_SkillsAndWeaponsView = PPtr<CharInfoSkillsAndWeaponsBaseView>.Read(reader);
        PPtr<InventoryDollPCView> _m_DollView = PPtr<InventoryDollPCView>.Read(reader);
        PPtr<InventoryStashPCView> _m_StashView = PPtr<InventoryStashPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LeftCanvas,
            _m_RightCanvas,
            _m_MoveAnimationTime,
            _m_NameAndPortraitPCView,
            _m_LevelClassScoresView,
            _m_SkillsAndWeaponsView,
            _m_DollView,
            _m_StashView);
    }
}

