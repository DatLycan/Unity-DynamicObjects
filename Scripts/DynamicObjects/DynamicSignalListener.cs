using UnityEngine;
using UnityEngine.Events;

namespace DynamicObjects {

    [Icon("Gizmos/SignalListener Icon.png")]
    [AddComponentMenu("Dynamic Objects/Signal Listener")]
    public class DynamicSignalListener : MonoBehaviour {

        [System.Serializable]
        private class DynamicResponse : UnityEvent<Component, object> { }

        [SerializeField] private DynamicSignal signal;
        [SerializeField] private DynamicResponse response;


        private void OnEnable() => signal.Connect(this);
        private void OnDisable() => signal.Disconnect(this);

        public void OnSignalEmitted(Component sender, object args) => response.Invoke(sender, args);
    }

}