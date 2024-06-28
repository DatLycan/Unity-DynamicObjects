using UnityEngine;

public class ExamplePlayer : MonoBehaviour {

    [SerializeField] private DynamicReference<float> playerHealth;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerHealth.Value -= 5;
            Debug.Log(playerHealth.Value);
        }
    }
}
