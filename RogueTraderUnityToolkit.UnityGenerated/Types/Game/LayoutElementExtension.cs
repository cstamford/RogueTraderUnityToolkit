namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LayoutElementExtension (16 fields) 9A3B1E4C1B566ABA7B2EC10DADD80058/F6120E23140ED29A7D301C543E6BA866 */
public record class LayoutElementExtension(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IgnoreLayout /* NeedsAlign */,
    float m_MinWidth /* NeedsAlign */,
    float m_MinHeight /* None */,
    float m_PreferredWidth /* None */,
    float m_PreferredHeight /* None */,
    float m_FlexibleWidth /* None */,
    float m_FlexibleHeight /* None */,
    int m_LayoutPriority /* None */,
    float MaxHeight /* None */,
    float MaxWidth /* None */,
    byte UseMaxWidth /* None */,
    byte UseMaxHeight /* NeedsAlign */)
{
    public static LayoutElementExtension Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IgnoreLayout */
        byte _m_IgnoreLayout = reader.ReadU8();
        reader.AlignTo(4); /* m_MinWidth */
        float _m_MinWidth = reader.ReadF32();
        float _m_MinHeight = reader.ReadF32();
        float _m_PreferredWidth = reader.ReadF32();
        float _m_PreferredHeight = reader.ReadF32();
        float _m_FlexibleWidth = reader.ReadF32();
        float _m_FlexibleHeight = reader.ReadF32();
        int _m_LayoutPriority = reader.ReadS32();
        float _MaxHeight = reader.ReadF32();
        float _MaxWidth = reader.ReadF32();
        byte _UseMaxWidth = reader.ReadU8();
        reader.AlignTo(4); /* UseMaxHeight */
        byte _UseMaxHeight = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IgnoreLayout,
            _m_MinWidth,
            _m_MinHeight,
            _m_PreferredWidth,
            _m_PreferredHeight,
            _m_FlexibleWidth,
            _m_FlexibleHeight,
            _m_LayoutPriority,
            _MaxHeight,
            _MaxWidth,
            _UseMaxWidth,
            _UseMaxHeight);
    }
}

