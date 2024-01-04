namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorTabNavigationPCView (8 fields) D49C8199240F26D789D3FF82E811823D/D2BD15DC9710A7F96786D53E72C8385B */
public record class VendorTabNavigationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_TradeButton /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_ReputationButton /* None */,
    PPtr<OwlcatButton> m_ReputationDoubleButton /* None */,
    BoolReactiveProperty IsReputation /* None */)
{
    public static VendorTabNavigationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TradeButton */
        PPtr<OwlcatMultiButton> _m_TradeButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ReputationButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatButton> _m_ReputationDoubleButton = PPtr<OwlcatButton>.Read(reader);
        BoolReactiveProperty _IsReputation = BoolReactiveProperty.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TradeButton,
            _m_ReputationButton,
            _m_ReputationDoubleButton,
            _IsReputation);
    }
}

