using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicRuntimeSet<T> : ScriptableObject {

    private List<T> members = new();

    public List<T> Get() => members;
    public void Clear() => members.Clear();
    public void Add(T item) => members.Add(item);
    public void Remove(T item) => members.Remove(item);
    public T GetItemAtIndex(int index) => members[index];

    public static implicit operator List<T>(DynamicRuntimeSet<T> reference) => reference.members;
}
