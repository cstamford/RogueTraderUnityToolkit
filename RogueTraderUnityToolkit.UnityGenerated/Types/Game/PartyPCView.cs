namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PartyPCView (10 fields) C26EB13009545F81CA6933A4075EF1CA/1C708984DE358655897E4D5175601B5E */
public record class PartyPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_Next /* NeedsAlign */,
    PPtr<OwlcatButton> m_Prev /* None */,
    PPtr<HorizontalLayoutGroup> m_LayoutGroup /* None */,
    PPtr<ContentSizeFitterExtended> m_ContentSizeFitter /* None */,
    float m_HidePosY /* None */,
    float m_ShowPosY /* None */)
{
    public static PartyPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Next */
        PPtr<OwlcatButton> _m_Next = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_Prev = PPtr<OwlcatButton>.Read(reader);
        PPtr<HorizontalLayoutGroup> _m_LayoutGroup = PPtr<HorizontalLayoutGroup>.Read(reader);
        PPtr<ContentSizeFitterExtended> _m_ContentSizeFitter = PPtr<ContentSizeFitterExtended>.Read(reader);
        float _m_HidePosY = reader.ReadF32();
        float _m_ShowPosY = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Next,
            _m_Prev,
            _m_LayoutGroup,
            _m_ContentSizeFitter,
            _m_HidePosY,
            _m_ShowPosY);
    }
}

