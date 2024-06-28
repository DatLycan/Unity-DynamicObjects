using DynamicObjects;
using UnityEngine;

public class ExamplePlayer : MonoBehaviour {

    [SerializeField] private DynamicReference<float> playerHealth;
    [SerializeField] private DynamicReference<string> playerName;
    [SerializeField] private DynamicReference<float> damage;

    public void OnPlayerHurt() => playerHealth.Value -= damage.Value;

    public void OnPlayerHealthChanged() {
        Debug.Log($"PlayerHealthChanged Signal received! {playerName.Value}'s current health:  {playerHealth.Value}");
    }
}
