namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapPCView (5 fields) D6151FC8F58411969C1B1703FDC2E9F1/37C746FD9221B9C8ECC4CCF510A47308 */
public record class SystemMapPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<StarSystemSpaceBarksHolderPCView> m_StarSystemSpaceBarksHolderPCView /* NeedsAlign */)
{
    public static SystemMapPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StarSystemSpaceBarksHolderPCView */
        PPtr<StarSystemSpaceBarksHolderPCView> _m_StarSystemSpaceBarksHolderPCView = PPtr<StarSystemSpaceBarksHolderPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StarSystemSpaceBarksHolderPCView);
    }
}

