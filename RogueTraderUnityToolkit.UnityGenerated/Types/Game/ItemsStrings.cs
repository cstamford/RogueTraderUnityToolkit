namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ItemsStrings (14 fields) F1BAEA13664603761FBCEDD5388D5A12/089A89305F7BA61D68ADD53BFDF9231D */
public record class ItemsStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString CopyItem /* NeedsAlign */,
    LocalizedString CopyScroll /* NeedsAlign */,
    LocalizedString CopyRecipe /* NeedsAlign */,
    LocalizedString PotionPrefix /* NeedsAlign */,
    LocalizedString FlaskPrefix /* NeedsAlign */,
    LocalizedString ScrollPrefix /* NeedsAlign */,
    LocalizedString WandPrefix /* NeedsAlign */,
    LocalizedString FlaskDescriptionPrefix /* NeedsAlign */,
    LocalizedString NotIdentified /* NeedsAlign */,
    LocalizedString NotIdentifiedSuffix /* NeedsAlign */)
{
    public static ItemsStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CopyItem */
        LocalizedString _CopyItem = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CopyScroll */
        LocalizedString _CopyScroll = LocalizedString.Read(reader);
        reader.AlignTo(4); /* CopyRecipe */
        LocalizedString _CopyRecipe = LocalizedString.Read(reader);
        reader.AlignTo(4); /* PotionPrefix */
        LocalizedString _PotionPrefix = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FlaskPrefix */
        LocalizedString _FlaskPrefix = LocalizedString.Read(reader);
        reader.AlignTo(4); /* ScrollPrefix */
        LocalizedString _ScrollPrefix = LocalizedString.Read(reader);
        reader.AlignTo(4); /* WandPrefix */
        LocalizedString _WandPrefix = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FlaskDescriptionPrefix */
        LocalizedString _FlaskDescriptionPrefix = LocalizedString.Read(reader);
        reader.AlignTo(4); /* NotIdentified */
        LocalizedString _NotIdentified = LocalizedString.Read(reader);
        reader.AlignTo(4); /* NotIdentifiedSuffix */
        LocalizedString _NotIdentifiedSuffix = LocalizedString.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CopyItem,
            _CopyScroll,
            _CopyRecipe,
            _PotionPrefix,
            _FlaskPrefix,
            _ScrollPrefix,
            _WandPrefix,
            _FlaskDescriptionPrefix,
            _NotIdentified,
            _NotIdentifiedSuffix);
    }
}

