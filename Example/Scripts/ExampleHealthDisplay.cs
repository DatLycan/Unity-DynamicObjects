using DynamicObjects;
using UnityEngine;
using UnityEngine.UI;

public class ExampleHealthDisplay : MonoBehaviour {
    private Text health;
    [SerializeField] private DynamicReference<float> healthReference;

    private void Awake() {
        health = gameObject.GetComponent<Text>();
        health.text = healthReference.Value.ToString();
    }

    public void OnPlayerHealthChanged(Component sender, object value) => health.text = value.ToString();
}
