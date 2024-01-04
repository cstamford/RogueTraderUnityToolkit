namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBricksGroupView (9 fields) 429A58B4B92DAD12689D832C0E061898/B1CF5AE9D98C78F983210CBA1205FB0A */
public record class TooltipBricksGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_Background /* NeedsAlign */,
    PPtr<Image> m_BackgroundImage /* None */,
    PPtr<VerticalLayoutGroup> m_VerticalLayoutGroup /* None */,
    PPtr<HorizontalLayoutGroup> m_HorizontalLayoutGroup /* None */,
    PPtr<GridLayoutGroup> m_GridLayoutGroup /* None */)
{
    public static TooltipBricksGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Background */
        PPtr<GameObject> _m_Background = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_BackgroundImage = PPtr<Image>.Read(reader);
        PPtr<VerticalLayoutGroup> _m_VerticalLayoutGroup = PPtr<VerticalLayoutGroup>.Read(reader);
        PPtr<HorizontalLayoutGroup> _m_HorizontalLayoutGroup = PPtr<HorizontalLayoutGroup>.Read(reader);
        PPtr<GridLayoutGroup> _m_GridLayoutGroup = PPtr<GridLayoutGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Background,
            _m_BackgroundImage,
            _m_VerticalLayoutGroup,
            _m_HorizontalLayoutGroup,
            _m_GridLayoutGroup);
    }
}

