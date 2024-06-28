using System.Collections.Generic;
using UnityEngine;

namespace DynamicObjects {

    [CreateAssetMenu(fileName = "Signal", menuName = "Dynamic Objects/Signal")]
    public class DynamicSignal : ScriptableObject {


        private List<DynamicSignalListener> listeners = new();


        public List<DynamicSignalListener> GetConnectedListeners() => listeners;


        public void Connect(DynamicSignalListener listener) {
            if (listeners.Contains(listener)) return;
            listeners.Add(listener);
        }

        public void Disconnect(DynamicSignalListener listener) {
            if (!listeners.Contains(listener)) return;
            listeners.Remove(listener);
        }

        public void Emit(Component sender = null, object args = null) {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnSignalEmitted(sender, args);
        }
    }

}