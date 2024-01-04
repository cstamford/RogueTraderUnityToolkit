namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CompassAnimator (5 fields) 687DB2A29A2431DFD61517FF6488BC17/0F36301EC9CFCC69240DD0C6B38F29AF */
public record class CompassAnimator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    CompassAnimationElement[] m_RotationElements /* NeedsAlign */)
{
    public static CompassAnimator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RotationElements */
        CompassAnimationElement[] _m_RotationElements = BuiltInArray<CompassAnimationElement>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RotationElements);
    }
}

