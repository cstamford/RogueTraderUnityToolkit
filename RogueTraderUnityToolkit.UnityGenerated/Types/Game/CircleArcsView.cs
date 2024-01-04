namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CircleArcsView (9 fields) C92FE63B80DD5917FA4E5C90C2578A23/3D246EB59C6F10DF066FFAC0F71DACE3 */
public record class CircleArcsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte HasRandomizeImages /* NeedsAlign */,
    RandomizeImages m_RandomizeImages /* NeedsAlign */,
    byte AnimateShadows /* None */,
    PPtr<CanvasGroup> m_Shadows /* NeedsAlign */,
    CircleArtRotation m_CircleArtRotation /* None */)
{
    public static CircleArcsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* HasRandomizeImages */
        byte _HasRandomizeImages = reader.ReadU8();
        reader.AlignTo(4); /* m_RandomizeImages */
        RandomizeImages _m_RandomizeImages = RandomizeImages.Read(reader);
        byte _AnimateShadows = reader.ReadU8();
        reader.AlignTo(4); /* m_Shadows */
        PPtr<CanvasGroup> _m_Shadows = PPtr<CanvasGroup>.Read(reader);
        CircleArtRotation _m_CircleArtRotation = CircleArtRotation.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _HasRandomizeImages,
            _m_RandomizeImages,
            _AnimateShadows,
            _m_Shadows,
            _m_CircleArtRotation);
    }
}

