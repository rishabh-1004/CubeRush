
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float delay = 1f;
    public GameObject completeLevelUI;
	// Use this for initialization
	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Restart Game
            Invoke("Restart", delay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
    } 
}
