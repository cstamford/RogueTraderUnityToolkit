namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationSpaceBarksHolderPCView (5 fields) D02F508392A1475F5A98A3A2927B3B2D/FB4F8ED84FA5DB8D06F46AA072DD339A */
public record class ExplorationSpaceBarksHolderPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SpaceBarksHolderPCView> m_SpaceBarksHolderPCView /* NeedsAlign */)
{
    public static ExplorationSpaceBarksHolderPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SpaceBarksHolderPCView */
        PPtr<SpaceBarksHolderPCView> _m_SpaceBarksHolderPCView = PPtr<SpaceBarksHolderPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SpaceBarksHolderPCView);
    }
}

