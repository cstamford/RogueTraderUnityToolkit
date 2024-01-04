namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CameraTweenAnchor (6 fields) 11BB8F4B08640BA3516642F02C13EC62/9323159B38F812B6BA3F4B2D3F59CB9F */
public record class CameraTweenAnchor(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    TweenData m_DefaultTween /* NeedsAlign */,
    TweenDataWithPrev[] m_Tweens /* NeedsAlign */)
{
    public static CameraTweenAnchor Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DefaultTween */
        TweenData _m_DefaultTween = TweenData.Read(reader);
        reader.AlignTo(4); /* m_Tweens */
        TweenDataWithPrev[] _m_Tweens = BuiltInArray<TweenDataWithPrev>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DefaultTween,
            _m_Tweens);
    }
}

