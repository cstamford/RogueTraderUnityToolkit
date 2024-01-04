namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatButton (31 fields) 284E3F3E65322130715D92B6CE5488F2/CBFB2F06733532181BFBCE010EE9D8A0 */
public record class OwlcatButton(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte AutoRefresh /* NeedsAlign */,
    int TestState /* NeedsAlign */,
    byte m_Interactable /* None */,
    byte ResetOnDisable /* NeedsAlign */,
    PPtr<OwlcatSelectable>[] m_ChildSelectables /* NeedsAlign */,
    OwlcatSelectableLayerPart[] m_CommonLayer /* None */,
    ClickEvent m_ConfirmClickEvent /* NeedsAlign */,
    AsciiString ConfirmClickHint /* NeedsAlign */,
    AsciiString LongConfirmClickHint /* NeedsAlign */,
    AsciiString DeclineClickHint /* NeedsAlign */,
    AsciiString LongDeclineClickHint /* NeedsAlign */,
    AsciiString Func01ClickHint /* NeedsAlign */,
    AsciiString LongFunc01ClickHint /* NeedsAlign */,
    AsciiString Func02ClickHint /* NeedsAlign */,
    AsciiString LongFunc02ClickHint /* NeedsAlign */,
    ButtonClickedEvent m_OnLeftClick /* NeedsAlign */,
    ButtonClickedEvent m_OnRightClick /* NeedsAlign */,
    ButtonClickedEvent m_OnSingleLeftClick /* NeedsAlign */,
    ButtonClickedEvent m_OnSingleRightClick /* NeedsAlign */,
    ButtonClickedEvent m_OnLeftDoubleClick /* NeedsAlign */,
    ButtonClickedEvent m_OnRightDoubleClick /* NeedsAlign */,
    ButtonClickedEvent m_OnLeftClickNotInteractable /* NeedsAlign */,
    ButtonClickedEvent m_OnRightClickNotInteractable /* NeedsAlign */,
    ButtonClickedEvent m_OnSingleLeftClickNotInteractable /* NeedsAlign */,
    ButtonClickedEvent m_OnSingleRightClickNotInteractable /* NeedsAlign */,
    ButtonClickedEvent m_OnLeftDoubleClickNotInteractable /* NeedsAlign */,
    ButtonClickedEvent m_OnRightDoubleClickNotInteractable /* NeedsAlign */)
{
    public static OwlcatButton Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* AutoRefresh */
        byte _AutoRefresh = reader.ReadU8();
        reader.AlignTo(4); /* TestState */
        int _TestState = reader.ReadS32();
        byte _m_Interactable = reader.ReadU8();
        reader.AlignTo(4); /* ResetOnDisable */
        byte _ResetOnDisable = reader.ReadU8();
        reader.AlignTo(4); /* m_ChildSelectables */
        PPtr<OwlcatSelectable>[] _m_ChildSelectables = BuiltInArray<PPtr<OwlcatSelectable>>.Read(reader);
        OwlcatSelectableLayerPart[] _m_CommonLayer = BuiltInArray<OwlcatSelectableLayerPart>.Read(reader);
        reader.AlignTo(4); /* m_ConfirmClickEvent */
        ClickEvent _m_ConfirmClickEvent = ClickEvent.Read(reader);
        reader.AlignTo(4); /* ConfirmClickHint */
        AsciiString _ConfirmClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LongConfirmClickHint */
        AsciiString _LongConfirmClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* DeclineClickHint */
        AsciiString _DeclineClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LongDeclineClickHint */
        AsciiString _LongDeclineClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Func01ClickHint */
        AsciiString _Func01ClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LongFunc01ClickHint */
        AsciiString _LongFunc01ClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Func02ClickHint */
        AsciiString _Func02ClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LongFunc02ClickHint */
        AsciiString _LongFunc02ClickHint = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OnLeftClick */
        ButtonClickedEvent _m_OnLeftClick = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnRightClick */
        ButtonClickedEvent _m_OnRightClick = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnSingleLeftClick */
        ButtonClickedEvent _m_OnSingleLeftClick = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnSingleRightClick */
        ButtonClickedEvent _m_OnSingleRightClick = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnLeftDoubleClick */
        ButtonClickedEvent _m_OnLeftDoubleClick = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnRightDoubleClick */
        ButtonClickedEvent _m_OnRightDoubleClick = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnLeftClickNotInteractable */
        ButtonClickedEvent _m_OnLeftClickNotInteractable = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnRightClickNotInteractable */
        ButtonClickedEvent _m_OnRightClickNotInteractable = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnSingleLeftClickNotInteractable */
        ButtonClickedEvent _m_OnSingleLeftClickNotInteractable = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnSingleRightClickNotInteractable */
        ButtonClickedEvent _m_OnSingleRightClickNotInteractable = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnLeftDoubleClickNotInteractable */
        ButtonClickedEvent _m_OnLeftDoubleClickNotInteractable = ButtonClickedEvent.Read(reader);
        reader.AlignTo(4); /* m_OnRightDoubleClickNotInteractable */
        ButtonClickedEvent _m_OnRightDoubleClickNotInteractable = ButtonClickedEvent.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _AutoRefresh,
            _TestState,
            _m_Interactable,
            _ResetOnDisable,
            _m_ChildSelectables,
            _m_CommonLayer,
            _m_ConfirmClickEvent,
            _ConfirmClickHint,
            _LongConfirmClickHint,
            _DeclineClickHint,
            _LongDeclineClickHint,
            _Func01ClickHint,
            _LongFunc01ClickHint,
            _Func02ClickHint,
            _LongFunc02ClickHint,
            _m_OnLeftClick,
            _m_OnRightClick,
            _m_OnSingleLeftClick,
            _m_OnSingleRightClick,
            _m_OnLeftDoubleClick,
            _m_OnRightDoubleClick,
            _m_OnLeftClickNotInteractable,
            _m_OnRightClickNotInteractable,
            _m_OnSingleLeftClickNotInteractable,
            _m_OnSingleRightClickNotInteractable,
            _m_OnLeftDoubleClickNotInteractable,
            _m_OnRightDoubleClickNotInteractable);
    }
}

