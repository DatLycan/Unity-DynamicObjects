using DynamicObjects.Common;
using UnityEngine;

namespace DynamicObjects {

    [Icon("Gizmos/DynamicRuntimeSetAdder Icon.png")]
    [AddComponentMenu("Dynamic Objects/Runtime Set Member")]
    public class DynamicRuntimeSetMember : MonoBehaviour {

        [SerializeField] private DynamicGameObjectRuntimeSet runtimeSet;

        private void OnEnable() => runtimeSet.Add(this.gameObject);
        private void OnDisable() => runtimeSet.Remove(this.gameObject);

        public DynamicGameObjectRuntimeSet Get() => runtimeSet;
    }
}
