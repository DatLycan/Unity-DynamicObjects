using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR

namespace DynamicObjects {

    [CustomEditor(typeof(SignalListener))]
    class CustomSignalListenerInspector : Editor {

        private static readonly string[] _noScriptLabel = new string[] { "m_Script" };
        public override void OnInspectorGUI() {
            var signalListener = target as SignalListener;
            if (signalListener == null) return;

            serializedObject.Update();
            DrawPropertiesExcluding(serializedObject, _noScriptLabel);
            serializedObject.ApplyModifiedProperties();
        }
    }


    [CustomEditor(typeof(Signal))]
    class CustomSignalInspector : Editor {

        private static readonly string[] _noScriptLabel = new string[] { "m_Script" };
        public override void OnInspectorGUI() {
            var signal = target as Signal;
            if (signal == null) return;

            serializedObject.Update();
            if (GUILayout.Button("Emit Signal")) signal.Emit();
            GUILayout.Label("Connected Listeners: " + signal.GetConnectedListeners().Count);

            DrawPropertiesExcluding(serializedObject, _noScriptLabel);
            serializedObject.ApplyModifiedProperties();
        }
    }

}

#endif