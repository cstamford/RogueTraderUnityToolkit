namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CreditsMenuSelectorBaseView (5 fields) A924ECFA9E10C0FC2BFDE111887CC3C8/22E9FA05707E5C4DC058B4A6B46BDEDC */
public record class CreditsMenuSelectorBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CreditsMenuEntityPCView>[] m_MenuEntities /* NeedsAlign */)
{
    public static CreditsMenuSelectorBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MenuEntities */
        PPtr<CreditsMenuEntityPCView>[] _m_MenuEntities = BuiltInArray<PPtr<CreditsMenuEntityPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MenuEntities);
    }
}

