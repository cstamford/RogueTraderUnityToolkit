namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoRankEntryGrayScalePCView (8 fields) 9D3463E2633B62AFF71C489A42C92161/8C0DAD47FF6E1B7FB998AFF5F0639962 */
public record class CharInfoRankEntryGrayScalePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AcronymText /* None */,
    PPtr<Image> m_Mask /* None */,
    PPtr<_2dxFX_GrayScale> m_GrayScale /* None */)
{
    public static CharInfoRankEntryGrayScalePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AcronymText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Mask = PPtr<Image>.Read(reader);
        PPtr<_2dxFX_GrayScale> _m_GrayScale = PPtr<_2dxFX_GrayScale>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_AcronymText,
            _m_Mask,
            _m_GrayScale);
    }
}

