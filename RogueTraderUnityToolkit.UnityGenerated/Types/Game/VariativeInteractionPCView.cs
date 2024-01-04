namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VariativeInteractionPCView (6 fields) 87C68EF51F906D76CF85F6F01EFD4EE4/A623257A6DA982E11DE62C234E49FF2E */
public record class VariativeInteractionPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetList> WidgetList /* NeedsAlign */,
    PPtr<InteractionVariantPCView> m_InteractionVariantViewPrefab /* None */)
{
    public static VariativeInteractionPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* WidgetList */
        PPtr<WidgetList> _WidgetList = PPtr<WidgetList>.Read(reader);
        PPtr<InteractionVariantPCView> _m_InteractionVariantViewPrefab = PPtr<InteractionVariantPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _WidgetList,
            _m_InteractionVariantViewPrefab);
    }
}

