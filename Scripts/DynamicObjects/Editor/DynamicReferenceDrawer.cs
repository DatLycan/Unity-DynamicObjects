using UnityEngine;
using UnityEditor;

namespace DynamicObjects {
    public abstract class DynamicReferenceDrawer : PropertyDrawer {
        static readonly string[] popupOptions = { "Use Global Value", "Use Local Value" };

        static GUIStyle popupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            popupStyle ??= new(GUI.skin.GetStyle("PaneOptions")) {
                imagePosition = ImagePosition.ImageOnly
            };

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            var popupPosition = new Rect(position.x, position.y + popupStyle.margin.top, popupStyle.fixedWidth + popupStyle.margin.right, position.height);
            var useLocalValue = property.FindPropertyRelative("useLocalValue");
            useLocalValue.boolValue = EditorGUI.Popup(popupPosition, useLocalValue.boolValue ? 1 : 0, popupOptions, popupStyle) == 1;

            position.xMin = popupPosition.xMax;
            if (useLocalValue.boolValue) LocalValueField(position, property.FindPropertyRelative("_localValue"));
            else EditorGUI.PropertyField(position, property.FindPropertyRelative("dynamicVariable"), GUIContent.none);

            if (EditorGUI.EndChangeCheck()) property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }

        protected virtual void LocalValueField(Rect position, SerializedProperty localValue) =>
            EditorGUI.PropertyField(position, localValue, GUIContent.none, true);

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) =>
            property.FindPropertyRelative("useLocalValue").boolValue ? GetLocalValueFieldHeight() : EditorGUIUtility.singleLineHeight;

        protected virtual float GetLocalValueFieldHeight() => EditorGUIUtility.singleLineHeight;
    }
}