﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommitCrime : MonoBehaviour
{
    //Requires Sound prefab and Canvas with CoinCount

    public Sprite crimeCommittedSpriteLeft;
    public Sprite crimeCommittedSpriteRight;
    //public Sprite crimeCommittedSprite;
    private AudioSource womanScream;
    private AudioSource manScream;
    SpriteRenderer spriteRend;
    Police policeScript;

    public int crimeValue;

    private GameObject coinCount;

    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        policeScript = gameObject.GetComponent<Police>();

        coinCount = GameObject.Find("CoinCount");
        womanScream = GameObject.Find("FemaleScreamSound").GetComponent<AudioSource>();
        manScream = GameObject.Find("MaleScreamSound").GetComponent<AudioSource>();
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
