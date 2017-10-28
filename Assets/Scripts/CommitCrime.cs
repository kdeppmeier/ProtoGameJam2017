using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommitCrime : MonoBehaviour
{
    public Sprite crimeCommittedSprite;
    SpriteRenderer spriteRend;

    public int crimeValue;

    public GameObject coinCount;

    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
    }

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            spriteRend.sprite = crimeCommittedSprite;
            coinCount.GetComponent<CoinCountUI>().AddCoin(crimeValue);
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}
