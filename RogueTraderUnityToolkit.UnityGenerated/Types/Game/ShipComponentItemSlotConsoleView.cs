namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipComponentItemSlotConsoleView (7 fields) 04F344CB079918A529B2EEAD0B57C088/33900067E1FE11C72D65EE6B5F5D86F3 */
public record class ShipComponentItemSlotConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<TMP_Text> m_Text /* None */,
    PPtr<Image> m_Icon /* None */)
{
    public static ShipComponentItemSlotConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TMP_Text> _m_Text = PPtr<TMP_Text>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Text,
            _m_Icon);
    }
}

