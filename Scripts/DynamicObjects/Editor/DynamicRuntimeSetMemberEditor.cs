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
                EditorGUILayout.BeginHorizontal();

                if (GUILayout.Button("Add to Runtime Set")) {
                    if (!runtimeSet.Contains(dynamicRuntimeSetMember.gameObject)) {
                        runtimeSet.Add(dynamicRuntimeSetMember.gameObject);
                        Debug.Log($"Added [{dynamicRuntimeSetMember.gameObject.name}] to [{runtimeSet.name}]");
                    }
                }
                if (GUILayout.Button("Remove from Runtime Set")) {
                    if (runtimeSet.Contains(dynamicRuntimeSetMember.gameObject)) {
                        runtimeSet.Remove(dynamicRuntimeSetMember.gameObject);
                        Debug.Log($"Removed [{dynamicRuntimeSetMember.gameObject.name}] from [{runtimeSet.name}]");
                    }
                }

                EditorGUILayout.EndHorizontal();
            }

            serializedObject.ApplyModifiedProperties();
        }
    }

}
