namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PropertyBlockSimple2side (10 fields) 6D3D3BC8E80D835ED291A8616010DBF8/EE90BE407A6E4A1902798662ADB5F8BF */
public record class PropertyBlockSimple2side(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float mHeight2 /* NeedsAlign */,
    float mHeight4 /* None */,
    byte _upDown2 /* None */,
    byte _OnlyBottom /* NeedsAlign */,
    byte _bObjectHeight /* NeedsAlign */,
    PPtr<GameObject> _mObject /* NeedsAlign */)
{
    public static PropertyBlockSimple2side Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* mHeight2 */
        float _mHeight2 = reader.ReadF32();
        float _mHeight4 = reader.ReadF32();
        byte __upDown2 = reader.ReadU8();
        reader.AlignTo(4); /* _OnlyBottom */
        byte __OnlyBottom = reader.ReadU8();
        reader.AlignTo(4); /* _bObjectHeight */
        byte __bObjectHeight = reader.ReadU8();
        reader.AlignTo(4); /* _mObject */
        PPtr<GameObject> __mObject = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _mHeight2,
            _mHeight4,
            __upDown2,
            __OnlyBottom,
            __bObjectHeight,
            __mObject);
    }
}

