namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BookEventCharacterPCView (6 fields) C8BE9F819B8C05980B99A42CEBF91856/FBE4DDB227464CF977F33C4E21C6F144 */
public record class BookEventCharacterPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<Toggle> m_Toggle /* None */)
{
    public static BookEventCharacterPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<Toggle> _m_Toggle = PPtr<Toggle>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_Toggle);
    }
}

