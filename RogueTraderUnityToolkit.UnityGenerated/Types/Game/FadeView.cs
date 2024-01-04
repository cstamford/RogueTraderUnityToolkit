namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FadeView (8 fields) 42C5FB735710617A8C236FADDFCD0426/3DC17DE6C679C74D2E002AAA40381CB0 */
public record class FadeView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_FadeImage /* NeedsAlign */,
    float FadeTimer /* None */,
    PPtr<CanvasGroup> m_Vignette /* None */,
    float m_CutSceneTimer /* None */)
{
    public static FadeView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeImage */
        PPtr<Image> _m_FadeImage = PPtr<Image>.Read(reader);
        float _FadeTimer = reader.ReadF32();
        PPtr<CanvasGroup> _m_Vignette = PPtr<CanvasGroup>.Read(reader);
        float _m_CutSceneTimer = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeImage,
            _FadeTimer,
            _m_Vignette,
            _m_CutSceneTimer);
    }
}

