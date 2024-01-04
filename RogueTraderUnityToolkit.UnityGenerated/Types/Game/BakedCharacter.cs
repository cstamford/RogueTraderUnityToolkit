namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BakedCharacter (5 fields) 78D38A05FD3F6736B19230774CB0DCFE/69E62F93456173C485F39EA1D11D5E01 */
public record class BakedCharacter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    RendererDescription[] RendererDescriptions /* NeedsAlign */)
{
    public static BakedCharacter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* RendererDescriptions */
        RendererDescription[] _RendererDescriptions = BuiltInArray<RendererDescription>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _RendererDescriptions);
    }
}

