using UnityEngine;


namespace DynamicObjects {

    public class DynamicVariable<T> : ScriptableObject {

        [SerializeField] private T _initialValue;

        [HideInInspector] public T Value;

        private void OnEnable() => Value = _initialValue;

        public static implicit operator T(DynamicVariable<T> variable) => variable.Value;
    }

}






