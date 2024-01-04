namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXOwlcatMultiplePositionBinderOpacityControl (7 fields) 45D342AD97A351114ACE8B997046489E/558E82527A97C3BC338763BA4FDB4591 */
public record class VFXOwlcatMultiplePositionBinderOpacityControl(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VFXOwlcatMultiplePositionBinder> m_Binder /* NeedsAlign */,
    int m_IndexBegin /* None */,
    int m_IndexEnd /* None */)
{
    public static VFXOwlcatMultiplePositionBinderOpacityControl Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Binder */
        PPtr<VFXOwlcatMultiplePositionBinder> _m_Binder = PPtr<VFXOwlcatMultiplePositionBinder>.Read(reader);
        int _m_IndexBegin = reader.ReadS32();
        int _m_IndexEnd = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Binder,
            _m_IndexBegin,
            _m_IndexEnd);
    }
}

