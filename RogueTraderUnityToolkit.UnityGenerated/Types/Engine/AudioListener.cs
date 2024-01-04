namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $AudioListener (2 fields) EA4A5E30154BB6CBDA102586CB0275D4 */
public record class AudioListener(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */) : IUnityObject
{
    public static Hash128 Hash => new(3930742320, 357283531, 3658491270, 3405936084);
    public static AudioListener Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled);
    }
}

