namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UIHighlighter (6 fields) 7649B39D61AA993EB0D0935F7DEFB8DA/4CBDC2A18499266EB7D5213595640474 */
public record class UIHighlighter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString m_Key /* NeedsAlign */,
    PPtr<ScaleAnimator> m_Animation /* NeedsAlign */)
{
    public static UIHighlighter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Key */
        AsciiString _m_Key = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animation */
        PPtr<ScaleAnimator> _m_Animation = PPtr<ScaleAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Key,
            _m_Animation);
    }
}

