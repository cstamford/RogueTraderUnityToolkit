namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OneSlotLootDropZonePCView (6 fields) 36EAD4465072BE6137C0915E96338938/36A90DF13140BF45ADE9514151E925C3 */
public record class OneSlotLootDropZonePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_DropZone /* NeedsAlign */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */)
{
    public static OneSlotLootDropZonePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DropZone */
        PPtr<OwlcatMultiSelectable> _m_DropZone = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DropZone,
            _m_FadeAnimator);
    }
}

