namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoDropZonePCView (7 fields) 2F4F5FCF479E0EDF698B3EE63FCCCD27/1D3E07009D7918D76B0E6315EAEEE429 */
public record class CargoDropZonePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_Interactable /* NeedsAlign */,
    PPtr<OwlcatMultiSelectable> m_DropZone /* NeedsAlign */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */)
{
    public static CargoDropZonePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Interactable */
        byte _m_Interactable = reader.ReadU8();
        reader.AlignTo(4); /* m_DropZone */
        PPtr<OwlcatMultiSelectable> _m_DropZone = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Interactable,
            _m_DropZone,
            _m_FadeAnimator);
    }
}

