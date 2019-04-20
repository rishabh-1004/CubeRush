
using UnityEngine;

public class Follow_Player : MonoBehaviour {

    public Vector3 offset;
    public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
