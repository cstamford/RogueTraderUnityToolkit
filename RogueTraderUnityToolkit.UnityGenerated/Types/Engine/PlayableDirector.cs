namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PlayableDirector (9 fields) D200DB4E6F5FC6A9C3CDF5258063B81B */
public record class PlayableDirector(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<Object> m_PlayableAsset,
    int m_InitialState,
    int m_WrapMode,
    int m_DirectorUpdateMode,
    double m_InitialTime,
    DirectorGenericBinding[] m_SceneBindings,
    ExposedReferenceTable m_ExposedReferences) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3523271502, 1868547753, 3285054757, 2154018843);

    public static PlayableDirector Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<Object> _m_PlayableAsset = PPtr<Object>.Read(reader);
        int _m_InitialState = reader.ReadS32();
        int _m_WrapMode = reader.ReadS32();
        int _m_DirectorUpdateMode = reader.ReadS32();
        double _m_InitialTime = reader.ReadF64();
        DirectorGenericBinding[] _m_SceneBindings = BuiltInArray<DirectorGenericBinding>.Read(reader);
        reader.AlignTo(4); /* m_SceneBindings */
        ExposedReferenceTable _m_ExposedReferences = ExposedReferenceTable.Read(reader);
        reader.AlignTo(4); /* m_ExposedReferences */
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_PlayableAsset,
            _m_InitialState,
            _m_WrapMode,
            _m_DirectorUpdateMode,
            _m_InitialTime,
            _m_SceneBindings,
            _m_ExposedReferences);
    }

    public override string ToString() => $"PlayableDirector\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlayableAsset: ");
        sb.AppendLine(m_PlayableAsset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InitialState: ");
        sb.AppendLine(m_InitialState.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WrapMode: ");
        sb.AppendLine(m_WrapMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DirectorUpdateMode: ");
        sb.AppendLine(m_DirectorUpdateMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_InitialTime: ");
        sb.AppendLine(m_InitialTime.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SceneBindings: ");
        sb.AppendLine(m_SceneBindings.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExposedReferences: ");
        sb.AppendLine();
        sb.Append(m_ExposedReferences.ToString(indent+4));

        return sb.ToString();
    }
}

