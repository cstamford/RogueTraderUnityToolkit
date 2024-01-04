namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationSpaceResourcesWrapperPCView (6 fields) D07AA75734C3A93093FF97F754E06600/61F251E2AFC62036143DC9F2CBEF17CD */
public record class ExplorationSpaceResourcesWrapperPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<ExplorationSpaceResourcesPCView> m_ExplorationSpaceResourcesPCView /* None */)
{
    public static ExplorationSpaceResourcesWrapperPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ExplorationSpaceResourcesPCView> _m_ExplorationSpaceResourcesPCView = PPtr<ExplorationSpaceResourcesPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_ExplorationSpaceResourcesPCView);
    }
}

