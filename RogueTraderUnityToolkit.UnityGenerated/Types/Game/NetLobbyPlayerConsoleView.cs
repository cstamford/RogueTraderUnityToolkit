namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyPlayerConsoleView (12 fields) 18401FF3855BFD7ECB5EBE2B9C3D2D57/2BCA6EAFDE606A0B915580C13DE81651 */
public record class NetLobbyPlayerConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Portrait /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_PLayerName /* None */,
    PPtr<_2dxFX_GrayScale> m_GrayScale /* None */,
    PPtr<Image> m_Plus /* None */,
    PPtr<Image> m_MeLayer /* None */,
    PPtr<OwlcatButton> m_MainButton /* None */,
    BoolReactiveProperty InviteButtonInteractable /* None */,
    BoolReactiveProperty KickButtonInteractable /* NeedsAlign */)
{
    public static NetLobbyPlayerConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Portrait */
        PPtr<Image> _m_Portrait = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PLayerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<_2dxFX_GrayScale> _m_GrayScale = PPtr<_2dxFX_GrayScale>.Read(reader);
        PPtr<Image> _m_Plus = PPtr<Image>.Read(reader);
        PPtr<Image> _m_MeLayer = PPtr<Image>.Read(reader);
        PPtr<OwlcatButton> _m_MainButton = PPtr<OwlcatButton>.Read(reader);
        BoolReactiveProperty _InviteButtonInteractable = BoolReactiveProperty.Read(reader);
        reader.AlignTo(4); /* KickButtonInteractable */
        BoolReactiveProperty _KickButtonInteractable = BoolReactiveProperty.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Portrait,
            _m_PLayerName,
            _m_GrayScale,
            _m_Plus,
            _m_MeLayer,
            _m_MainButton,
            _InviteButtonInteractable,
            _KickButtonInteractable);
    }
}

