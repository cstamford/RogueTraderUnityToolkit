namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StarSystemSpaceBarksHolderPCView (6 fields) 3E6E2964D12D13DDBF8B4036DF81321C/FD673E8B1A0C67844780BA3E11014487 */
public record class StarSystemSpaceBarksHolderPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<StarSystemSpaceBarkPCView> m_StarSystemSpaceBarkView /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */)
{
    public static StarSystemSpaceBarksHolderPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StarSystemSpaceBarkView */
        PPtr<StarSystemSpaceBarkPCView> _m_StarSystemSpaceBarkView = PPtr<StarSystemSpaceBarkPCView>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StarSystemSpaceBarkView,
            _m_CanvasGroup);
    }
}

