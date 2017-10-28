using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            rb.AddForce(-transform.right * speed);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(transform.right * speed);
        }   
    }
}
