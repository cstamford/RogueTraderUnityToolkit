namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXOwlcatMultiplePositionBinder (11 fields) 43BEA3A911BF644004A74100FECEE6AE/2184AA3B20A7157B76102A900D69042F */
public record class VFXOwlcatMultiplePositionBinder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ExposedProperty PositionMapProperty /* NeedsAlign */,
    ExposedProperty OpacityMapProperty /* NeedsAlign */,
    ExposedProperty PositionCountProperty /* NeedsAlign */,
    ExposedProperty BoundsCenterProperty /* NeedsAlign */,
    ExposedProperty BoundsSizeProperty /* NeedsAlign */,
    Vector3f BoundsMargin /* NeedsAlign */,
    PPtr<Transform>[] Targets /* None */)
{
    public static VFXOwlcatMultiplePositionBinder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* PositionMapProperty */
        ExposedProperty _PositionMapProperty = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* OpacityMapProperty */
        ExposedProperty _OpacityMapProperty = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* PositionCountProperty */
        ExposedProperty _PositionCountProperty = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* BoundsCenterProperty */
        ExposedProperty _BoundsCenterProperty = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* BoundsSizeProperty */
        ExposedProperty _BoundsSizeProperty = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* BoundsMargin */
        Vector3f _BoundsMargin = Vector3f.Read(reader);
        PPtr<Transform>[] _Targets = BuiltInArray<PPtr<Transform>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _PositionMapProperty,
            _OpacityMapProperty,
            _PositionCountProperty,
            _BoundsCenterProperty,
            _BoundsSizeProperty,
            _BoundsMargin,
            _Targets);
    }
}

