namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectLayerObjectMask (6 fields) 8241E43D58E1E83B9FA767CC0E5EF9BD/A99AC0B66660B6AE08BE30C74000DFBE */
public record class ObjectLayerObjectMask(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _layerMask /* NeedsAlign */,
    ObjectLayerObjectMaskView _view /* None */)
{
    public static ObjectLayerObjectMask Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _layerMask */
        int __layerMask = reader.ReadS32();
        ObjectLayerObjectMaskView __view = ObjectLayerObjectMaskView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __layerMask,
            __view);
    }
}

