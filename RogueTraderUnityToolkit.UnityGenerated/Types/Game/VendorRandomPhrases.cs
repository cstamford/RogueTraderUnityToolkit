namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorRandomPhrases (15 fields) 6DCC8DAD449BAE6FB72774024016E277/E68713F923A3874255AB869EA599D599 */
public record class VendorRandomPhrases(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    LocalizedString HelloPhrasesDrusians /* NeedsAlign */,
    LocalizedString FinishDealPhrasesDrusians /* NeedsAlign */,
    LocalizedString HelloPhrasesExplorators /* NeedsAlign */,
    LocalizedString FinishDealPhrasesExplorators /* NeedsAlign */,
    LocalizedString HelloPhrasesKasballica /* NeedsAlign */,
    LocalizedString FinishDealPhrasesKasballica /* NeedsAlign */,
    LocalizedString HelloPhrasesPirates /* NeedsAlign */,
    LocalizedString FinishDealPhrasesPirates /* NeedsAlign */,
    LocalizedString HelloPhrasesShipVendor /* NeedsAlign */,
    LocalizedString FinishDealPhrasesShipVendor /* NeedsAlign */,
    SpecialPhrasesDict[] SpecialPhrases /* NeedsAlign */)
{
    public static VendorRandomPhrases Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* HelloPhrasesDrusians */
        LocalizedString _HelloPhrasesDrusians = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FinishDealPhrasesDrusians */
        LocalizedString _FinishDealPhrasesDrusians = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HelloPhrasesExplorators */
        LocalizedString _HelloPhrasesExplorators = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FinishDealPhrasesExplorators */
        LocalizedString _FinishDealPhrasesExplorators = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HelloPhrasesKasballica */
        LocalizedString _HelloPhrasesKasballica = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FinishDealPhrasesKasballica */
        LocalizedString _FinishDealPhrasesKasballica = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HelloPhrasesPirates */
        LocalizedString _HelloPhrasesPirates = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FinishDealPhrasesPirates */
        LocalizedString _FinishDealPhrasesPirates = LocalizedString.Read(reader);
        reader.AlignTo(4); /* HelloPhrasesShipVendor */
        LocalizedString _HelloPhrasesShipVendor = LocalizedString.Read(reader);
        reader.AlignTo(4); /* FinishDealPhrasesShipVendor */
        LocalizedString _FinishDealPhrasesShipVendor = LocalizedString.Read(reader);
        reader.AlignTo(4); /* SpecialPhrases */
        SpecialPhrasesDict[] _SpecialPhrases = BuiltInArray<SpecialPhrasesDict>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _HelloPhrasesDrusians,
            _FinishDealPhrasesDrusians,
            _HelloPhrasesExplorators,
            _FinishDealPhrasesExplorators,
            _HelloPhrasesKasballica,
            _FinishDealPhrasesKasballica,
            _HelloPhrasesPirates,
            _FinishDealPhrasesPirates,
            _HelloPhrasesShipVendor,
            _FinishDealPhrasesShipVendor,
            _SpecialPhrases);
    }
}

