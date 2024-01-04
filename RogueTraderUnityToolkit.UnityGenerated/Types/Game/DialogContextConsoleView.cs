namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogContextConsoleView (8 fields) E3D3669E0B4ED8F0B123F54A333C9C1D/12C03E3985F8B8DB51323A4680608B6C */
public record class DialogContextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BookEventConsoleView> m_BookEventConsoleView /* NeedsAlign */,
    PPtr<EpilogBaseView> m_EpilogConsoleView /* None */,
    PPtr<SurfaceDialogConsoleView> m_DialogConsoleView /* None */,
    PPtr<InterchapterBaseView> m_InterchapterView /* None */)
{
    public static DialogContextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BookEventConsoleView */
        PPtr<BookEventConsoleView> _m_BookEventConsoleView = PPtr<BookEventConsoleView>.Read(reader);
        PPtr<EpilogBaseView> _m_EpilogConsoleView = PPtr<EpilogBaseView>.Read(reader);
        PPtr<SurfaceDialogConsoleView> _m_DialogConsoleView = PPtr<SurfaceDialogConsoleView>.Read(reader);
        PPtr<InterchapterBaseView> _m_InterchapterView = PPtr<InterchapterBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BookEventConsoleView,
            _m_EpilogConsoleView,
            _m_DialogConsoleView,
            _m_InterchapterView);
    }
}

