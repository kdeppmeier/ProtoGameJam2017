using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float jumpHeight;
    public float groundDistance;
    public AudioSource winSound;
    public AudioSource coinSound;
    public GameObject levelCompletePanel;

    private Rigidbody2D rb;
    public LayerMask groundLayer;

    public Sprite leftSprite;
    public Sprite rightSprite;
    private SpriteRenderer playerSprite;

    private bool facingRight;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //levelCompletePanel = GameObject.Find("LevelComplete");
        facingRight = true;
        playerSprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        bool prevFacingRight = facingRight;
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-transform.right * speed);ight
            //rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.left);
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            facingRight = false;
        }
        else if (Input.GetKey("d"))
        {
            //rb.AddForce(transform.right * speed);
            //rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.right);
            rb.velocity = new Vector2(speed, rb.velocity.y);
            facingRight = true;
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKeyDown("w"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundLayer);

            if (hit.collider != null)
            {
                //rb.MovePosition(rb.position + speed * Time.deltaTime * Vector2.up);
                //rb.AddForce(Vector2.up * jumpSpeed);
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            }
        }
        if (prevFacingRight != facingRight)
        {
            if (facingRight)
            {
                playerSprite.sprite = rightSprite;
            }
            else
            {
                playerSprite.sprite = leftSprite;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Finish"))
        {
            //Debug.Log("Level Completed");
            //Level end stuff - pop-up menu?
            
            levelCompletePanel.SetActive(true);
            rb.velocity = Vector2.zero;
            enabled = false;
            winSound.Play();
        }
        if (other.gameObject.tag.Equals("Coins"))
        {
            coinSound.Play();
        }
    }
}
