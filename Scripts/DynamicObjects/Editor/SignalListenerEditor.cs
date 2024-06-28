using UnityEditor;

namespace DynamicObjects {

    [CustomEditor(typeof(SignalListener))]
    public class SignalListenerEditor : Editor {

        private SerializedProperty signal;
        private SerializedProperty response;

        void OnEnable() {
            signal = serializedObject.FindProperty(nameof(signal));
            response = serializedObject.FindProperty(nameof(response));
        }

        public override void OnInspectorGUI() {
            serializedObject.Update();
            var signalListener = target as SignalListener;
            if (signalListener == null) return;

            EditorGUILayout.PropertyField(signal);
            EditorGUILayout.PropertyField(response);

            serializedObject.ApplyModifiedProperties();
        }
    }

}
