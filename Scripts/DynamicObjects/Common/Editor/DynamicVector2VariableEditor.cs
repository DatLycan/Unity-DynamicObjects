using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicVector2), true)]
    public class DynamicVector2Editor : DynamicVariableEditor<Vector2> {
        protected override Vector2 ValueField(Vector2 value) => EditorGUILayout.Vector2Field("", value);
    }

}

