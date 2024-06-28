using System;
using DynamicObjects;
using UnityEngine;

namespace DynamicObjects {
    [Serializable]
    public class DynamicReference<T> {

        [SerializeField] private bool _useLocalValue = false;
        [SerializeField] private T _localValue;
        [SerializeField] private DynamicVariable<T> _dynamicVariable;


        public DynamicReference() { }
        public DynamicReference(T localValue) => _localValue = localValue;
        public static implicit operator T(DynamicReference<T> reference) => reference.Value;

        public T Value {
            get => _useLocalValue ? _localValue : _dynamicVariable == null ? throw new NullReferenceException() : _dynamicVariable.Get();
            set {
                if (_useLocalValue) {
                    _localValue = value;
                }
                else {
                    if (_dynamicVariable == null) throw new NullReferenceException();
                    _dynamicVariable.Set(value);
                }
            }
        }
    }
}
