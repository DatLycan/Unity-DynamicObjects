using System.Collections.Generic;
using UnityEngine;

public class DynamicRuntimeSet<T> : ScriptableObject {

    private List<T> members = new();

    public void Add(T item) { if (!Contains(item)) members.Add(item); }
    public void Remove(T item) { if (Contains(item)) members.Remove(item); }

    public List<T> Get() => members;
    public void Clear() => members.Clear();
    public bool Contains(T item) => members.Contains(item);
    public T GetItemAtIndex(int index) => members[index];

    public static implicit operator List<T>(DynamicRuntimeSet<T> reference) => reference.members;
}
