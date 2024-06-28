using UnityEditor;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicChar), true)]
    public class DynamicCharEditor : DynamicVariableEditor<char> {
        protected override char ValueField(char value) {
            var strValue = EditorGUILayout.DelayedTextField(value.ToString());
            return !string.IsNullOrEmpty(strValue) && strValue.Length > 0 ? strValue[0] : value;
        }
    }

}

