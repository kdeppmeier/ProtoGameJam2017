using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Script requires the CoinCount UI element to be present in the scene
    private GameObject coinCount;

    void Start()
    {
        coinCount = GameObject.Find("CoinCount");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            coinCount.GetComponent<CoinCountUI>().AddCoin(1);
            Destroy(gameObject);
        }
    }
}
