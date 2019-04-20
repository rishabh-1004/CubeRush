using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour {
    
    public void StartGame1()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

