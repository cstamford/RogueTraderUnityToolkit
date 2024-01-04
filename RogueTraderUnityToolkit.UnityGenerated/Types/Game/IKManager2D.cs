namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $IKManager2D (6 fields) 00923210794E22F0D30E769F0F8EE416/F9C282E766B80009B7384FADA908D17B */
public record class IKManager2D(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Solver2D>[] m_Solvers /* NeedsAlign */,
    float m_Weight /* None */)
{
    public static IKManager2D Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Solvers */
        PPtr<Solver2D>[] _m_Solvers = BuiltInArray<PPtr<Solver2D>>.Read(reader);
        float _m_Weight = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Solvers,
            _m_Weight);
    }
}

