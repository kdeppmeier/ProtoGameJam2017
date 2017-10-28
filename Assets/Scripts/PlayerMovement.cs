using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    private Rigidbody2D rb;
    public LayerMask groundLayer;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-transform.right * speed);ight
            rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.left);
        }
        else if (Input.GetKey("d"))
        {
            //rb.AddForce(transform.right * speed);
            rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.right);
        }
        else if (Input.GetKey("w"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.75F, groundLayer);

            if (hit.collider != null)
            {
                //rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.up);
                rb.AddForce(Vector2.up * jumpSpeed);
            }
        }  
    }
}
