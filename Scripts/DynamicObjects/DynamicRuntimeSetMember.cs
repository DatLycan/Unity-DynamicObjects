using DynamicObjects.Common;
using UnityEngine;

namespace DynamicObjects {

    [Icon("Gizmos/DynamicRuntimeSetAdder Icon.png")]
    [AddComponentMenu("DynamicObjects/Runtime Set Member")]
    public class DynamicRuntimeSetComponent : MonoBehaviour {

        [SerializeField] private DynamicGameObjectRuntimeSet runtimeSet;

        private void OnEnable() => runtimeSet.Add(this.gameObject);
        private void OnDisable() => runtimeSet.Remove(this.gameObject);
    }
}
