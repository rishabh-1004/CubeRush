
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Player_Movement movement;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit a obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
