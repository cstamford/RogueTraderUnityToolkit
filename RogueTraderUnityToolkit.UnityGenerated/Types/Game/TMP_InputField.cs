namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_InputField (52 fields) 2BF937622F16D6EC1A3605A1002ACEB9/67AD62036358AB57786E35F338D3204F */
public record class TMP_InputField(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Navigation m_Navigation /* NeedsAlign */,
    int m_Transition /* NeedsAlign */,
    ColorBlock m_Colors /* None */,
    SpriteState m_SpriteState /* None */,
    AnimationTriggers m_AnimationTriggers /* None */,
    byte m_Interactable /* NeedsAlign */,
    PPtr<Graphic> m_TargetGraphic /* NeedsAlign */,
    PPtr<RectTransform> m_TextViewport /* None */,
    PPtr<TMP_Text> m_TextComponent /* None */,
    PPtr<Graphic> m_Placeholder /* None */,
    PPtr<Scrollbar> m_VerticalScrollbar /* None */,
    PPtr<TMP_ScrollbarEventHandler> m_VerticalScrollbarEventHandler /* None */,
    PPtr<LayoutGroup> m_LayoutGroup /* None */,
    float m_ScrollSensitivity /* None */,
    int m_ContentType /* None */,
    int m_InputType /* None */,
    ushort m_AsteriskChar /* None */,
    int m_KeyboardType /* NeedsAlign */,
    int m_LineType /* None */,
    byte m_HideMobileInput /* None */,
    byte m_HideSoftKeyboard /* NeedsAlign */,
    int m_CharacterValidation /* NeedsAlign */,
    AsciiString m_RegexValue /* None */,
    float m_GlobalPointSize /* NeedsAlign */,
    int m_CharacterLimit /* None */,
    SubmitEvent m_OnEndEdit /* None */,
    SubmitEvent m_OnSubmit /* NeedsAlign */,
    SelectionEvent m_OnSelect /* NeedsAlign */,
    SelectionEvent m_OnDeselect /* NeedsAlign */,
    TextSelectionEvent m_OnTextSelection /* NeedsAlign */,
    TextSelectionEvent m_OnEndTextSelection /* NeedsAlign */,
    OnChangeEvent m_OnValueChanged /* NeedsAlign */,
    TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged /* NeedsAlign */,
    ColorRGBA m_CaretColor /* NeedsAlign */,
    byte m_CustomCaretColor /* None */,
    ColorRGBA m_SelectionColor /* NeedsAlign */,
    AsciiString m_Text /* None */,
    float m_CaretBlinkRate /* NeedsAlign */,
    int m_CaretWidth /* None */,
    byte m_ReadOnly /* None */,
    byte m_RichText /* NeedsAlign */,
    PPtr<TMP_FontAsset> m_GlobalFontAsset /* NeedsAlign */,
    byte m_OnFocusSelectAll /* None */,
    byte m_ResetOnDeActivation /* NeedsAlign */,
    byte m_RestoreOriginalTextOnEscape /* NeedsAlign */,
    byte m_isRichTextEditingAllowed /* NeedsAlign */,
    int m_LineLimit /* NeedsAlign */,
    PPtr<TMP_InputValidator> m_InputValidator /* None */)
{
    public static TMP_InputField Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Navigation */
        Navigation _m_Navigation = Navigation.Read(reader);
        reader.AlignTo(4); /* m_Transition */
        int _m_Transition = reader.ReadS32();
        ColorBlock _m_Colors = ColorBlock.Read(reader);
        SpriteState _m_SpriteState = SpriteState.Read(reader);
        AnimationTriggers _m_AnimationTriggers = AnimationTriggers.Read(reader);
        reader.AlignTo(4); /* m_Interactable */
        byte _m_Interactable = reader.ReadU8();
        reader.AlignTo(4); /* m_TargetGraphic */
        PPtr<Graphic> _m_TargetGraphic = PPtr<Graphic>.Read(reader);
        PPtr<RectTransform> _m_TextViewport = PPtr<RectTransform>.Read(reader);
        PPtr<TMP_Text> _m_TextComponent = PPtr<TMP_Text>.Read(reader);
        PPtr<Graphic> _m_Placeholder = PPtr<Graphic>.Read(reader);
        PPtr<Scrollbar> _m_VerticalScrollbar = PPtr<Scrollbar>.Read(reader);
        PPtr<TMP_ScrollbarEventHandler> _m_VerticalScrollbarEventHandler = PPtr<TMP_ScrollbarEventHandler>.Read(reader);
        PPtr<LayoutGroup> _m_LayoutGroup = PPtr<LayoutGroup>.Read(reader);
        float _m_ScrollSensitivity = reader.ReadF32();
        int _m_ContentType = reader.ReadS32();
        int _m_InputType = reader.ReadS32();
        ushort _m_AsteriskChar = reader.ReadU16();
        reader.AlignTo(4); /* m_KeyboardType */
        int _m_KeyboardType = reader.ReadS32();
        int _m_LineType = reader.ReadS32();
        byte _m_HideMobileInput = reader.ReadU8();
        reader.AlignTo(4); /* m_HideSoftKeyboard */
        byte _m_HideSoftKeyboard = reader.ReadU8();
        reader.AlignTo(4); /* m_CharacterValidation */
        int _m_CharacterValidation = reader.ReadS32();
        AsciiString _m_RegexValue = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_GlobalPointSize */
        float _m_GlobalPointSize = reader.ReadF32();
        int _m_CharacterLimit = reader.ReadS32();
        SubmitEvent _m_OnEndEdit = SubmitEvent.Read(reader);
        reader.AlignTo(4); /* m_OnSubmit */
        SubmitEvent _m_OnSubmit = SubmitEvent.Read(reader);
        reader.AlignTo(4); /* m_OnSelect */
        SelectionEvent _m_OnSelect = SelectionEvent.Read(reader);
        reader.AlignTo(4); /* m_OnDeselect */
        SelectionEvent _m_OnDeselect = SelectionEvent.Read(reader);
        reader.AlignTo(4); /* m_OnTextSelection */
        TextSelectionEvent _m_OnTextSelection = TextSelectionEvent.Read(reader);
        reader.AlignTo(4); /* m_OnEndTextSelection */
        TextSelectionEvent _m_OnEndTextSelection = TextSelectionEvent.Read(reader);
        reader.AlignTo(4); /* m_OnValueChanged */
        OnChangeEvent _m_OnValueChanged = OnChangeEvent.Read(reader);
        reader.AlignTo(4); /* m_OnTouchScreenKeyboardStatusChanged */
        TouchScreenKeyboardEvent _m_OnTouchScreenKeyboardStatusChanged = TouchScreenKeyboardEvent.Read(reader);
        reader.AlignTo(4); /* m_CaretColor */
        ColorRGBA _m_CaretColor = ColorRGBA.Read(reader);
        byte _m_CustomCaretColor = reader.ReadU8();
        reader.AlignTo(4); /* m_SelectionColor */
        ColorRGBA _m_SelectionColor = ColorRGBA.Read(reader);
        AsciiString _m_Text = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CaretBlinkRate */
        float _m_CaretBlinkRate = reader.ReadF32();
        int _m_CaretWidth = reader.ReadS32();
        byte _m_ReadOnly = reader.ReadU8();
        reader.AlignTo(4); /* m_RichText */
        byte _m_RichText = reader.ReadU8();
        reader.AlignTo(4); /* m_GlobalFontAsset */
        PPtr<TMP_FontAsset> _m_GlobalFontAsset = PPtr<TMP_FontAsset>.Read(reader);
        byte _m_OnFocusSelectAll = reader.ReadU8();
        reader.AlignTo(4); /* m_ResetOnDeActivation */
        byte _m_ResetOnDeActivation = reader.ReadU8();
        reader.AlignTo(4); /* m_RestoreOriginalTextOnEscape */
        byte _m_RestoreOriginalTextOnEscape = reader.ReadU8();
        reader.AlignTo(4); /* m_isRichTextEditingAllowed */
        byte _m_isRichTextEditingAllowed = reader.ReadU8();
        reader.AlignTo(4); /* m_LineLimit */
        int _m_LineLimit = reader.ReadS32();
        PPtr<TMP_InputValidator> _m_InputValidator = PPtr<TMP_InputValidator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Navigation,
            _m_Transition,
            _m_Colors,
            _m_SpriteState,
            _m_AnimationTriggers,
            _m_Interactable,
            _m_TargetGraphic,
            _m_TextViewport,
            _m_TextComponent,
            _m_Placeholder,
            _m_VerticalScrollbar,
            _m_VerticalScrollbarEventHandler,
            _m_LayoutGroup,
            _m_ScrollSensitivity,
            _m_ContentType,
            _m_InputType,
            _m_AsteriskChar,
            _m_KeyboardType,
            _m_LineType,
            _m_HideMobileInput,
            _m_HideSoftKeyboard,
            _m_CharacterValidation,
            _m_RegexValue,
            _m_GlobalPointSize,
            _m_CharacterLimit,
            _m_OnEndEdit,
            _m_OnSubmit,
            _m_OnSelect,
            _m_OnDeselect,
            _m_OnTextSelection,
            _m_OnEndTextSelection,
            _m_OnValueChanged,
            _m_OnTouchScreenKeyboardStatusChanged,
            _m_CaretColor,
            _m_CustomCaretColor,
            _m_SelectionColor,
            _m_Text,
            _m_CaretBlinkRate,
            _m_CaretWidth,
            _m_ReadOnly,
            _m_RichText,
            _m_GlobalFontAsset,
            _m_OnFocusSelectAll,
            _m_ResetOnDeActivation,
            _m_RestoreOriginalTextOnEscape,
            _m_isRichTextEditingAllowed,
            _m_LineLimit,
            _m_InputValidator);
    }
}

