using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommitCrime : MonoBehaviour
{
    public Sprite crimeCommittedSpriteLeft;
    public Sprite crimeCommittedSpriteRight;
    //public Sprite crimeCommittedSprite;
    public AudioSource womanScream;
    public AudioSource manScream;
    SpriteRenderer spriteRend;
    Police policeScript;

    public int crimeValue;

    public GameObject coinCount;

    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        policeScript = gameObject.GetComponent<Police>();
    }

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            //Changes the crime victim's sprites
            if (policeScript.GetFacingRight())
            {
                spriteRend.sprite = crimeCommittedSpriteRight;
            }
            else
            {
                spriteRend.sprite = crimeCommittedSpriteLeft;
            }
            policeScript.leftSprite = crimeCommittedSpriteLeft;
            policeScript.rightSprite = crimeCommittedSpriteRight;

            coinCount.GetComponent<CoinCountUI>().AddCoin(crimeValue);
            gameObject.GetComponent<Collider2D>().enabled = false;

            if( this.gameObject.tag.Equals("Lady"))
            {
                womanScream.Play();
            }

            if(this. gameObject.tag.Equals("Lawyer"))
            {
                manScream.Play();
            }
        }
    }
}
