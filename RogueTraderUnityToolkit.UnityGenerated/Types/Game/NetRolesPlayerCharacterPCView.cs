namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetRolesPlayerCharacterPCView (9 fields) 0C375719539B63B13A1FBA71732AA110/15C78B32F2BFE2D6B2E1094BDAD7142E */
public record class NetRolesPlayerCharacterPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<OwlcatButton> m_MoveRoleUp /* None */,
    PPtr<OwlcatButton> m_MoveRoleDown /* None */,
    PPtr<RectTransform> m_MoveRoleUpBackground /* None */,
    PPtr<RectTransform> m_MoveRoleDownBackground /* None */)
{
    public static NetRolesPlayerCharacterPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<OwlcatButton> _m_MoveRoleUp = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_MoveRoleDown = PPtr<OwlcatButton>.Read(reader);
        PPtr<RectTransform> _m_MoveRoleUpBackground = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_MoveRoleDownBackground = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_MoveRoleUp,
            _m_MoveRoleDown,
            _m_MoveRoleUpBackground,
            _m_MoveRoleDownBackground);
    }
}

