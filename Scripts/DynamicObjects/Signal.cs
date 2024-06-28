using System.Collections.Generic;
using UnityEngine;

namespace DynamicObjects {

    [CreateAssetMenu(fileName = "Signal", menuName = "Dynamic Objects/Signal")]
    public class Signal : ScriptableObject {


        private List<SignalListener> listeners = new();


        public List<SignalListener> GetConnectedListeners() => listeners;


        public void Connect(SignalListener listener) {
            if (listeners.Contains(listener)) return;
            listeners.Add(listener);
        }

        public void Disconnect(SignalListener listener) {
            if (!listeners.Contains(listener)) return;
            listeners.Remove(listener);
        }

        public void Emit(Component sender = null, object args = null) {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnSignalEmitted(sender, args);
        }
    }

}