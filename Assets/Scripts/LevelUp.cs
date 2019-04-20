
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour {

    public void LoadNextLevel()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
