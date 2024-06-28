using UnityEngine;
using UnityEditor;

namespace DynamicObjects {

    public abstract class DynamicVariableEditor<T> : Editor {

        private bool showDebug = false;

        private SerializedProperty emitSignal;
        private SerializedProperty signal;
        private SerializedProperty initialValue;

        void OnEnable() {
            emitSignal = serializedObject.FindProperty(nameof(emitSignal));
            signal = serializedObject.FindProperty(nameof(signal));
            initialValue = serializedObject.FindProperty(nameof(initialValue));
        }

        public override void OnInspectorGUI() {
            serializedObject.Update();
            var dynamicVariable = target as DynamicVariable<T>;
            if (dynamicVariable == null) return;

            GUILayout.Label("Initial Value");
            var value = ValueField(dynamicVariable.initialValue);
            if (!dynamicVariable.initialValue.Equals(value)) dynamicVariable.initialValue = value;

            GUILayout.BeginHorizontal();
            EditorGUILayout.PropertyField(emitSignal);
            EditorGUI.BeginDisabledGroup(!dynamicVariable.emitSignal);
            EditorGUILayout.PropertyField(signal, GUIContent.none);
            EditorGUI.EndDisabledGroup();
            GUILayout.EndHorizontal();

            if (Application.isPlaying) {
                EditorGUILayout.Space();
                showDebug = EditorGUILayout.Foldout(showDebug, "Current Value");
                if (showDebug) {
                    EditorGUILayout.Space();
                    EditorGUI.BeginDisabledGroup(true);
                    value = ValueField(dynamicVariable.Get());
                    EditorGUI.EndDisabledGroup();
                    if (GUILayout.Button("Change to Initial Value")) dynamicVariable.Set(dynamicVariable.initialValue);
                }
            }

            serializedObject.ApplyModifiedProperties();
        }

        protected virtual T ValueField(T value) {
            GUILayout.Label(value.ToString());
            return value;
        }

        public override bool RequiresConstantRepaint() => true;
    }

}
