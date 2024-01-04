namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectEraser (9 fields) D82D6554D92FC86FDEFAB405984B1EDC/37EAD048B7479A22613C56F33D20AE47 */
public record class ObjectEraser(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ObjectEraserSettings> _settings /* NeedsAlign */,
    ObjectMask _eraseMask /* None */,
    Object2DMassEraseShape _mass2DEraseShape /* NeedsAlign */,
    Object3DMassEraseShape _mass3DEraseShape /* None */,
    byte _wasInitialized /* None */)
{
    public static ObjectEraser Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _settings */
        PPtr<ObjectEraserSettings> __settings = PPtr<ObjectEraserSettings>.Read(reader);
        ObjectMask __eraseMask = ObjectMask.Read(reader);
        reader.AlignTo(4); /* _mass2DEraseShape */
        Object2DMassEraseShape __mass2DEraseShape = Object2DMassEraseShape.Read(reader);
        Object3DMassEraseShape __mass3DEraseShape = Object3DMassEraseShape.Read(reader);
        byte __wasInitialized = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __settings,
            __eraseMask,
            __mass2DEraseShape,
            __mass3DEraseShape,
            __wasInitialized);
    }
}

