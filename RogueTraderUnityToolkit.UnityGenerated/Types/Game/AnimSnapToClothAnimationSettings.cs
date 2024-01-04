namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimSnapToClothAnimationSettings (6 fields) 779DA3F74F4C2CE847871BD37EE719FE/4F1B29839894D6E0D62D552AA61063E6 */
public record class AnimSnapToClothAnimationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ClipsPlaySimpleAnim[] ClipsWhichPlaySimpleAnimationLikeIdle /* NeedsAlign */,
    ClipsPlaySpecialAnim[] ClipsWhichPlaySpecialAnimation /* None */)
{
    public static AnimSnapToClothAnimationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ClipsWhichPlaySimpleAnimationLikeIdle */
        ClipsPlaySimpleAnim[] _ClipsWhichPlaySimpleAnimationLikeIdle = BuiltInArray<ClipsPlaySimpleAnim>.Read(reader);
        ClipsPlaySpecialAnim[] _ClipsWhichPlaySpecialAnimation = BuiltInArray<ClipsPlaySpecialAnim>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ClipsWhichPlaySimpleAnimationLikeIdle,
            _ClipsWhichPlaySpecialAnimation);
    }
}

