namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickSpaceView (5 fields) 5C690DE3A6F3CDAE6859C41F750D7E75/A37AA5D9AFC950AA0F5C03B5063B97EF */
public record class TooltipBrickSpaceView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LayoutElement> m_LayoutElement /* NeedsAlign */)
{
    public static TooltipBrickSpaceView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LayoutElement */
        PPtr<LayoutElement> _m_LayoutElement = PPtr<LayoutElement>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LayoutElement);
    }
}

