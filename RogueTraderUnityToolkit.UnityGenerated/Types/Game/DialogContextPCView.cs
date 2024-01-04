namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogContextPCView (8 fields) 89AFC07B1D528C798C538B8BEF8A3AF3/C4B1B1367FA3E52739F02ABB4CB711B5 */
public record class DialogContextPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BookEventPCView> m_BookEventPCView /* NeedsAlign */,
    PPtr<EpilogPCView> m_EpilogPCView /* None */,
    PPtr<SurfaceDialogPCView> m_DialogPCView /* None */,
    PPtr<InterchapterBaseView> m_InterchapterView /* None */)
{
    public static DialogContextPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BookEventPCView */
        PPtr<BookEventPCView> _m_BookEventPCView = PPtr<BookEventPCView>.Read(reader);
        PPtr<EpilogPCView> _m_EpilogPCView = PPtr<EpilogPCView>.Read(reader);
        PPtr<SurfaceDialogPCView> _m_DialogPCView = PPtr<SurfaceDialogPCView>.Read(reader);
        PPtr<InterchapterBaseView> _m_InterchapterView = PPtr<InterchapterBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BookEventPCView,
            _m_EpilogPCView,
            _m_DialogPCView,
            _m_InterchapterView);
    }
}

