namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectOnSurfaceProjectSettings (7 fields) B5A51F18C4B4DD61E2BCFA8F5D0F067B/7B8E8E9F82E696ED651488DDC3D11778 */
public record class ObjectOnSurfaceProjectSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _isVisible /* NeedsAlign */,
    PPtr<GameObject> _projectionSurface /* NeedsAlign */,
    int _projectionDirection /* None */)
{
    public static ObjectOnSurfaceProjectSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _isVisible */
        byte __isVisible = reader.ReadU8();
        reader.AlignTo(4); /* _projectionSurface */
        PPtr<GameObject> __projectionSurface = PPtr<GameObject>.Read(reader);
        int __projectionDirection = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __isVisible,
            __projectionSurface,
            __projectionDirection);
    }
}

