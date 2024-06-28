using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

namespace DynamicObjects {

    [CustomEditor(typeof(Signal))]
    public class SignalDrawer : Editor {

        private bool _showListeners = true;

        public override void OnInspectorGUI() {
            serializedObject.Update();
            var signal = target as Signal;
            if (signal == null) return;

            if (GUILayout.Button("Emit Signal")) signal.Emit();

            _showListeners = EditorGUILayout.Foldout(_showListeners, "Connected Listeners: " + signal.GetConnectedListeners().Count);
            if (_showListeners) {
                EditorGUILayout.Space();
                foreach (Component parent in GetSignalListenerParents(signal)) {
                    EditorGUILayout.ObjectField(parent, typeof(Component), true);
                }
            }

            serializedObject.ApplyModifiedProperties();
        }

        private List<Component> GetSignalListenerParents(Signal signal) {
            List<Component> parents = new();
            foreach (SignalListener listener in signal.GetConnectedListeners()) {
                Component parent = listener.gameObject.GetComponentInParent<Component>();
                if (parent != null && !parents.Contains(parent)) {
                    parents.Add(parent);
                }
            }
            return parents;
        }

    }

}