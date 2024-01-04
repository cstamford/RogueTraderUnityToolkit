namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $TextAsset (2 fields) E1A46B48EA6ABD5D64A0C18AC8895830 */
public record class TextAsset(
    AsciiString m_Name /* None */,
    AsciiString m_Script /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3785648968, 3932863837, 1688256906, 3364444208);
    public static TextAsset Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Script */
        AsciiString _m_Script = BuiltInString.Read(reader);
        
        return new(_m_Name,
            _m_Script);
    }
}

