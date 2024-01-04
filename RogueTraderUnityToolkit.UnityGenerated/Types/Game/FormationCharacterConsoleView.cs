namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FormationCharacterConsoleView (8 fields) AFBDDE8EDB9184F1E4826B77946A3BD7/0E13FB1E83875DB92A88C8941CE40343 */
public record class FormationCharacterConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_Button /* NeedsAlign */,
    PPtr<Image> m_Portrait /* None */,
    ColorRGBA m_GreyColor /* None */,
    PPtr<FormationCharacterDragComponent> m_FormationCharacterDragComponent /* None */)
{
    public static FormationCharacterConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        ColorRGBA _m_GreyColor = ColorRGBA.Read(reader);
        PPtr<FormationCharacterDragComponent> _m_FormationCharacterDragComponent = PPtr<FormationCharacterDragComponent>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Portrait,
            _m_GreyColor,
            _m_FormationCharacterDragComponent);
    }
}

