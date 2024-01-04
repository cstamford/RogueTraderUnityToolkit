namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DoorInteractionViewTrigger (7 fields) A697F0D00E771B6627256A8D85F7D647/5D1DFC207BC9ED2320C342F14E6BB0A0 */
public record class DoorInteractionViewTrigger(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ActionsReference OpenActions /* NeedsAlign */,
    ActionsReference CloseActions /* NeedsAlign */,
    ActionsReference RestrictedActions /* NeedsAlign */)
{
    public static DoorInteractionViewTrigger Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* OpenActions */
        ActionsReference _OpenActions = ActionsReference.Read(reader);
        reader.AlignTo(4); /* CloseActions */
        ActionsReference _CloseActions = ActionsReference.Read(reader);
        reader.AlignTo(4); /* RestrictedActions */
        ActionsReference _RestrictedActions = ActionsReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _OpenActions,
            _CloseActions,
            _RestrictedActions);
    }
}

