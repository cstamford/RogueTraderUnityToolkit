namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectCollectionMask (6 fields) E29D4F276DFFED13B5EBE8188AA7079A/349A8B577A321865463C1C50B6AB3DB0 */
public record class ObjectCollectionMask(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SerializableGameObjectHashSet _gameObjects /* NeedsAlign */,
    ObjectCollectionMaskView _view /* None */)
{
    public static ObjectCollectionMask Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _gameObjects */
        SerializableGameObjectHashSet __gameObjects = SerializableGameObjectHashSet.Read(reader);
        ObjectCollectionMaskView __view = ObjectCollectionMaskView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __gameObjects,
            __view);
    }
}

