namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostAbilityView (8 fields) B489F3409BFEDEC7255FEAFAEB709307/72F39ACC77042064CB65A4CBCBE31888 */
public record class PostAbilityView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<Image> m_IconGrayScale /* None */,
    PPtr<Sprite> m_EmptySprite /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* None */)
{
    public static PostAbilityView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_IconGrayScale = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_EmptySprite = PPtr<Sprite>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_IconGrayScale,
            _m_EmptySprite,
            _m_Selectable);
    }
}

