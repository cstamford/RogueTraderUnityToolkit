namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitDismembermentManager (10 fields) A5683A3343F69E152EE08AE19248A5E7/B7B9890F882E637AECC0C02280735861 */
public record class UnitDismembermentManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int SetIndex /* NeedsAlign */,
    int DestroyedPieceIndex /* None */,
    PPtr<GameObject> DismembermentGameObjectToFx /* None */,
    DismembermentSet[] Sets /* None */,
    PPtr<GameObject> visualEffectPrefab /* NeedsAlign */,
    byte NeedToRebakeDismemberment /* None */)
{
    public static UnitDismembermentManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SetIndex */
        int _SetIndex = reader.ReadS32();
        int _DestroyedPieceIndex = reader.ReadS32();
        PPtr<GameObject> _DismembermentGameObjectToFx = PPtr<GameObject>.Read(reader);
        DismembermentSet[] _Sets = BuiltInArray<DismembermentSet>.Read(reader);
        reader.AlignTo(4); /* visualEffectPrefab */
        PPtr<GameObject> _visualEffectPrefab = PPtr<GameObject>.Read(reader);
        byte _NeedToRebakeDismemberment = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SetIndex,
            _DestroyedPieceIndex,
            _DismembermentGameObjectToFx,
            _Sets,
            _visualEffectPrefab,
            _NeedToRebakeDismemberment);
    }
}

