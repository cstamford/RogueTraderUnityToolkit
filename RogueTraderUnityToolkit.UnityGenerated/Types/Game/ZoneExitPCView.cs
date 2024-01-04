namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ZoneExitPCView (8 fields) 8DCD3B41F176C624D048C6427645D285/ACC246F070F2A549B52E01051EE0BF02 */
public record class ZoneExitPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_ExitToWarpObject /* NeedsAlign */,
    PPtr<OwlcatButton> m_ExitToShipButton /* None */,
    PPtr<OwlcatButton> m_ExitToWarpButton /* None */,
    PPtr<OwlcatButton> m_ShipCustomizationButton /* None */)
{
    public static ZoneExitPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExitToWarpObject */
        PPtr<GameObject> _m_ExitToWarpObject = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_ExitToShipButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ExitToWarpButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ShipCustomizationButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExitToWarpObject,
            _m_ExitToShipButton,
            _m_ExitToWarpButton,
            _m_ShipCustomizationButton);
    }
}

