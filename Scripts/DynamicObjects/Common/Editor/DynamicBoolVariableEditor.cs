using UnityEditor;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicBool), true)]
    public class DynamicBoolEditor : DynamicVariableEditor<bool> {
        protected override bool ValueField(bool value) => EditorGUILayout.Toggle(value);
    }

}

