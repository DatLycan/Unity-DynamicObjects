using UnityEditor;
using UnityEngine;

namespace DynamicObjects.Common {

    [CustomEditor(typeof(DynamicQuaternion), true)]
    public class DynamicQuaternionEditor : DynamicVariableEditor<Quaternion> {
        protected override Quaternion ValueField(Quaternion value) {
            var vecValue = EditorGUILayout.Vector4Field("", new Vector4(value.x, value.y, value.z, value.w));
            return new Quaternion(vecValue.x, vecValue.y, vecValue.z, vecValue.w);
        }
    }

}

