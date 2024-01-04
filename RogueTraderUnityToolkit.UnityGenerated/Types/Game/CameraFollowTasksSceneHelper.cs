namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CameraFollowTasksSceneHelper (9 fields) 5179D90337DDA2E5FF5C3E8496A7CF53/4D4909527E162582D1E685EE66D79688 */
public record class CameraFollowTasksSceneHelper(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_SafeRect /* NeedsAlign */,
    byte m_AutoUpdateInEditor /* None */,
    byte m_UseOffsets /* NeedsAlign */,
    RectOffset m_Offsets /* NeedsAlign */,
    Rectf m_Rect /* None */)
{
    public static CameraFollowTasksSceneHelper Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SafeRect */
        PPtr<RectTransform> _m_SafeRect = PPtr<RectTransform>.Read(reader);
        byte _m_AutoUpdateInEditor = reader.ReadU8();
        reader.AlignTo(4); /* m_UseOffsets */
        byte _m_UseOffsets = reader.ReadU8();
        reader.AlignTo(4); /* m_Offsets */
        RectOffset _m_Offsets = RectOffset.Read(reader);
        Rectf _m_Rect = Rectf.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SafeRect,
            _m_AutoUpdateInEditor,
            _m_UseOffsets,
            _m_Offsets,
            _m_Rect);
    }
}

