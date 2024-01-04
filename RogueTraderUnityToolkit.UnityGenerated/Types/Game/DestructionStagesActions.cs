namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DestructionStagesActions (5 fields) B1A003EC676E875FAC22109E01D3E3E6/A7DBFE1F016B5ABBBEE8FDB07F87FDBA */
public record class DestructionStagesActions(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    DestructionStagesActionsSettings Settings /* NeedsAlign */)
{
    public static DestructionStagesActions Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Settings */
        DestructionStagesActionsSettings _Settings = DestructionStagesActionsSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Settings);
    }
}

