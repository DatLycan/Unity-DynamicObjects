using DynamicObjects;
using UnityEngine;

public class ExamplePlayer : MonoBehaviour {

    [SerializeField] private DynamicReference<float> playerHealth;
    [SerializeField] private DynamicReference<string> playerName;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerHealth.Value -= 5;
        }
    }

    public void OnPlayerHealthChanged() {
        Debug.Log($"Signal received! {(string)playerName}'s current health:   {(float)playerHealth}");
    }
}
