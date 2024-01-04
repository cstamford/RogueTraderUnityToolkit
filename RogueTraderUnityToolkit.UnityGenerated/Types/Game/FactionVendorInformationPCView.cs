namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FactionVendorInformationPCView (7 fields) 09EB5C2764B61D606AF94CD48F33D707/D722B1DF27E62349A12C03E29729E804 */
public record class FactionVendorInformationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_VendorLocation /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_VendorName /* None */,
    PPtr<OwlcatButton> m_MainButton /* None */)
{
    public static FactionVendorInformationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VendorLocation */
        PPtr<TextMeshProUGUI> _m_VendorLocation = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_MainButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VendorLocation,
            _m_VendorName,
            _m_MainButton);
    }
}

