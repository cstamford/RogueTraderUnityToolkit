namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CoverEntityView (13 fields) 191EBAC0FBFF995CEEB85B3E336E8D4A/1BC898041DBF54E6F43013F643428DF4 */
public record class CoverEntityView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<Renderer>[] m_HideRenderers /* NeedsAlign */,
    byte AreaHighlighted /* None */,
    byte m_UseCustomBlueprint /* NeedsAlign */,
    int m_StandardBlueprintType /* NeedsAlign */,
    Reference m_CustomBlueprint /* None */,
    byte m_CanBeAttackedDirectly /* NeedsAlign */,
    DestructionStageSettings[] m_DestructionStages /* NeedsAlign */)
{
    public static CoverEntityView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HideRenderers */
        PPtr<Renderer>[] _m_HideRenderers = BuiltInArray<PPtr<Renderer>>.Read(reader);
        byte _AreaHighlighted = reader.ReadU8();
        reader.AlignTo(4); /* m_UseCustomBlueprint */
        byte _m_UseCustomBlueprint = reader.ReadU8();
        reader.AlignTo(4); /* m_StandardBlueprintType */
        int _m_StandardBlueprintType = reader.ReadS32();
        Reference _m_CustomBlueprint = Reference.Read(reader);
        reader.AlignTo(4); /* m_CanBeAttackedDirectly */
        byte _m_CanBeAttackedDirectly = reader.ReadU8();
        reader.AlignTo(4); /* m_DestructionStages */
        DestructionStageSettings[] _m_DestructionStages = BuiltInArray<DestructionStageSettings>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_HideRenderers,
            _AreaHighlighted,
            _m_UseCustomBlueprint,
            _m_StandardBlueprintType,
            _m_CustomBlueprint,
            _m_CanBeAttackedDirectly,
            _m_DestructionStages);
    }
}

