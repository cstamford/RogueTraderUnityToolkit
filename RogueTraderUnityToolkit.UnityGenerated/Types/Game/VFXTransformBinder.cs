namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXTransformBinder (6 fields) 978B6FB98A3BE881FE3D5EDA00E37D30/5949AB2585281624DCB7DFD9AEAE0059 */
public record class VFXTransformBinder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ExposedProperty m_Property /* NeedsAlign */,
    PPtr<Transform> Target /* NeedsAlign */)
{
    public static VFXTransformBinder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Property */
        ExposedProperty _m_Property = ExposedProperty.Read(reader);
        reader.AlignTo(4); /* Target */
        PPtr<Transform> _Target = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Property,
            _Target);
    }
}

