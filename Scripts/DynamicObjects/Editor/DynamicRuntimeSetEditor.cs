using UnityEngine;
using UnityEditor;

namespace DynamicObjects {

    public abstract class DynamicRuntimeSetEditor<T> : Editor {

        public override void OnInspectorGUI() {
            serializedObject.Update();
            var dynamicRuntimeSet = target as DynamicRuntimeSet<T>;
            if (dynamicRuntimeSet == null) return;

            if (Application.isPlaying) {
                GUILayout.Label("Members: " + dynamicRuntimeSet.Get().Count);

                EditorGUILayout.Space();
                foreach (T member in dynamicRuntimeSet.Get()) {
                    DisplayMember(member);
                }

                if (GUILayout.Button("Clear")) dynamicRuntimeSet.Clear();
            }

            serializedObject.ApplyModifiedProperties();
        }

        protected virtual T DisplayMember(T member) {
            GUILayout.Label(member.ToString());
            return member;
        }

    }

}
