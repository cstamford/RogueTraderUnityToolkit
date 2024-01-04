namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $HandSlotView (8 fields) 07EB66ABE84B921B959E8833CB03008C/F115B53680520D104E9A7348564F783A */
public record class HandSlotView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Slot /* NeedsAlign */,
    PPtr<Image> m_ItemImage /* None */,
    PPtr<GameObject> m_EmptyImage /* None */,
    PPtr<GameObject> m_VacantBackground /* None */)
{
    public static HandSlotView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Slot */
        PPtr<OwlcatMultiButton> _m_Slot = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_ItemImage = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_EmptyImage = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_VacantBackground = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Slot,
            _m_ItemImage,
            _m_EmptyImage,
            _m_VacantBackground);
    }
}

