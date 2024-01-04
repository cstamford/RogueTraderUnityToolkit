namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetRolesPCView (8 fields) 8769970B8D6AB3D567B06FAF32DF5D46/2BFE1223FA6D1621937C11E82163571A */
public record class NetRolesPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<NetRolesPlayerPCView>[] m_Players /* NeedsAlign */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_ApplyButton /* None */,
    PPtr<TextMeshProUGUI> m_ApplyLabel /* None */)
{
    public static NetRolesPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Players */
        PPtr<NetRolesPlayerPCView>[] _m_Players = BuiltInArray<PPtr<NetRolesPlayerPCView>>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ApplyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ApplyLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Players,
            _m_CloseButton,
            _m_ApplyButton,
            _m_ApplyLabel);
    }
}

