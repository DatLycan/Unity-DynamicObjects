using DynamicObjects.Common;
using UnityEngine;

public class ExamplePlayerDisableButton : MonoBehaviour {

    [SerializeField] private DynamicGameObjectRuntimeSet runtimeSet;

    public void OnButtonPressed() => DisablePlayer();

    private void DisablePlayer() {
        if (runtimeSet.Get().Count <= 0) return;
        runtimeSet.GetItemAtIndex(0).SetActive(false);
    }
}
