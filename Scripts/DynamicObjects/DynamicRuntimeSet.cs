using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicRuntimeSet<T> : ScriptableObject {

    private List<T> items = new();

    public void Clear() => items.Clear();
    public void Add(T item) => items.Add(item);
    public void Remove(T item) => items.Remove(item);
    public T GetItemAtIndex(int index) => items[index];

    public static implicit operator List<T>(DynamicRuntimeSet<T> reference) => reference.items;
}
