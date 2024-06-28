using UnityEngine;

namespace DynamicObjects {

    public class DynamicVariable<T> : ScriptableObject {

        [SerializeField] private bool _emitSignal = false;
        [SerializeField] private Signal _signal;
        [SerializeField] private T _initialValue;
        [SerializeField] private T _value;

        [HideInInspector]
        public T Value {
            get => _value;
            set {
                _value = value;
                if (_emitSignal) _signal.Emit(null, Value);
            }
        }

        private void OnEnable() => Value = _initialValue;

        public static implicit operator T(DynamicVariable<T> variable) => variable.Value;
    }

}