using System;
using DynamicObjects;
using UnityEngine;

namespace DynamicObjects {
    [Serializable]
    public class DynamicReference<T> {

        [SerializeField] private DynamicVariable<T> dynamicVariable;
        [SerializeField] private bool useLocalValue = false;
        [SerializeField] private T _localValue;


        public DynamicReference() { }
        public DynamicReference(T localValue) => _localValue = localValue;
        public static implicit operator T(DynamicReference<T> reference) => reference.Value;

        public T Value {
            get => useLocalValue ? _localValue : dynamicVariable == null ? throw new NullReferenceException() : dynamicVariable.Get();
            set {
                if (useLocalValue) {
                    _localValue = value;
                }
                else {
                    if (dynamicVariable == null) throw new NullReferenceException();
                    dynamicVariable.Set(value);
                }
            }
        }
    }
}
