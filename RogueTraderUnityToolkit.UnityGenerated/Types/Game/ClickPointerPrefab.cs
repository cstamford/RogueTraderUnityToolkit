namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ClickPointerPrefab (6 fields) 687AEA7BF39A71555F7F9FEA9861D626/295DD4D97BCD408767C6B0FE90C0DD5B */
public record class ClickPointerPrefab(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GUIDecal>[] Decals /* NeedsAlign */,
    byte IsVisible /* None */)
{
    public static ClickPointerPrefab Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Decals */
        PPtr<GUIDecal>[] _Decals = BuiltInArray<PPtr<GUIDecal>>.Read(reader);
        byte _IsVisible = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Decals,
            _IsVisible);
    }
}

