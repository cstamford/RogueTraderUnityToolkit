namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalizedUIText (7 fields) 75D59227AB95243240184F08B106B35D/2D6F1CF44D80908E96BF58DA13784523 */
public record class LocalizedUIText(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SharedStringAsset> Text /* NeedsAlign */,
    byte IsSaber /* None */,
    DlcText[] DlcTexts /* NeedsAlign */)
{
    public static LocalizedUIText Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Text */
        PPtr<SharedStringAsset> _Text = PPtr<SharedStringAsset>.Read(reader);
        byte _IsSaber = reader.ReadU8();
        reader.AlignTo(4); /* DlcTexts */
        DlcText[] _DlcTexts = BuiltInArray<DlcText>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Text,
            _IsSaber,
            _DlcTexts);
    }
}

