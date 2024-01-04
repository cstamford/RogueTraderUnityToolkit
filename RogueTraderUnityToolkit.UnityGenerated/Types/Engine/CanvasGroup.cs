namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $CanvasGroup (6 fields) 932BC45BAA679215A624A7BB033692A7 */
public record class CanvasGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    float m_Alpha /* NeedsAlign */,
    bool m_Interactable /* None */,
    bool m_BlocksRaycasts /* None */,
    bool m_IgnoreParentGroups /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2469119067, 2858914325, 2787420091, 53908135);
    public static CanvasGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Alpha */
        float _m_Alpha = reader.ReadF32();
        bool _m_Interactable = reader.ReadBool();
        bool _m_BlocksRaycasts = reader.ReadBool();
        bool _m_IgnoreParentGroups = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Alpha,
            _m_Interactable,
            _m_BlocksRaycasts,
            _m_IgnoreParentGroups);
    }
}

