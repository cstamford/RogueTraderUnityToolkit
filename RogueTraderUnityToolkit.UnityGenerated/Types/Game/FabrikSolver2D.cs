namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FabrikSolver2D (10 fields) C300B4D45D7312978BA5354D334116B8/AD775A1B7593B2C90592638B30651E30 */
public record class FabrikSolver2D(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_ConstrainRotation /* NeedsAlign */,
    byte m_SolveFromDefaultPose /* NeedsAlign */,
    float m_Weight /* NeedsAlign */,
    IKChain2D m_Chain /* None */,
    int m_Iterations /* NeedsAlign */,
    float m_Tolerance /* None */)
{
    public static FabrikSolver2D Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ConstrainRotation */
        byte _m_ConstrainRotation = reader.ReadU8();
        reader.AlignTo(4); /* m_SolveFromDefaultPose */
        byte _m_SolveFromDefaultPose = reader.ReadU8();
        reader.AlignTo(4); /* m_Weight */
        float _m_Weight = reader.ReadF32();
        IKChain2D _m_Chain = IKChain2D.Read(reader);
        reader.AlignTo(4); /* m_Iterations */
        int _m_Iterations = reader.ReadS32();
        float _m_Tolerance = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ConstrainRotation,
            _m_SolveFromDefaultPose,
            _m_Weight,
            _m_Chain,
            _m_Iterations,
            _m_Tolerance);
    }
}

