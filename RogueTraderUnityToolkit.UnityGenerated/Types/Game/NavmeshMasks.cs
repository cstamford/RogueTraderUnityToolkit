namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NavmeshMasks (11 fields) 0735D7F2C86FD436B1AC03AF42814A62/2F97FD02E89EDA3155185C41DA2CFEF4 */
public record class NavmeshMasks(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float CellSize /* NeedsAlign */,
    AsciiString[] ForbidNavmeshMasks /* None */,
    AsciiString[] IgnoredMeshes /* NeedsAlign */,
    float MaskAlpha /* NeedsAlign */,
    AABB Bounds /* None */,
    byte UpdateMasksWhenCollidersMove /* None */,
    PPtr<Texture2D> m_Data /* NeedsAlign */)
{
    public static NavmeshMasks Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CellSize */
        float _CellSize = reader.ReadF32();
        AsciiString[] _ForbidNavmeshMasks = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* IgnoredMeshes */
        AsciiString[] _IgnoredMeshes = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* MaskAlpha */
        float _MaskAlpha = reader.ReadF32();
        AABB _Bounds = AABB.Read(reader);
        byte _UpdateMasksWhenCollidersMove = reader.ReadU8();
        reader.AlignTo(4); /* m_Data */
        PPtr<Texture2D> _m_Data = PPtr<Texture2D>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CellSize,
            _ForbidNavmeshMasks,
            _IgnoredMeshes,
            _MaskAlpha,
            _Bounds,
            _UpdateMasksWhenCollidersMove,
            _m_Data);
    }
}

