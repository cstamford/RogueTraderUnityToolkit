namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuCamera (7 fields) 1383A3E5E8A6B5455FE386B3C94C64D8/F3863DFADAF1740E548A4BB9A2F73864 */
public record class MainMenuCamera(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<MainMenuCameraAnchors> m_CameraAnchors /* NeedsAlign */,
    PPtr<MainMenuCameraController> m_CameraController /* None */,
    PPtr<Camera> m_Camera /* None */)
{
    public static MainMenuCamera Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CameraAnchors */
        PPtr<MainMenuCameraAnchors> _m_CameraAnchors = PPtr<MainMenuCameraAnchors>.Read(reader);
        PPtr<MainMenuCameraController> _m_CameraController = PPtr<MainMenuCameraController>.Read(reader);
        PPtr<Camera> _m_Camera = PPtr<Camera>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CameraAnchors,
            _m_CameraController,
            _m_Camera);
    }
}

