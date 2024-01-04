namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CoverSceneObject (7 fields) FC1C1C6DA96D4B5C8DB40837840CD647/6CED559047EAFC46529C659B9677D352 */
public record class CoverSceneObject(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BoxCollider> __CoverCollider__k__BackingField /* NeedsAlign */,
    int __CoverSizeT__k__BackingField /* None */,
    int __CoverGenType__k__BackingField /* None */)
{
    public static CoverSceneObject Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* __CoverCollider__k__BackingField */
        PPtr<BoxCollider> ___CoverCollider__k__BackingField = PPtr<BoxCollider>.Read(reader);
        int ___CoverSizeT__k__BackingField = reader.ReadS32();
        int ___CoverGenType__k__BackingField = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            ___CoverCollider__k__BackingField,
            ___CoverSizeT__k__BackingField,
            ___CoverGenType__k__BackingField);
    }
}

