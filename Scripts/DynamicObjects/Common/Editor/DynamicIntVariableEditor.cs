using UnityEditor;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicInt), true)]
    public class DynamicIntEditor : DynamicVariableEditor<int> {
        protected override int ValueField(int value) => EditorGUILayout.IntField("", value);
    }

}

