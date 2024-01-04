namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $HumanoidRagdollManager (7 fields) D4AB1C08923BAE479DACFC25E0C7899C/5E8A07D698C1D93E8E35C53E432EEF84 */
public record class HumanoidRagdollManager(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> StandardRagdollSkeleton /* NeedsAlign */,
    PPtr<GameObject> LeftHandedRagdollSkeleton /* None */,
    PPtr<GameObject>[] skeletonBones /* None */)
{
    public static HumanoidRagdollManager Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* StandardRagdollSkeleton */
        PPtr<GameObject> _StandardRagdollSkeleton = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _LeftHandedRagdollSkeleton = PPtr<GameObject>.Read(reader);
        PPtr<GameObject>[] _skeletonBones = BuiltInArray<PPtr<GameObject>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _StandardRagdollSkeleton,
            _LeftHandedRagdollSkeleton,
            _skeletonBones);
    }
}

