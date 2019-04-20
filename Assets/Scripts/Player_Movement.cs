using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public Rigidbody rb;
    public float ForwardForce=1000f;
    public float sidewayForce = 600f;


	// Use this for initialization
	void Start () {
        //Debug.Log("Hello bitches");
        //rb.AddForce(0,200,500);
        //rb.useGravity = false;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //time.deltatime to keep same speed on all computer
        //forward force for z axis
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
