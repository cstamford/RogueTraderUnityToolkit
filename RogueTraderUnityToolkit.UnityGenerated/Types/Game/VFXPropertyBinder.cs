namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VFXPropertyBinder (7 fields) CB8587D00D66A5AAA0F7AE2C25D0980D/1461E8DFF93AFC3FE99CBBA2D1D0F200 */
public record class VFXPropertyBinder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_ExecuteInEditor /* NeedsAlign */,
    PPtr<VFXBinderBase>[] m_Bindings /* NeedsAlign */,
    PPtr<VisualEffect> m_VisualEffect /* None */)
{
    public static VFXPropertyBinder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExecuteInEditor */
        byte _m_ExecuteInEditor = reader.ReadU8();
        reader.AlignTo(4); /* m_Bindings */
        PPtr<VFXBinderBase>[] _m_Bindings = BuiltInArray<PPtr<VFXBinderBase>>.Read(reader);
        PPtr<VisualEffect> _m_VisualEffect = PPtr<VisualEffect>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExecuteInEditor,
            _m_Bindings,
            _m_VisualEffect);
    }
}

