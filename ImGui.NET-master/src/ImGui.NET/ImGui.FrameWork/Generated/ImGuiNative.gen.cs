using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGui
{
    public static unsafe partial class ImGuiNative
    {
        internal const string LIBRARY = "d:\\visual studio\\Hazel C-sharp\\x64\\Debug\\ImGui\\ImGui.dll";

        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplOpenGL3_RenderDrawData(ImDrawDataPtr draw_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ImplOpenGL3_NewFrame();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ImGui_ImplOpenGL3_Init(string version);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* AcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void AlignTextToFramePadding();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte Begin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginChild(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginChildID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginDragDropTarget();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void BeginGroup();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginMainMenuBar();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginMenu(byte* label, byte enabled);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginMenuBar();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginPopupContextItem(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginPopupContextVoid(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginPopupContextWindow(byte* str_id, ImGuiMouseButton mouse_button, byte also_over_items);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte BeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void BeginTooltip();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Bullet();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void BulletText(byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte Button(byte* label, Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float CalcItemWidth();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void CalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "CalcTextSize_nonUDT2")]
        public static extern Vector2 CalcTextSize(byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void CaptureKeyboardFromApp(byte want_capture_keyboard_value);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void CaptureMouseFromApp(byte want_capture_mouse_value);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte Checkbox(byte* label, byte* v);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CheckboxFlags(byte* label, uint* flags, uint flags_value);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void CloseCurrentPopup();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CollapsingHeader(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CollapsingHeaderBoolPtr(byte* label, byte* p_open, ImGuiTreeNodeFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ColorConvertFloat4ToU32(Vector4 @in);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ColorConvertU32ToFloat4_nonUDT2")]
        public static extern Vector4 ColorConvertU32ToFloat4(uint @in);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Columns(int count, byte* id, byte border);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte Combo(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ComboStr(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyContext(IntPtr ctx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte DragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Dummy(Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void End();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndChild();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndChildFrame();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndCombo();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndDragDropSource();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndDragDropTarget();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndFrame();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndGroup();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndMainMenuBar();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndMenu();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndMenuBar();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndPopup();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndTabBar();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndTabItem();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EndTooltip();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* GetBackgroundDrawList();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GetClipboardText();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetColorU32(ImGuiCol idx, float alpha_mul);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetColorU32Vec4(Vector4 col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetColorU32U32(uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetColumnIndex();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetColumnOffset(int column_index);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetColumnsCount();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetColumnWidth(int column_index);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetContentRegionAvail_nonUDT2")]
        public static extern Vector2 GetContentRegionAvail();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetContentRegionMax_nonUDT2")]
        public static extern Vector2 GetContentRegionMax();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetCurrentContext();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCursorPos_nonUDT2")]
        public static extern Vector2 GetCursorPos();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetCursorPosX();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetCursorPosY();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCursorScreenPos_nonUDT2")]
        public static extern Vector2 GetCursorScreenPos();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCursorStartPos_nonUDT2")]
        public static extern Vector2 GetCursorStartPos();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* GetDragDropPayload();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* GetDrawData();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetDrawListSharedData();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* GetFont();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetFontSize();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFontTexUvWhitePixel_nonUDT2")]
        public static extern Vector2 GetFontTexUvWhitePixel();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* GetForegroundDrawList();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFrameCount();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetFrameHeight();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetFrameHeightWithSpacing();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetIDStr(byte* str_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetIDRange(byte* str_id_begin, byte* str_id_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetIDPtr(void* ptr_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* GetIO();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetItemRectMax_nonUDT2")]
        public static extern Vector2 GetItemRectMax();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetItemRectMin_nonUDT2")]
        public static extern Vector2 GetItemRectMin();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetItemRectSize_nonUDT2")]
        public static extern Vector2 GetItemRectSize();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetKeyIndex(ImGuiKey imgui_key);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor GetMouseCursor();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMouseDragDelta_nonUDT2")]
        public static extern Vector2 GetMouseDragDelta(ImGuiMouseButton button, float lock_threshold);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMousePos_nonUDT2")]
        public static extern Vector2 GetMousePos();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMousePosOnOpeningCurrentPopup_nonUDT2")]
        public static extern Vector2 GetMousePosOnOpeningCurrentPopup();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetScrollMaxX();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetScrollMaxY();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetScrollX();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetScrollY();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* GetStateStorage();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* GetStyle();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GetStyleColorName(ImGuiCol idx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* GetStyleColorVec4(ImGuiCol idx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetTextLineHeight();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetTextLineHeightWithSpacing();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern double GetTime();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetTreeNodeToLabelSpacing();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* GetVersion();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetWindowContentRegionMax_nonUDT2")]
        public static extern Vector2 GetWindowContentRegionMax();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetWindowContentRegionMin_nonUDT2")]
        public static extern Vector2 GetWindowContentRegionMin();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetWindowContentRegionWidth();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* GetWindowDrawList();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetWindowHeight();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetWindowPos_nonUDT2")]
        public static extern Vector2 GetWindowPos();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetWindowSize_nonUDT2")]
        public static extern Vector2 GetWindowSize();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float GetWindowWidth();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Indent(float indent_w);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte InvisibleButton(byte* str_id, Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsAnyItemActive();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsAnyItemFocused();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsAnyItemHovered();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsAnyMouseDown();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemActivated();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemActive();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemDeactivated();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemDeactivatedAfterEdit();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemEdited();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemFocused();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemHovered(ImGuiHoveredFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemToggledOpen();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsItemVisible();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsKeyDown(int user_key_index);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsKeyPressed(int user_key_index, byte repeat);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsKeyReleased(int user_key_index);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMouseClicked(ImGuiMouseButton button, byte repeat);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMouseDoubleClicked(ImGuiMouseButton button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMouseDown(ImGuiMouseButton button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMousePosValid(Vector2* mouse_pos);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsMouseReleased(ImGuiMouseButton button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsPopupOpen(byte* str_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsRectVisible(Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsRectVisibleVec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsWindowAppearing();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsWindowCollapsed();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte IsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LabelText(byte* label, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ListBoxStr_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ListBoxFooter();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ListBoxHeaderVec2(byte* label, Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ListBoxHeaderInt(byte* label, int items_count, int height_in_items);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogButtons();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogFinish();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogText(byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogToClipboard(int auto_open_depth);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogToFile(int auto_open_depth, byte* filename);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogToTTY(int auto_open_depth);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* MemAlloc(uint size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MemFree(void* ptr);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte MenuItemBool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte MenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void NewFrame();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void NewLine();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void NextColumn();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void OpenPopup(byte* str_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte OpenPopupOnItemClick(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PlotHistogramFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PlotLines(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopAllowKeyboardFocus();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopButtonRepeat();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopClipRect();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopFont();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopID();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopItemWidth();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopStyleColor(int count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopStyleVar(int count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PopTextWrapPos();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushAllowKeyboardFocus(byte allow_keyboard_focus);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushButtonRepeat(byte repeat);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushFont(ImFont* font);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushIDStr(byte* str_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushIDRange(byte* str_id_begin, byte* str_id_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushIDPtr(void* ptr_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushIDInt(int int_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushItemWidth(float item_width);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushStyleColorU32(ImGuiCol idx, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushStyleColor(ImGuiCol idx, Vector4 col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushStyleVarFloat(ImGuiStyleVar idx, float val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushStyleVarVec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushTextWrapPos(float wrap_local_pos_x);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte RadioButtonBool(byte* label, byte active);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte RadioButtonIntPtr(byte* label, int* v, int v_button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Render();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SameLine(float offset_from_start_x, float spacing);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SaveIniSettingsToDisk(byte* ini_filename);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* SaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte Selectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Separator();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetClipboardText(byte* text);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetColumnOffset(int column_index, float offset_x);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetColumnWidth(int column_index, float width);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCurrentContext(IntPtr ctx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCursorPos(Vector2 local_pos);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCursorPosX(float local_x);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCursorPosY(float local_y);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCursorScreenPos(Vector2 pos);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetItemAllowOverlap();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetItemDefaultFocus();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetKeyboardFocusHere(int offset);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextItemWidth(float item_width);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowBgAlpha(float alpha);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowContentSize(Vector2 size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowFocus();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScrollFromPosX(float local_x, float center_x_ratio);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScrollFromPosY(float local_y, float center_y_ratio);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScrollHereX(float center_x_ratio);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScrollHereY(float center_y_ratio);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScrollX(float scroll_x);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScrollY(float scroll_y);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetStateStorage(ImGuiStorage* storage);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTooltip(byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowCollapsedBool(byte collapsed, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowFocus();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowFocusStr(byte* name);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowFontScale(float scale);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowPosVec2(Vector2 pos, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowSizeVec2(Vector2 size, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowAboutWindow(byte* p_open);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowDemoWindow(byte* p_open);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowFontSelector(byte* label);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowMetricsWindow(byte* p_open);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowStyleEditor(ImGuiStyle* @ref);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ShowStyleSelector(byte* label);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowUserGuide();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderInt(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderInt2(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderInt3(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderInt4(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte SmallButton(byte* label);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Spacing();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void StyleColorsClassic(ImGuiStyle* dst);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void StyleColorsDark(ImGuiStyle* dst);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void StyleColorsLight(ImGuiStyle* dst);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Text(byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextColored(Vector4 col, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDisabled(byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextUnformatted(byte* text, byte* text_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextWrapped(byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TreeNodeStr(byte* label);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TreeNodeStrStr(byte* str_id, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TreeNodePtr(void* ptr_id, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TreeNodeExStr(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TreeNodeExStrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TreePop();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TreePushStr(byte* str_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TreePushPtr(void* ptr_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Unindent(float indent_w);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ValueBool(byte* prefix, byte b);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ValueInt(byte* prefix, int v);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ValueUint(byte* prefix, uint v);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ValueFloat(byte* prefix, float v, byte* float_format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte VSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte VSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte VSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, float power);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImColor_HSV_nonUDT2")]
        public static extern ImColor ImColor_HSV(ImColor* self, float h, float s, float v, float a);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorInt(int r, int g, int b, int a);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorU32(uint rgba);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorFloat(float r, float g, float b, float a);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColorVec4(Vector4 col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCurve(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, byte closed, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTextFontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_Clear(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ClearFreeMemory(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetClipRectMax_nonUDT2")]
        public static extern Vector2 ImDrawList_GetClipRectMax(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetClipRectMin_nonUDT2")]
        public static extern Vector2 ImDrawList_GetClipRectMin(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, byte closed, float thickness);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_UpdateClipRect(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_UpdateTextureID(ImDrawList* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddGlyph(ImFont* self, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_CalcTextSizeA_nonUDT2")]
        public static extern Vector2 ImFont_CalcTextSizeA(ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetFallbackChar(ImFont* self, ushort c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, uint id, int width, int height);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, int n);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, int n);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper(int items_count, float items_height);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairInt(uint _key, int _val_i);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairFloat(uint _key, float _val_f);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairPtr(uint _key, void* _val_p);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeStr(byte* _b, byte* _e);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2Float(float _x, float _y);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4();
        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);
    }
}
