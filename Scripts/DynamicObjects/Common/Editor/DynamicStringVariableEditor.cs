using UnityEditor;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicString), true)]
    public class DynamicStringEditor : DynamicVariableEditor<string> {
        protected override string ValueField(string value) => EditorGUILayout.DelayedTextField(value);
    }

}

