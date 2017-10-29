using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour {
	private Vector2 MovingDirection = Vector2.left;	//initial movement direction
    public float right, left;

    public Sprite leftSprite;
    public Sprite rightSprite;
    private SpriteRenderer spriteRend;

    private bool facingRight;

	// Use this for initialization
	void Start ()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        facingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateMovement ();
	}

	void UpdateMovement()
    {
        //bool prevFacingRight = facingRight;

		if (facingRight)
        {	
            if (this.transform.position.x > right)
            {
                spriteRend.sprite = leftSprite;
                //gameObject.GetComponent<SpriteRenderer> ().flipX = true;
                facingRight = false;
            }
            else
            {
                MovingDirection = Vector2.right;
            }
		}
        else if (!facingRight)
        {
            if (this.transform.position.x < left)
            {
                spriteRend.sprite = rightSprite;
                //gameObject.GetComponent<SpriteRenderer> ().flipX = true;
                facingRight = true;
            }
            else
            {
                MovingDirection = Vector2.left;
            }
        }
		this.transform.Translate (MovingDirection * Time.smoothDeltaTime);	

        //If the NPC has changed direction...
        /*if (facingRight != prevFacingRight)
        {
            if (facingRight)
            {
                spriteRend.sprite = rightSprite;
            }
            else
            {
                spriteRend.sprite = leftSprite;
            }
        }*/
	}

    public bool GetFacingRight()
    {
        return facingRight;
    }
}

