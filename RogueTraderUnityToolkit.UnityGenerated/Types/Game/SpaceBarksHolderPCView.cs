namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceBarksHolderPCView (6 fields) CA157DF8EDFC530C3C4721F4823382F8/2C67E8AA62CD9DBF3AC6214182FA6123 */
public record class SpaceBarksHolderPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SpaceBarkPCView> m_SpaceBarkPCView /* NeedsAlign */,
    PPtr<Transform> m_BarksContainer /* None */)
{
    public static SpaceBarksHolderPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SpaceBarkPCView */
        PPtr<SpaceBarkPCView> _m_SpaceBarkPCView = PPtr<SpaceBarkPCView>.Read(reader);
        PPtr<Transform> _m_BarksContainer = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SpaceBarkPCView,
            _m_BarksContainer);
    }
}

