namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoHitPointsPCView (9 fields) 1A62A1F7F91B46F8241667014C2C6A16/364154024582BFC8001EC3BC94BDAFF3 */
public record class CharInfoHitPointsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MainHPField /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_SecondaryHPField /* None */,
    PPtr<Image> m_CurrentHPBar /* None */,
    PPtr<Image> m_TempHpBar /* None */,
    PPtr<Image> m_MaxHPBar /* None */)
{
    public static CharInfoHitPointsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainHPField */
        PPtr<TextMeshProUGUI> _m_MainHPField = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SecondaryHPField = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CurrentHPBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_TempHpBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_MaxHPBar = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainHPField,
            _m_SecondaryHPField,
            _m_CurrentHPBar,
            _m_TempHpBar,
            _m_MaxHPBar);
    }
}

