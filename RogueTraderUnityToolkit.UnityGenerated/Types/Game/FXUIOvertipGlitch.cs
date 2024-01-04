namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FXUIOvertipGlitch (5 fields) 37F7792515C171BE279032F1EC4D91EB/28C8E407B63C0821E6EA2E96E82DF8A2 */
public record class FXUIOvertipGlitch(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _randomizeOnEnableOnly /* NeedsAlign */)
{
    public static FXUIOvertipGlitch Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _randomizeOnEnableOnly */
        byte __randomizeOnEnableOnly = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __randomizeOnEnableOnly);
    }
}

