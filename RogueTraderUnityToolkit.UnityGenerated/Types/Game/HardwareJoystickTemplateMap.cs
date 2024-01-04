namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $HardwareJoystickTemplateMap (13 fields) E322F5A6CE5A7CE4BADE48DCB43EDC76/88518BAD8C41745E45ABF7BD093A872C */
public record class HardwareJoystickTemplateMap(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString controllerName /* NeedsAlign */,
    AsciiString description /* NeedsAlign */,
    AsciiString templateGuid /* NeedsAlign */,
    AsciiString className /* NeedsAlign */,
    ControllerTemplateElementIdentifier_Editor[] elementIdentifiers /* NeedsAlign */,
    Entry joysticks /* NeedsAlign */,
    SpecialElementEntry[] specialElements /* NeedsAlign */,
    int elementIdentifierIdCounter /* NeedsAlign */,
    int joystickIdCounter /* None */)
{
    public static HardwareJoystickTemplateMap Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* controllerName */
        AsciiString _controllerName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* description */
        AsciiString _description = BuiltInString.Read(reader);
        reader.AlignTo(4); /* templateGuid */
        AsciiString _templateGuid = BuiltInString.Read(reader);
        reader.AlignTo(4); /* className */
        AsciiString _className = BuiltInString.Read(reader);
        reader.AlignTo(4); /* elementIdentifiers */
        ControllerTemplateElementIdentifier_Editor[] _elementIdentifiers = BuiltInArray<ControllerTemplateElementIdentifier_Editor>.Read(reader);
        reader.AlignTo(4); /* joysticks */
        Entry _joysticks = Entry.Read(reader);
        reader.AlignTo(4); /* specialElements */
        SpecialElementEntry[] _specialElements = BuiltInArray<SpecialElementEntry>.Read(reader);
        reader.AlignTo(4); /* elementIdentifierIdCounter */
        int _elementIdentifierIdCounter = reader.ReadS32();
        int _joystickIdCounter = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _controllerName,
            _description,
            _templateGuid,
            _className,
            _elementIdentifiers,
            _joysticks,
            _specialElements,
            _elementIdentifierIdCounter,
            _joystickIdCounter);
    }
}

