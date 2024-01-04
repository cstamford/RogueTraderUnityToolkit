namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SimpleTrapObjectView (16 fields) 0D047B0EA81A5FD874E4B5945883A581/4F9AAB9DC080B3D3D5C71868566C06A8 */
public record class SimpleTrapObjectView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    PPtr<Renderer>[] m_HideRenderers /* NeedsAlign */,
    byte AreaHighlighted /* None */,
    PPtr<TrapObjectView> LinkedTrap /* NeedsAlign */,
    PPtr<SetPathToTrapMechanics> LinkLine /* None */,
    TrapObjectViewSettings Settings /* None */,
    LocalizedString m_NameInLog /* NeedsAlign */,
    ActionsReference m_DisableActions /* NeedsAlign */,
    ActionsReference m_TrapActions /* NeedsAlign */,
    Reference[] m_Facts /* NeedsAlign */,
    SimpleTrapObjectInfo Info /* NeedsAlign */)
{
    public static SimpleTrapObjectView Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* LinkedTrap */
        PPtr<TrapObjectView> _LinkedTrap = PPtr<TrapObjectView>.Read(reader);
        PPtr<SetPathToTrapMechanics> _LinkLine = PPtr<SetPathToTrapMechanics>.Read(reader);
        TrapObjectViewSettings _Settings = TrapObjectViewSettings.Read(reader);
        reader.AlignTo(4); /* m_NameInLog */
        LocalizedString _m_NameInLog = LocalizedString.Read(reader);
        reader.AlignTo(4); /* m_DisableActions */
        ActionsReference _m_DisableActions = ActionsReference.Read(reader);
        reader.AlignTo(4); /* m_TrapActions */
        ActionsReference _m_TrapActions = ActionsReference.Read(reader);
        reader.AlignTo(4); /* m_Facts */
        Reference[] _m_Facts = BuiltInArray<Reference>.Read(reader);
        reader.AlignTo(4); /* Info */
        SimpleTrapObjectInfo _Info = SimpleTrapObjectInfo.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_HideRenderers,
            _AreaHighlighted,
            _LinkedTrap,
            _LinkLine,
            _Settings,
            _m_NameInLog,
            _m_DisableActions,
            _m_TrapActions,
            _m_Facts,
            _Info);
    }
}

