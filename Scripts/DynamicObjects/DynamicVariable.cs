using UnityEngine;

namespace DynamicObjects {

    public class DynamicVariable<T> : ScriptableObject {

        public T initialValue;
        public bool emitSignal = false;
        public Signal signal;

        private T _value;

        private T Value {
            get => _value;
            set {
                _value = value;
                if (emitSignal) signal.Emit(null, Value);
            }
        }

        private void OnEnable() => Value = initialValue;

        public T Set(T value) => Value = value;
        public T Get() => Value;
    }

}