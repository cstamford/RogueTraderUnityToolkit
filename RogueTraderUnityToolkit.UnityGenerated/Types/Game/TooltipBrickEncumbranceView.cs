namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickEncumbranceView (5 fields) 2E396ED9FFBB9426822085E8B524497E/40D3BA6541AE069084DA1F9253140664 */
public record class TooltipBrickEncumbranceView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<EncumbranceView> m_EncumbranceView /* NeedsAlign */)
{
    public static TooltipBrickEncumbranceView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EncumbranceView */
        PPtr<EncumbranceView> _m_EncumbranceView = PPtr<EncumbranceView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EncumbranceView);
    }
}

