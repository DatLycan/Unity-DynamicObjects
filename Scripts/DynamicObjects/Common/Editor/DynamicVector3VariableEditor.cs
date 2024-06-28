using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicVector3), true)]
    public class DynamicVector3Editor : DynamicVariableEditor<Vector3> {
        protected override Vector3 ValueField(Vector3 value) => EditorGUILayout.Vector3Field("", value);
    }

}

