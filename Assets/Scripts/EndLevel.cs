
using UnityEngine;

public class EndLevel : MonoBehaviour {

    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        Debug.Log("Entered");
        gameManager.LevelComplete();
    }

}
