using DynamicObjects.Common;
using UnityEditor;
using UnityEngine;

namespace DynamicObjects {

    [CustomEditor(typeof(DynamicRuntimeSetMember))]
    public class DynamicRuntimeSetMemberEditor : Editor {

        private static readonly string[] _scriptName = new string[] { "m_Script" };

        public override void OnInspectorGUI() {
            serializedObject.Update();
            var dynamicRuntimeSetMember = target as DynamicRuntimeSetMember;
            if (dynamicRuntimeSetMember == null) return;
            DrawPropertiesExcluding(serializedObject, _scriptName);

            if (Application.isPlaying) {

                DynamicGameObjectRuntimeSet runtimeSet = dynamicRuntimeSetMember.Get();

                EditorGUILayout.Space();
                if (GUILayout.Button("Remove from RuntimeSet")) {
                    if (runtimeSet.Contains(dynamicRuntimeSetMember.gameObject)) {
                        runtimeSet.Remove(dynamicRuntimeSetMember.gameObject);
                        Debug.Log($"Removed [{dynamicRuntimeSetMember.gameObject.name}] from [{runtimeSet.name}]");
                    }
                }

                EditorGUILayout.Space();
                if (GUILayout.Button("Add to RuntimeSet")) {
                    if (!runtimeSet.Contains(dynamicRuntimeSetMember.gameObject)) {
                        runtimeSet.Add(dynamicRuntimeSetMember.gameObject);
                        Debug.Log($"Added [{dynamicRuntimeSetMember.gameObject.name}] to [{runtimeSet.name}]");
                    }
                }

            }

            serializedObject.ApplyModifiedProperties();
        }
    }

}
