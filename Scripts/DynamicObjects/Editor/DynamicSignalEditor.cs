using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

namespace DynamicObjects {

    [CustomEditor(typeof(Signal))]
    public class DynamicSignalEditor : Editor {

        private bool showListeners = false;

        public override void OnInspectorGUI() {
            serializedObject.Update();
            var signal = target as Signal;
            if (signal == null) return;


            if (Application.isPlaying) {
                if (GUILayout.Button("Emit Signal")) signal.Emit();

                showListeners = EditorGUILayout.Foldout(showListeners, "Connected Listeners: " + signal.GetConnectedListeners().Count);
                if (showListeners) {
                    EditorGUILayout.Space();
                    foreach (DynamicSignalListener listener in signal.GetConnectedListeners()) {
                        EditorGUILayout.ObjectField(listener.gameObject, typeof(Component), true);
                    }
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }

}