namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PantographView (17 fields) 8033C72FA4C3A0A640EAF4C4EF173136/73E429740C4DC11C85213BFFC24F465C */
public record class PantographView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_FocusObject /* NeedsAlign */,
    PPtr<GameObject> m_SimpleItemContainer /* None */,
    PPtr<ScrambledTMP> m_Label /* None */,
    PPtr<Image>[] m_Images /* None */,
    PPtr<GameObject> m_ExtendedItemContainer /* None */,
    PPtr<GameObject> m_LargeItemContainer /* None */,
    PPtr<Transform> m_Head /* None */,
    PPtr<Transform> m_Tail /* None */,
    float m_HeadSpeed /* None */,
    float m_TailSpeed /* None */,
    float m_MinY /* None */,
    float m_MaxY /* None */,
    PPtr<SplineComputer> m_TailPath /* None */)
{
    public static PantographView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FocusObject */
        PPtr<GameObject> _m_FocusObject = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SimpleItemContainer = PPtr<GameObject>.Read(reader);
        PPtr<ScrambledTMP> _m_Label = PPtr<ScrambledTMP>.Read(reader);
        PPtr<Image>[] _m_Images = BuiltInArray<PPtr<Image>>.Read(reader);
        PPtr<GameObject> _m_ExtendedItemContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LargeItemContainer = PPtr<GameObject>.Read(reader);
        PPtr<Transform> _m_Head = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_Tail = PPtr<Transform>.Read(reader);
        float _m_HeadSpeed = reader.ReadF32();
        float _m_TailSpeed = reader.ReadF32();
        float _m_MinY = reader.ReadF32();
        float _m_MaxY = reader.ReadF32();
        PPtr<SplineComputer> _m_TailPath = PPtr<SplineComputer>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FocusObject,
            _m_SimpleItemContainer,
            _m_Label,
            _m_Images,
            _m_ExtendedItemContainer,
            _m_LargeItemContainer,
            _m_Head,
            _m_Tail,
            _m_HeadSpeed,
            _m_TailSpeed,
            _m_MinY,
            _m_MaxY,
            _m_TailPath);
    }
}

