using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public GameObject coinCount;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            coinCount.GetComponent<CoinCountUI>().AddCoin(1);
            Destroy(gameObject);
        }
    }
}
