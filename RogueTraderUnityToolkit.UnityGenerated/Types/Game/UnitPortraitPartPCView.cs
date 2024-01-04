namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitPortraitPartPCView (7 fields) B94BB5927E04364D0D5FAE2CBBC65816/CB4B2CEB9B546ACFBAFB2D1EE53B523C */
public record class UnitPortraitPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_DeadPortrait /* NeedsAlign */,
    PPtr<Image> m_LifePortrait /* None */,
    PPtr<Image> m_Cripple /* None */)
{
    public static UnitPortraitPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DeadPortrait */
        PPtr<Image> _m_DeadPortrait = PPtr<Image>.Read(reader);
        PPtr<Image> _m_LifePortrait = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Cripple = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DeadPortrait,
            _m_LifePortrait,
            _m_Cripple);
    }
}

