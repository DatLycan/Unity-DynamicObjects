using UnityEditor;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicFloat), true)]
    public class DynamicFloatEditor : DynamicVariableEditor<float> {
        protected override float ValueField(float value) => EditorGUILayout.FloatField("", value);
    }

}

