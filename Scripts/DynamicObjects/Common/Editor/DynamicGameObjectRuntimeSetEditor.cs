using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicGameObjectRuntimeSet), true)]
    public class DynamicGameObjectRuntimeSetEditor : DynamicRuntimeSetEditor<GameObject> {
        protected override GameObject DisplayMember(GameObject member) {
            EditorGUILayout.ObjectField(member, typeof(GameObject), true);
            return member;
        }
    }

}