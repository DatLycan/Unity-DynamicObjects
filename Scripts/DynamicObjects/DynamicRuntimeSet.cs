using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicRuntimeSet<T> : ScriptableObject {

    private List<T> items = new();

    public void Initialize() => items.Clear();
    public void AddItem(T item) => items.Add(item);
    public void RemoveItem(T item) => items.Remove(item);
    public T GetItemAtIndex(int index) => items[index];
}
