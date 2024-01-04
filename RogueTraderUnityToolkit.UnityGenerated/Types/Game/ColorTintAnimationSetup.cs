namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColorTintAnimationSetup (5 fields) AC65DCAB358D7161A959C5D851E6E102/9D95F913710D04D127A5038E41304F6E */
public record class ColorTintAnimationSetup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ColorTintAnimationSettings Settings /* NeedsAlign */)
{
    public static ColorTintAnimationSetup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Settings */
        ColorTintAnimationSettings _Settings = ColorTintAnimationSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Settings);
    }
}

