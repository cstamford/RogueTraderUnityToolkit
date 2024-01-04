namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyStatConsoleView (11 fields) BE562087AA30A7C565F8276EA640CBDE/2345824158EB310635F6BB4AF41A8C0B */
public record class ColonyStatConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_StatIcon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_StatName /* None */,
    PPtr<TextMeshProUGUI> m_StatValue /* None */,
    ColorRGBA m_NormalColor /* None */,
    ColorRGBA m_ModifiedColor /* None */,
    ColonyStatTypeIcon[] m_ColonyStatTypeIcons /* None */,
    PPtr<OwlcatMultiButton> m_FocusButton /* None */)
{
    public static ColonyStatConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StatIcon */
        PPtr<Image> _m_StatIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatValue = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _m_ModifiedColor = ColorRGBA.Read(reader);
        ColonyStatTypeIcon[] _m_ColonyStatTypeIcons = BuiltInArray<ColonyStatTypeIcon>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StatIcon,
            _m_StatName,
            _m_StatValue,
            _m_NormalColor,
            _m_ModifiedColor,
            _m_ColonyStatTypeIcons,
            _m_FocusButton);
    }
}

