using System.Collections;
using System.Collections.Generic;
using DynamicObjects;
using UnityEngine;

public class ExampleHurtPlayerButton : MonoBehaviour {
    [SerializeField] private DynamicSignal signal;

    public void OnButtonPressed() => EmitSignal();

    private void EmitSignal() => signal.Emit();
}
