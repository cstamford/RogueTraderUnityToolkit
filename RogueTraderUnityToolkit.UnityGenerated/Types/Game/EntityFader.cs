namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EntityFader (5 fields) D7FB648A645CF4D432DF916AD5EE29A4/22715B531AF921156DB50C0F99009C74 */
public record class EntityFader(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Renderer>[] m_ExcludeRenderersList /* NeedsAlign */)
{
    public static EntityFader Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExcludeRenderersList */
        PPtr<Renderer>[] _m_ExcludeRenderersList = BuiltInArray<PPtr<Renderer>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExcludeRenderersList);
    }
}

