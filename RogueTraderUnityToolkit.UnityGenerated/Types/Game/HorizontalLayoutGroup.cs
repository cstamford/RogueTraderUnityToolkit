namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $HorizontalLayoutGroup (14 fields) C998AC41376F0A88DB69CA5877771EAA/098C3407C61D78A5B2461CE629E582E6 */
public record class HorizontalLayoutGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    RectOffset m_Padding /* NeedsAlign */,
    int m_ChildAlignment /* None */,
    float m_Spacing /* None */,
    byte m_ChildForceExpandWidth /* None */,
    byte m_ChildForceExpandHeight /* NeedsAlign */,
    byte m_ChildControlWidth /* NeedsAlign */,
    byte m_ChildControlHeight /* NeedsAlign */,
    byte m_ChildScaleWidth /* NeedsAlign */,
    byte m_ChildScaleHeight /* NeedsAlign */,
    byte m_ReverseArrangement /* NeedsAlign */)
{
    public static HorizontalLayoutGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Padding */
        RectOffset _m_Padding = RectOffset.Read(reader);
        int _m_ChildAlignment = reader.ReadS32();
        float _m_Spacing = reader.ReadF32();
        byte _m_ChildForceExpandWidth = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildForceExpandHeight */
        byte _m_ChildForceExpandHeight = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildControlWidth */
        byte _m_ChildControlWidth = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildControlHeight */
        byte _m_ChildControlHeight = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildScaleWidth */
        byte _m_ChildScaleWidth = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildScaleHeight */
        byte _m_ChildScaleHeight = reader.ReadU8();
        reader.AlignTo(4); /* m_ReverseArrangement */
        byte _m_ReverseArrangement = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Padding,
            _m_ChildAlignment,
            _m_Spacing,
            _m_ChildForceExpandWidth,
            _m_ChildForceExpandHeight,
            _m_ChildControlWidth,
            _m_ChildControlHeight,
            _m_ChildScaleWidth,
            _m_ChildScaleHeight,
            _m_ReverseArrangement);
    }
}
