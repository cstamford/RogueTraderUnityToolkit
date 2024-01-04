namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UberLoggerAppWindow (19 fields) C02FAE083D5FEFCA41D18DF12786B9D0/1F437D5A6D4CA337A0A82B6F1C9D9019 */
public record class UberLoggerAppWindow(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Canvas> Canvas /* NeedsAlign */,
    PPtr<GUISkin> Skin /* None */,
    PPtr<Texture2D> SmallErrorIcon /* None */,
    PPtr<Texture2D> SmallWarningIcon /* None */,
    PPtr<Texture2D> SmallMessageIcon /* None */,
    ColorRGBA GUIColour /* None */,
    int FontSize /* None */,
    ColorRGBA SizerLineColour /* None */,
    float SizerStartHeightRatio /* None */,
    int MaxMessagesCount /* None */,
    PPtr<Texture2D> ButtonTexture /* None */,
    PPtr<Texture2D> ErrorButtonTexture /* None */,
    Vector2f ButtonPositionNormalized /* None */,
    Vector2f ButtonSize /* None */,
    byte PauseOnError /* None */)
{
    public static UberLoggerAppWindow Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Canvas */
        PPtr<Canvas> _Canvas = PPtr<Canvas>.Read(reader);
        PPtr<GUISkin> _Skin = PPtr<GUISkin>.Read(reader);
        PPtr<Texture2D> _SmallErrorIcon = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _SmallWarningIcon = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _SmallMessageIcon = PPtr<Texture2D>.Read(reader);
        ColorRGBA _GUIColour = ColorRGBA.Read(reader);
        int _FontSize = reader.ReadS32();
        ColorRGBA _SizerLineColour = ColorRGBA.Read(reader);
        float _SizerStartHeightRatio = reader.ReadF32();
        int _MaxMessagesCount = reader.ReadS32();
        PPtr<Texture2D> _ButtonTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _ErrorButtonTexture = PPtr<Texture2D>.Read(reader);
        Vector2f _ButtonPositionNormalized = Vector2f.Read(reader);
        Vector2f _ButtonSize = Vector2f.Read(reader);
        byte _PauseOnError = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Canvas,
            _Skin,
            _SmallErrorIcon,
            _SmallWarningIcon,
            _SmallMessageIcon,
            _GUIColour,
            _FontSize,
            _SizerLineColour,
            _SizerStartHeightRatio,
            _MaxMessagesCount,
            _ButtonTexture,
            _ErrorButtonTexture,
            _ButtonPositionNormalized,
            _ButtonSize,
            _PauseOnError);
    }
}

