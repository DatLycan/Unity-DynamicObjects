using UnityEngine;
using UnityEngine.Events;

namespace DynamicObjects {

    [Icon("Gizmos/SignalListener Icon.png")]
    public class DynamicSignalListener : MonoBehaviour {

        [System.Serializable]
        private class DynamicResponse : UnityEvent<Component, object> { }

        [SerializeField] private Signal signal;
        [SerializeField] private DynamicResponse response;


        private void OnEnable() => signal.Connect(this);
        private void OnDisable() => signal.Disconnect(this);

        public void OnSignalEmitted(Component sender, object args) => response.Invoke(sender, args);
    }

}