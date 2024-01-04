namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CustomPostProcessEffect (8 fields) 0D34D47BBB44755F8063E74C18272EA6/013A4A8D92437946D0BFDA90B6D2BF64 */
public record class CustomPostProcessEffect(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString m_DisplayName /* NeedsAlign */,
    AsciiString m_OriginalAssetGuid /* NeedsAlign */,
    int Event /* NeedsAlign */,
    CustomPostProcessEffectPass[] Passes /* None */)
{
    public static CustomPostProcessEffect Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DisplayName */
        AsciiString _m_DisplayName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OriginalAssetGuid */
        AsciiString _m_OriginalAssetGuid = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Event */
        int _Event = reader.ReadS32();
        CustomPostProcessEffectPass[] _Passes = BuiltInArray<CustomPostProcessEffectPass>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DisplayName,
            _m_OriginalAssetGuid,
            _Event,
            _Passes);
    }
}

