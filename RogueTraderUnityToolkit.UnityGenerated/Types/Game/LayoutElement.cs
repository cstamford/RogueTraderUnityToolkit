namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LayoutElement (12 fields) 3F30F89453A26BCA5962FC837B4B325E/0CE949FCC1B8937FCFD2E38044215DA5 */
public record class LayoutElement(
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
    int m_LayoutPriority /* None */)
{
    public static LayoutElement Read(EndianBinaryReader reader)
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
            _m_LayoutPriority);
    }
}

